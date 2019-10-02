using FEPV.Test.MyControls;
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
            Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WorkSpace.Show(login);
            login.isValidate = new ucLogin.checkLogin(isLogin);

        }
        public void isLogin(bool value)
        {
            if (value)
            {
                main.Username = login.Username;
                WorkSpace.Show(main);
            }
            else
                MessageBox.Show("Wrong Username or Password!");
        }
    }
}
