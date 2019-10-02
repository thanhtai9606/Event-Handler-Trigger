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
    public partial class ucMain : UserControl
    {
        public ucMain()
        {
            InitializeComponent();
            btnLogOut.Click += BtnLogOut_Click;

        }
        public event EventHandler LogOut;
        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            LogOut(this, new MyEvent { isLogin = false });
        }

        /// <summary>
        /// Set Value for Username Control
        /// to get from another UserControl
        /// </summary>
        public string Username
        {
            set
            {
                lbUsername.Text = value;
            }
            get
            {
                return lbUsername.Text;
            }
        }
    }
}
