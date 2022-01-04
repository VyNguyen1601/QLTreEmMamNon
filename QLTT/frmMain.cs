using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTT
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var fn = new frmDangNhap();
            fn.ShowDialog();

            var tk = fn.tendangnhap;
            MessageBox.Show("Tài khoản đã đăng nhập là: " + tk);

 

        }
    }
}
