using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int adet, sayac;
        private void button1_Click(object sender, EventArgs e)
        {
            sayac++;
            listBox1.Items.Add(textBox1.Text);
            label1.Text = sayac.ToString();
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adet++;
            listBox2.Items.Add(textBox2.Text);
            label2.Text = adet.ToString();
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int i;
            for (i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
            {

                listBox2.Items.Add(listBox1.SelectedItems[i]);
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int j;
            for (j = listBox2.SelectedIndices.Count - 1; j >= 0; j--)
            {

                listBox1.Items.Add(listBox2.SelectedItems[j]);
                listBox2.Items.RemoveAt(listBox2.SelectedIndices[j]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox2.SelectionMode = SelectionMode.MultiSimple;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            adet = listBox1.Items.Count;
            MessageBox.Show("Kayıt Sayısı:" + adet.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var siralanmis = listBox1.Items.OfType<string>().OrderBy(s => s).ToList();
            listBox1.Items.Clear();
            foreach (var item in siralanmis)
            {
                listBox1.Items.Add(item);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            var siralanmis = listBox2.Items.OfType<string>().OrderBy(s => s).ToList();
            listBox2.Items.Clear();
            foreach (var item in siralanmis)
            {
                listBox2.Items.Add(item);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
