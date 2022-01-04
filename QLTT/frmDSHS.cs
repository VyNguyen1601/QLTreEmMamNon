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
    public partial class frmDSHS : Form
    {
        public frmDSHS()
        {
            InitializeComponent();
        }

        private void frmDSHS_Load(object sender, EventArgs e)
        {
            LoadDSHS();
        }

        private void LoadDSHS()
        {
            //load toàn bộ ds hs khi form được load
            dgvHocSinh.DataSource = new Database().SelectData("exec SelectAllHocSinh");

            // đặt tên cột
            dgvHocSinh.Columns["MaHS"].HeaderText = "Mã HS";
            dgvHocSinh.Columns["HoTen"].HeaderText = "Họ tên";
            dgvHocSinh.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvHocSinh.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvHocSinh.Columns["TenCha"].HeaderText = "Tên cha";
            dgvHocSinh.Columns["TenMe"].HeaderText = "Tên mẹ";
            dgvHocSinh.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvHocSinh.Columns["SoDT"].HeaderText = "Số ĐT";
            dgvHocSinh.Columns["MaLop"].HeaderText = "Mã Lớp";
        }

        private void dgvHocSinh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // khi double click vào học sinh thì sẽ hiện ra thông tin của sv đó để cập nhật
            if(e.RowIndex>=0)
            {
                var mhs = dgvHocSinh.Rows[e.RowIndex].Cells["MaHS"].Value.ToString();
                // càn truyền mhs vào form
                new frmHocSinh(mhs).ShowDialog();
                //cần load lại ds học sinh
                LoadDSHS();
            }
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new frmHocSinh(null).ShowDialog();// nếu thêm mới hs mã hs = null
            LoadDSHS();//load lại danh sách hs khi thêm thành công
        }
    }
}
