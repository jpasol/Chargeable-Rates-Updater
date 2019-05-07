using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chargeable_Rates_Updater
{
    public partial class Form_RatesUpdater : Form
    {
        public Form_RatesUpdater()
        {
            InitializeComponent();
            viewRates.KeyDown += new KeyEventHandler(Save); //Add Saving Function to ctrl+s
            lblLogout.Click += new EventHandler(Logout); //Add Logout Function
        }

        private Form_Login FormLogin;
        private ChargeableRatesUpdater Updater;

        private void Form_RatesUpdater_Load(object sender, EventArgs e)
        {
            viewRates.AutoGenerateColumns = false;
            viewHistory.AutoGenerateColumns = false;
            ShowLogin();
        }

        private void ShowLogin()
        {
            FormLogin = new Form_Login();
            this.Controls.Add(FormLogin);

            FormLogin.BringToFront();
            AddParentHandlersToLoginForm();

            FormLogin.Show();
        }

        private void AddParentHandlersToLoginForm()
        {
            Button CancelButton = (Button)FormLogin.Controls.Find("buttonCancel", true)[0];
            Button LoginButton = (Button)FormLogin.Controls.Find("buttonLogin", true)[0];   

            CancelButton.Click += new EventHandler(CloseWhenCancelled); //Add Exit Main for when Login Cancel Button is clicked
            FormLogin.FormClosed += new FormClosedEventHandler(ResetAcceptCancelButton); //Reset Accept and Cancel Button          
            FormLogin.VisibleChanged += new EventHandler(RetrieveData); //Get Connection on Hide

            //Assign Login and Cancel Buttons to Parent's AcceptButton and CancelButton
            this.AcceptButton = LoginButton;
            this.CancelButton = CancelButton;
        }

        private void RetrieveData(object sender, EventArgs e)
        {
            if (FormLogin.Login.Connected)
            {
                
                Updater = new ChargeableRatesUpdater();
                Updater.OPConnection = FormLogin.Login.OPConnection;
                Updater.GetData();

                DataTable tempTable = new DataTable();
                tempTable = Updater.Data.Chargeables.Copy();
                viewRates.DataSource = tempTable;
                viewHistory.DataSource = Updater.Data.Rates;
                viewHistory.Sort(viewHistory.Columns[3], ListSortDirection.Descending); //Autosort 4th Column
            }
        }

        private void ResetAcceptCancelButton(object sender, EventArgs e)
        {
            this.AcceptButton = null;
            this.CancelButton = null;
        }

        private void CloseWhenCancelled(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Save(object sender, KeyEventArgs e)
        {
            if(e.Modifiers==Keys.Control && e.KeyCode==Keys.S)
            {
                if(MessageBox.Show(text:"Do you want to Save?",
                                    caption:"Save",
                                    buttons:MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    UpdateSourceTable();
                    Updater.Save();
                }
                RetrieveData(this,new EventArgs()); //Refresher

            }
        }

        private void UpdateSourceTable()
        {
            RatesData.ChargeablesDataTable tempDatatable = (RatesData.ChargeablesDataTable)viewRates.DataSource;
            RatesData.ChargeablesDataTable SourceDatatable = Updater.Data.Chargeables;
            foreach(RatesData.ChargeablesRow tempRow in tempDatatable.Rows)
            {
                RatesData.ChargeablesRow SourceRow = SourceDatatable.AsEnumerable().
                                                    Where(sRow => sRow.Refkey == tempRow.Refkey).
                                                    FirstOrDefault();

                if (tempRow.Rate != SourceRow.Rate)
                {
                    SourceRow.Rate = tempRow.Rate;
                    SourceRow.User = FormLogin.Login.Username;
                    SourceRow.Created = DateTime.Now;
                    SourceRow.Modified = true;
                }
            }
        }

        private void Logout(object sender, EventArgs e)
        {
            if (MessageBox.Show(text: "Are you sure you want to Logout?", 
                                caption: "Logout", 
                                buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Updater = null;
                ShowLogin();
            }
        }
    }
}
