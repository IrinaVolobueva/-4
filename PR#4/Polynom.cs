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

namespace PR_4
{
    public partial class Polynom : Form
    {
        public Polynom()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод Update() предназначен для скрытия элементов.
        /// </summary>
        void Update()
        {
            label2.Hide();
            label5.Hide();
            label3.Hide();
            label4.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            tbC1.Hide();
            tbC2.Hide();
            tbC3.Hide();
            tbC4.Hide();
            button3.Hide();
            tbC5.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutTheProgram form2 = new AboutTheProgram();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void вычислитьПолиномToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                switch (Convert.ToInt32(textBox6.Text))
                {
                    case 1:
                        Update();
                        tbC1.Show();
                        button3.Show();
                        break;
                    case 2:
                        Update();
                        tbC1.Show();
                        tbC2.Show();
                        label6.Show();
                        label9.Show();
                        button3.Show();
                        break;
                    case 3:
                        Update();
                        tbC1.Show();
                        tbC2.Show();
                        tbC3.Show();
                        label8.Show();
                        label6.Show();
                        label9.Show();
                        label4.Show();
                        button3.Show();
                        break;
                    case 4:
                        Update();
                        tbC1.Show();
                        tbC2.Show();
                        tbC3.Show();
                        tbC4.Show();
                        label3.Show();
                        label4.Show();
                        label6.Show();
                        label7.Show();
                        label8.Show();
                        label9.Show();
                        button3.Show();
                        break;
                    case 5:
                        Update();
                        tbC1.Show();
                        tbC2.Show();
                        tbC3.Show();
                        tbC4.Show();
                        tbC5.Show();
                        label2.Show();
                        label5.Show();
                        label3.Show();
                        label4.Show();
                        label6.Show();
                        label7.Show();
                        label8.Show();
                        label9.Show();
                        button3.Show();
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Проверьте правильность введенных данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox6.Clear();
            }
        }
    }
}
