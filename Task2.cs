using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HMI1
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double fahrenheit, celsius;
            try
            {
                fahrenheit = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный формат строки. Пожалуйста, вводите десятичные значение через запятую.");
            }
            finally
            {
                fahrenheit = Convert.ToDouble(textBox1.Text);
                celsius = (fahrenheit - 32) / 1.8;
                textBox2.Text = celsius.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }
    }
}
