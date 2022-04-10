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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            if(progressBar1.Value>10 && progressBar1.Value < 30)
            {
                label1.Text = "Вспоминаем дебюты";

            }
            else if (progressBar1.Value > 30 && progressBar1.Value < 60)
            {
                label1.Text = "Морально подготавливаемся";
            }
            else if (progressBar1.Value > 60 && progressBar1.Value < 99)
            {
                label1.Text = "Расставляем фигуры";
            }
            else if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                Form4 f4 = new Form4();
                f4.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
