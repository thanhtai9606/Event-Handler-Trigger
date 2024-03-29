﻿using FEPV.Test.MyControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEPV.Test
{
    public partial class MainForm : Form
    {
        ucLogin login = new ucLogin();
        ucMain main = new ucMain();
        public MainForm()
        {
            InitializeComponent();
            WorkSpace.Show(login);
            login.eventHandler += Login_eventHandler;
            main.LogOut += Main_LogOut;
        }

        private void Main_LogOut(object sender, EventArgs e)
        {
            var args = (MyEvent)e;
            if (!args.isLogin)
                WorkSpace.Show(login);
        }

        private void Login_eventHandler(object sender, EventArgs e)
        {
            var args = (MyEvent)e;
            if (args.isLogin)
            {
                main.Username = login.Username;
                WorkSpace.Show(main);
            }
            else
                MessageBox.Show("Wrong Username or Password!");
        }

    }
}
