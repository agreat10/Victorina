using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private int i = 0;
        public  int count = 0;
        private string[,] QV = { {"Сколько спутников у Марса?","2","Неверно" },
                {"Сколько планет нашей Солнечной системы состоят из газа?","4","Неверно" },
                {"Сколько звезд составляют Большую Медведицу?","7","Неверно" },
                {"Каков размер Земли в километрах?","40075","Неверно"},
                {"Сколько земных лет длится год на Юпитере?","12", "Неверно"} };

        public Form1()
        {
            InitializeComponent();

            label2.Text = $"Вопрос {Convert.ToString(i + 1)} ";
            labelQwestion.Text =  QV[i,0];
            button1.Enabled = false;
            
        }

        private void textBoxAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
             
        }

        private void textBoxAnswer_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAnswer.Text != "")
                button1.Enabled = true;
            else button1.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string answ = Convert.ToString(textBoxAnswer.Text);
            if (answ == QV[i, 1])
            {
                count++;
                QV[i, 2] = "Верно";
            }
            i++;
            textBoxAnswer.Text = "";
            button1.Enabled = false;
            if (i == 5)
            {
                i--;
                this.Hide();
                Form2 form2 = new Form2($"Вопросы кончились.\nКоличество верных ответов - {count}!",QV);
                
                form2.Show();
                
                //MessageBox.Show($"Вопросы кончились.\nКоличество верных ответов - {count}!");
                //Application.Exit();
            }
            label2.Text = $"Вопрос {Convert.ToString(i + 1)} ";
            labelQwestion.Text = QV[i, 0];
        }
    }
}
