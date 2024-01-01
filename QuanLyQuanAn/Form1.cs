using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace FormCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float data1, data2;
        string phepTinh;
        string congThuc;
        string[] operation = { "+", "-", "*", "/" };
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Kiểm tra trong chuối có kí tự trong mảng không
        /// </summary>
        static bool CheckInString(string s, string[] A)     
        {
            foreach(string item in A)
            {
                if (s.Contains(item))
                {
                    return true;
                }
            }
            return false;
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            //double _giaTri = double.Parse(txt.Text);
            //txt.Text = string.Format("{0:N0}", _giaTri);
        }
        
        /// <summary>
        /// Nhập số
        /// </summary>
        private void btnSo_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + ((Button)sender).Text;
            congThuc += ((Button)sender).Text;
        }

        private void btn_amduong_Click(object sender, EventArgs e)
        {
            txt.Text = (double.Parse(txt.Text) * (-1)).ToString();
        }
        private void btn_nghichdao_Click(object sender, EventArgs e)
        {
            double _giaTri =double.Parse(txt.Text);
            _giaTri = 1 / _giaTri;
            txt.Text = _giaTri.ToString();
        }

        private void btn_can_Click(object sender, EventArgs e)
        {
            double _giaTri = double.Parse(txt.Text);
            _giaTri = Math.Sqrt(_giaTri);
            txt.Text = _giaTri.ToString();
        }

        private void btn_binhphuong_Click(object sender, EventArgs e)
        {
            double _giaTri =double.Parse(txt.Text);
            _giaTri = Math.Pow(_giaTri, 2);
            txt.Text =_giaTri.ToString();
        }

        private void btn_tinh_Click (object sender, EventArgs e)
        {
            if (CheckInString(congThuc, operation))
            {
                btn_bang_Click(sender, e);
                phepTinh = ((Button)sender).Text;
                data1 = float.Parse(txt.Text);
                congThuc = data1 + ((Button)sender).Text;
                txtCongThuc.Text = congThuc;
                txt.Clear();
            }
            else
            {
                phepTinh = ((Button)sender).Text;
                txtCongThuc.Text = congThuc.ToString();
                data1 = float.Parse(txt.Text);
                congThuc = data1 + ((Button)sender).Text;
                txtCongThuc.Text = congThuc;
                txt.Clear();
            }
        }


        private void btn_bang_Click(object sender, EventArgs e)
        {
            if(phepTinh == "+")
            {
                data2 = data1 + float.Parse(txt.Text);
                txt.Text = data2.ToString();
            }
            else if(phepTinh == "-")
            {
                data2 = data1 - float.Parse(txt.Text);
                txt.Text = data2.ToString();
            }
            else if(phepTinh == "*")
            {
                data2 = data1 * float.Parse(txt.Text);
                txt.Text = data2.ToString();
            }
            else if(phepTinh == "/")
            {
                if (txt.Text != "0")
                {
                    data2 = data1 / float.Parse(txt.Text);
                    txt.Text = data2.ToString();
                }
                else
                {
                    txt.Text = "Không chia được";
                }
            }
            congThuc = "";
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int n = txt.Text.Length;
            txt.Text = (txt.Text.Remove(n-1)).ToString();
        }

        private void btn_phantram_Click(object sender, EventArgs e)
        {
            txt.Text = (float.Parse(txt.Text) / 100).ToString();
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            txt.Clear();
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            txt.Clear();
            congThuc = "";
            txtCongThuc.Clear();
        }

    }
}
