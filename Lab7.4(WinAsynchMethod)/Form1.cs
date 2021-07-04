﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7._3_WinAsynchMethod_
{
    public partial class Form1 : Form
    {
        private delegate int AsyncSumm(int a, int b);
        delegate void PrintLabel(string str);
        private PrintLabel PrintDelegateFunc;
        public Form1()
        {
            InitializeComponent();
            PrintDelegateFunc = new PrintLabel(PrintFunc);
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работа кипит!");
        }

        private int Summ(int a, int b)
        {
            System.Threading.Thread.Sleep(9000);
            return a + b;
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
                MessageBox.Show("При выполнении преобразования типов возникла ошибка.");
                txbA.Text = txbB.Text = "";
                return;
            }
            AsyncSumm summdelegate = new AsyncSumm(Summ);
            AsyncCallback cb = new AsyncCallback(CallBackMethod);
            summdelegate.BeginInvoke(a, b, cb, summdelegate);
        }

        private void CallBackMethod(IAsyncResult ar)
        {
            AsyncSumm summdelegate = (AsyncSumm)ar.AsyncState;
            string str = String.Format("Сумма введенных чисел равна {0}", summdelegate.EndInvoke(ar));
            lblResult.Invoke(PrintDelegateFunc, new object[] { str });
            MessageBox.Show(str, "Результат операции.");
        }

        void PrintFunc(string str)
        {
            lblResult.Text = str;
        }

        private async void btnSubtract_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = Int32.Parse(txbA.Text);
                b = Int32.Parse(txbB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured while typecasting.");
                txbA.Text = txbB.Text = "";
                return;
            }
            int res = await Subb(a, b);
            lblResult.Text = res.ToString();
        }

        private async Task<int> Subb(int a, int b)
        {
            return await Task.Run(() => {
                Thread.Sleep(5000);
                return a - b;
            });
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}