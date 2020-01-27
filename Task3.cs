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
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged1(object sender, EventArgs e)
        {
            if (textBox1.Modified)
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
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Modified)
            {
                double celsius, fahrenheit;
                try
                {
                    celsius = Convert.ToDouble(textBox2.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Неверный формат строки. Пожалуйста, вводите десятичные значение через запятую.");
                }
                finally
                {
                    celsius = Convert.ToDouble(textBox2.Text);
                    fahrenheit = celsius * 1.8 + 32;
                    textBox1.Text = fahrenheit.ToString();
                }
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
