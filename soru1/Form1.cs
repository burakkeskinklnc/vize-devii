using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hak = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int sayi2 = r.Next(1,100);
            int sayi;
            sayi = Convert.ToInt32(textBox1.Text);
            if (hak < 11)
            {
                if(sayi<sayi2)
                {
                    label1.Visible = true;
                    label2.Visible = false;
                    listBox1.Items.Add(sayi);
                    hak++;
                    textBox1.Text = "";
                }
                if(sayi>sayi2)
                {
                    label2.Visible = true;
                    label1.Visible = false;
                    listBox1.Items.Add(sayi);
                    hak++;
                    textBox1.Text = "";
                }
                else if (sayi == sayi2)
                {
                    MessageBox.Show("Tebrikler tahmininiz doğru, programdan çıkılıyor.");
                    Application.Exit();

                }
            }
           
        }
    }
}
