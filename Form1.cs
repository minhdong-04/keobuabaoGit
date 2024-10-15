using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Các lựa chọn búa,kéo và bao
            string[] luachon = { "búa", "bao", "kéo" };
            Random random = new Random();//tạo random

            //thiết lập cho vòng lặp
            bool flag = true;
            do
            {
                //chọn ngẫu nhiên cho máy
                string botchon = luachon[random.Next(luachon.Length)];

                // Tạo biến flagchon và cho nó gán giá trị là dấu cách để lưu trữ option của người chọn.
                string flagchon = " "; 

                // Kiểm tra lựa chọn của người chơi
                if (bua.Checked)
                {
                    flagchon = "búa";
                }
                else if (bao.Checked)
                {
                    flagchon = "bao";
                }
                else if (keo.Checked)
                {
                    flagchon = "kéo";
                }

                if (flagchon!= "búa" && flagchon != "bao" && flagchon!= "kéo")
                {
                    MessageBox.Show("Lựa chọn không hợp lệ. Vui lòng nhập 'búa', 'bao' hoặc 'kéo'.");
                    return;// Thoát khi lựa chọn không hợp lệ
                }

                //Hiển thị kết quả
                MessageBox.Show($"Bạn chọn: {flagchon}");
                MessageBox.Show($"Máy chọn: {botchon}");

                //Dùng để xác định kết quả của trò chơi 
                if (flagchon == botchon)
                {
                    MessageBox.Show("Hòa nhau!");
                }
                else if ((flagchon == "bao" && botchon == "búa") || (flagchon == "kéo" && botchon == "bao") || (flagchon == "búa" && botchon == "kéo"))
                {
                    MessageBox.Show("Bạn Thắng");
                }
                else MessageBox.Show("Bạn Thua.");

                //Dùng để hỏi người chơi có muốn chơi tiếp hay không
                var rs= MessageBox.Show("Bạn có muốn chơi lại ? " ,"Chơi lại", MessageBoxButtons.YesNo);

                if (rs== DialogResult.No)
                {
                    flag = true; //Thoát vòng lặp
                }
            } while (!flag);
        }

        private void output_Click(object sender, EventArgs e)
        {
                // Đóng ứng dụng
                Application.Exit();
        }
    }
}
