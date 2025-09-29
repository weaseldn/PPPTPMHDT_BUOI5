using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApDung1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Hàm tìm USCLN (Euclid)
        private int USCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Hàm tìm BSCNN
        private int BSCNN(int a, int b)
        {
            return (a * b) / USCLN(a, b);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txtA.Text.Trim());
                int b = Convert.ToInt32(txtB.Text.Trim());

                if (radUSCLN.Checked)
                {
                    txtKetQua.Text = "USCLN = " + USCLN(a, b).ToString();
                }
                else if (radBSCNN.Checked)
                {
                    txtKetQua.Text = "BSCNN = " + BSCNN(a, b).ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn USCLN hoặc BSCNN!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập dữ liệu: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?",
                                          "Xác nhận thoát",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
