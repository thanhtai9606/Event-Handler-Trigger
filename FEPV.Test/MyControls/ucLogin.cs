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
        public event EventHandler eventHandler;
        public ucLogin()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click;
        }

        public void BtnLogin_Click(object sender, EventArgs e)
        {
            if (Username == USER_NAME && Password == PASSWORD)
                isLogin = true;
            eventHandler(this, new MyEvent { Username = Username, isLogin = isLogin });        
        }
        /// <summary>
        /// Just set Username for another control can be get
        /// data from this control
        /// </summary>
        public string Username 
        {
            set { txtUsername.Text = value; }
            get { return txtUsername.Text; }
        }
        /// <summary>
        /// Just set Password for another control can be get
        /// data from this control
        /// </summary>
        public string Password
        {
            set { txtPassword.Text = value; }
            get
            { return txtPassword.Text; }
        }
    }
}
