using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Chargeable_Rates_Updater
{
    class ChargeableRatesUpdater
    {
        public ADODB.Connection OPConnection;
        public RatesData Data = new RatesData();
        
        internal void GetData()
        {
            GetRates();
            GetChargeables();
            FormatDataforUpdate();
        }

        private void FormatDataforUpdate()
        {
            UpdateChargeablesWithLatestRate();
        }


        private void UpdateChargeablesWithLatestRate()
        {
            foreach (RatesData.ChargeablesRow Chargeable in Data.Chargeables.Rows)
            {
                RatesData.RatesRow tempRate;
                tempRate = Data.Rates.AsEnumerable().
                                    Where(rate => rate.Refkey == Chargeable.Refkey).
                                    OrderByDescending(rate => rate.Created).FirstOrDefault();
                try
                {
                    Chargeable.Rate = tempRate.Rate;
                    Chargeable.User = tempRate.User;
                    Chargeable.Created = tempRate.Created;
                }
                catch
                {
                    continue;
                }

            }
        }

        private void GetChargeables()
        {
            OPConnection.Open();
            ADODB.Recordset RatesRetriever = new ADODB.Recordset();
            RatesRetriever.ActiveConnection = OPConnection;
            RatesRetriever.Open(@"
SELECT [refkey]
      ,[chargeable]
      ,[user]
      ,[created]
  FROM [opreports].[dbo].[ref_chargeables]");
            System.Data.OleDb.OleDbDataAdapter tempAdapter = new System.Data.OleDb.OleDbDataAdapter();
            tempAdapter.Fill(Data.Chargeables, RatesRetriever);
            OPConnection.Close();
        }

        private void GetRates()
        {
            OPConnection.Open();
            ADODB.Recordset RatesRetriever = new ADODB.Recordset();
            RatesRetriever.ActiveConnection = OPConnection;
            RatesRetriever.Open(@"
SELECT [refkey]
      ,[chargeable]
      ,[rate]
      ,[user]
      ,[created]
  FROM [opreports].[dbo].[rates]");
            System.Data.OleDb.OleDbDataAdapter tempAdapter = new System.Data.OleDb.OleDbDataAdapter();
            tempAdapter.Fill(Data.Rates, RatesRetriever);
            OPConnection.Close();
        }

        internal void Save()
        {
            EnumerableRowCollection<RatesData.ChargeablesRow> ModifiedRows = Data.Chargeables.AsEnumerable().
                                                                            Where(row => row.Modified == true);
            foreach (RatesData.ChargeablesRow row in ModifiedRows)
            {
                InsertCommand(row);
                row.Modified = false; //Reset Modified Flag

            }
        }

        private void InsertCommand(RatesData.ChargeablesRow row)
        {
            DateTime savedDate = DateTime.Now;
            OPConnection.Open();
            OPConnection.BeginTrans();
            try
            {
                ADODB.Command RatesInserter = new ADODB.Command();
                RatesInserter.ActiveConnection = OPConnection;
                RatesInserter.CommandText = $@"
INSERT INTO [opreports].[dbo].[rates]
           ([refkey]
           ,[chargeable]
           ,[rate]
           ,[user]
           ,[created])
     VALUES
           ({row.Refkey}
           ,'{row.Chargeable}'
           ,{row.Rate}
           ,'{row.User}'
           ,'{savedDate}')
";
                object affected;
                RatesInserter.Execute(out affected);
                OPConnection.CommitTrans();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                OPConnection.RollbackTrans();
            }
            finally
            {
                OPConnection.Close();
            }
        }
    }
    
}
