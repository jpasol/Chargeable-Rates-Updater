using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Reflection;
using System.Windows.Forms;
using Tools;

namespace Chargeable_Rates_Updater
{
    public class UserLogin
    {
        public void PerformLogin()
        {
            GetConfigurations();

            try
            {

                using (new Impersonator(Username, "sbitc", Password))
                {
                    OPConnection = new ADODB.Connection();
                    OPConnection.ConnectionString = $@"Provider=SQLOLEDB;
                                            Data Source={OPServer};
                                            Initial Catalog={OPDatabase};
                                            Integrated Security=SSPI;";
                    OPConnection.Open();
                    Connected = true;
                    MessageBox.Show("Login Successful!");

                    OPConnection.Close();
                }
            }
            catch (Exception ex)
            {
                Connected = false;
                if (ex.Message.Contains("Login failed for user"))
                {
                    MessageBox.Show("Login Failed...");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }



        private void GetConfigurations()
        {
            Configuration Config = ConfigurationManager.OpenExeConfiguration(Assembly.GetAssembly(this.GetType()).Location);
            ClientSettingsSection userSettings = new ClientSettingsSection();
            userSettings = (ClientSettingsSection)Config.SectionGroups["userSettings"].Sections["Chargeable_Rates_Updater.Properties.Settings"];

            OPServer = userSettings.Settings.Get("OPServer").Value.ValueXml.InnerText;
            OPDatabase = userSettings.Settings.Get("OPDatabase").Value.ValueXml.InnerText;

        }

        public Boolean Connected;
        public ADODB.Connection OPConnection;
        public string Username;
        public string Password;

        private string OPServer;
        private string OPDatabase;

    }
}
