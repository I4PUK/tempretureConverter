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
    public partial class Task5 : Form
    {
        public Task5()
        {
            InitializeComponent();

        }

        void ConvertIntoAnotherMeasure(double enteredValue)
        {
            double celsius, kelvin, fahrenheit;
            {
                fahrenheit = enteredValue * 1.8 + 32;
                label1.Text = fahrenheit.ToString() + " Фаренгейт";
                label2.Text = (enteredValue + 273.15).ToString() + " Кельвин";
            }
            //Введено значаение в фаренгейт
            {
                celsius = (enteredValue - 32) / 1.8;
                label3.Text = celsius.ToString() + " Цельсий";
                label4.Text = (celsius + 273.15).ToString() + " Кельвин";
            }
            //Введено значаение в кельвинах
            {
                celsius = enteredValue - 273.15;
                label5.Text = celsius.ToString() + " Цельсий";
                label6.Text = (celsius * 1.8 + 32).ToString() + " Фаренгейт";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            double celsius, kelvin, fahrenheit, enteredValue;
            //Введено значаение в цельсиях
            bool isNum = double.TryParse(textBox1.Text, out enteredValue);
            if (isNum) ConvertIntoAnotherMeasure(enteredValue);
            else
            {
                try
                {
                    if (textBox1.Text[0] == '-') ConvertIntoAnotherMeasure(enteredValue);
                }
                catch
                {
                    textBox1.Text = "";
                }
            }
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }
    }
}
