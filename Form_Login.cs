using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Reflection;

namespace Chargeable_Rates_Updater
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
            this.TopLevel = false;
            Login = new UserLogin();

            buttonLogin.Click += new EventHandler(PerformLogin);
        }

        public UserLogin Login;
        private void PerformLogin(object obj, EventArgs e)
        {
            Login.Username = textUsername.Text;
            Login.Password = textPassword.Text;
            Login.PerformLogin();

            if (Login.Connected)
            {
                this.Hide();
            }
        }




    }
}
