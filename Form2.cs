using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static WindowsFormsApp3.Form1;
namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        public Form2(string data, string[,] qv)
        {
            InitializeComponent();
            string Res = "";
            for (int i = 0; i < 5; i++)
            {
                Res += $"Вопрос {i+1}: {qv[i,0]} Правильный ответ: {qv[i,1]} Вы ответили: {qv[i,2]} \n\n";
            }
            label1.Text = data;
            label2.Text = Res;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
