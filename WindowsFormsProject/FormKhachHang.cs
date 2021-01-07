using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsProject.Data;

namespace WindowsFormsProject
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void FormDKKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                Model1 context = new Model1();
                List<KhachHang> listKhachHang = context.KhachHangs.ToList();
                List<ChiTietPhieuMua> listPhieuMua = context.ChiTietPhieuMuas.ToList();
                List<MatHang> listMatHang = context.MatHangs.ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void check_Click(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            List<KhachHang> listKhachHang = context.KhachHangs.ToList();
            int check = 0;
            foreach (var item in listKhachHang)
            {
                if (item.SDT == phone.Text)
                {
                    dataGridView1.Rows[0].Cells[0].Value = item.MaKH;
                    dataGridView1.Rows[0].Cells[1].Value = item.TenKH;
                    dataGridView1.Rows[0].Cells[2].Value = item.SDT;
                    check = 1;
                    break;
                }
            }
            if (check == 0)
            {
                DialogResult dr = MessageBox.Show("Không tồn tại. Bạn có muốn đăng ký số điện thoại này?", "YES/NO", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    FormDangKy formdk = new FormDangKy(phone.Text);
                    formdk.Show(this);
                }
            }
        }

        private void FormKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form = new Form1();
            form.Visible = true;
        }
    }
}
