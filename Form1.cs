using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        int[] a;
        int n;
        public Form1()
        {
            InitializeComponent();
        }
        void create_mas()
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(0, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if ((a[i] + a[i + 1]) % 2 == 0)
                {
                    k++;
                    textBox2.Text = (i + 1).ToString();
                    break;
                }
                if (k == 0) textBox2.Text = "0";


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out n))
            {
                a = new int[n];
                create_mas();
                dataGridView1.Width = n * 60;
                label1.Text = "";
                for (int i = 0; i < n; i++)
                {
                    dataGridView1.Columns.Add("a" + i, "a[" + i + "]");
                    dataGridView1.Columns[i].Width = 60;
                    dataGridView1.Columns[i].DefaultCellStyle.Font =
                        new Font("Times New Roman", 16, FontStyle.Bold);
                    dataGridView1[i, 0].Value = a[i];
                }
                dataGridView1.Rows[0].Height = 60;
            }
            else
                MessageBox.Show("Задайте размер массива");
        }


       

        private void Form1_Load(object sender, EventArgs e)
        {
           
            button1.Text = " Проверка на чередование";
            button2.Text = " Создать массив";
            label1.Text = "Укажите длину массива:";
            label2.Text = "Результат:";

        }

        
    }
}
