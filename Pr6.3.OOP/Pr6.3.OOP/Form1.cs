﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr6._3.OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private delegate int AsyncSumm(int a, int b);

        private int Summ(int a,int b)
        {
            System.Threading.Thread.Sleep(9000);
            return a + b;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = Int32.Parse(txbA.Text);
                b = Int32.Parse(txbB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("При виконанні перетворення типів виникла помилка");
                txbA.Text = txbB.Text = "";
                return;
            }
            AsyncSumm summdelegate = new AsyncSumm(Summ);
            AsyncCallback cb = new AsyncCallback(CallBackMethod);
            summdelegate.BeginInvoke(a, b, cb, summdelegate);
        }
        private void CallBackMethod(IAsyncResult ar)
        {
            string str;
            AsyncSumm summdelegate = (AsyncSumm)ar.AsyncState;
            str = String.Format("Сума введених чисел рівна {0}", summdelegate.EndInvoke(ar));
            MessageBox.Show(str, "Результат операції");
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Робота кипить!!!");
        }
    }
}
