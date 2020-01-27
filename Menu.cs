﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HMI1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task1 task1 = new Task1();
            task1.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task2 task2 = new Task2();
            task2.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task3 task3 = new Task3();
            task3.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Task4 task4 = new Task4();
            task4.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Task5 task5 = new Task5();
            task5.Show();
            Hide();
        }
    }
}
