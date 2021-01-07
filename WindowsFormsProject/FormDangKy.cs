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
    public partial class FormDangKy : Form
    {
        public FormDangKy(string number)
        {
            InitializeComponent();
            sdt.Text = number;
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            KhachHang s = new KhachHang() { TenKH = tenkh.Text, SDT = sdt.Text };
            try
            {
                context.KhachHangs.Add(s);
                context.SaveChanges();
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra!");
            }
        }
    }
}
