using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTT
{
    public partial class frmHocSinh : Form
    {
        public frmHocSinh(string mhs)
        {
            this.mhs = mhs;
            InitializeComponent();
        }
        private string mhs;

        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(mhs))
            {
                this.Text = "Thêm mới học sinh";
            }
            else
            {
                this.Text = "Cập nhật thông tin học sinh";
                var r = new Database().Select("selectHS '"+mhs+"'");
                //MessageBox.Show(r[0].ToString());
                //set các giá trị vào 
                txtHoten.Text = r["HoTen"].ToString();
                mtbNgaysinh.Text = r["NgaySinh"].ToString();
                if(int.Parse(r["GioiTinh"].ToString()) == 1)
                {
                    rbtNam.Checked = true;
                }
                else
                {
                    rbtNu.Checked = true;
                }

                txtTencha.Text = r["TenCha"].ToString();
                txtTenme.Text = r["TenMe"].ToString();
                txtDiachi.Text = r["DiaChi"].ToString();
                txtSodt.Text = r["SoDT"].ToString();
                txtMalop.Text = r["MaLop"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            string HoTen = txtHoten.Text;
            DateTime NgaySinh;
            try
            {
                NgaySinh = DateTime.ParseExact(mtbNgaysinh.Text,"dd/MM/yyyy",CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                mtbNgaysinh.Select();
                return;
            }

            string GioiTinh = rbtNam.Checked ? "1" : "0";
            string TenCha = txtTencha.Text;
            string TenMe = txtTenme.Text;
            string DiaChi = txtDiachi.Text;
            string SoDT = txtSodt.Text;
            string MaLop = txtMalop.Text;


            List<CustomParameter> lstPara = new List<CustomParameter>();

            if(string.IsNullOrEmpty(mhs))//nếu thêm mới
            {
                sql = "ThemMoiHS";
                
            }
            else//nếu cập nhật
            {
                sql = "updateHS";
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaHS",
                    Value = mhs
                });
            }

            lstPara.Add(new CustomParameter()
            {
                key = "@HoTen",
                Value = HoTen
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@NgaySinh",
                Value = NgaySinh.ToString("yyyy-MM-dd")
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@GioiTinh",
                Value = GioiTinh
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@TenCha",
                Value = TenCha
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@TenMe",
                Value = TenMe
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@DiaChi",
                Value = DiaChi
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@SoDT",
                Value = SoDT
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@MaLop",
                Value = MaLop
            });

            var rs = new Database().ExeCute(sql, lstPara);
            if(rs == 1)
            {
                if(string.IsNullOrEmpty(mhs))//nếu thêm mới
                {
                    MessageBox.Show("Thêm mới học sinh thành công");
                }else
                {
                    MessageBox.Show("Cập nhật thông tin học sinh thành công");
                }
                this.Dispose();
            }else
            {
                MessageBox.Show("Thực thi thất bại");
            }
        }
    }
}
