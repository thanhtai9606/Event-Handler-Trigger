using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEPV.Test.MyControls
{
    public partial class ucLogin : UserControl
    {
        const string USER_NAME = "admin";
        const string PASSWORD = "admin";
        public bool isLogin = false;
        public delegate void checkLogin(bool value);
        public checkLogin isValidate;
        public ucLogin()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click;
        }

        public void BtnLogin_Click(object sender, EventArgs e)
        {
            if (Username == USER_NAME && Password == PASSWORD)
                isLogin = true;
            isValidate(isLogin);
        }
        /// <summary>
        /// Just set Username for another control can be get
        /// data from this control
        /// </summary>
        public string Username 
        { 
            set =>txtUsername.Text = value;
            get => txtUsername.Text; 
        }
        /// <summary>
        /// Just set Password for another control can be get
        /// data from this control
        /// </summary>
        public string Password
        {
            set => txtPassword.Text = value;
            get => txtUsername.Text;
        }
    }
}
