using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMS_8
{
    public partial class Form1 : Form
    {
        Generator gen = new Generator();

        public Form1()
        {
            InitializeComponent();
            label3.Text = "";
            label5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float p = trackBar1.Value / 1000;
            if (textBox1.TextLength > 1)
            {
                if (gen.singleEventAnswer(p))
                    label3.Text = "Да!";
                else
                    label3.Text = "Нет!";
            }
            else
                label3.Text = "Задай вопрос!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.TextLength > 1)
            {
                label5.Text = gen.groupOfEventAnswer(); ;
            }
            else
                label5.Text = "Задай вопрос!";
        }
    }
}
