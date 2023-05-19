using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace şans_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int puan = 30;
        int sayac = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            lblSonuc.Text = "puanınız:" + puan.ToString();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            label1.Text = rnd.Next(1, 11).ToString();
            label2.Text = rnd.Next(1, 11).ToString();
            label3.Text = rnd.Next(1, 11).ToString();

            if (label1.Text == "7" && label2.Text == "7" && label3 .Text == "7")
            {
                puan += 100;
            }
            else if (label1.Text == "7" && label2.Text == "7")
            {
                puan += 10;
            }
            else if (label2.Text == "7" && label3.Text == "7")
            {
                puan += 50;
            }
            else if (label3.Text == "7")
            {
                puan += 5;
            }
            else 
            {
                puan -= 3;
            }
            lblSonuc.Text = "puanınız:" + puan.ToString();
            if (puan<=0)
            {
                if(MessageBox.Show("oyun bitti tekrar oynamak ister misiniz",this.Text,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)
                 ==DialogResult.Yes)
                {
                    puan = 30;
                    label1.Text = "0";
                    label2.Text = "0";
                    label3.Text = "0";
                    lblSonuc.Text = "puanınız:" + puan.
                        ToString();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
