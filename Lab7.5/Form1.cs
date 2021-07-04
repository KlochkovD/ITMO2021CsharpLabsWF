using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7._5
{
    public partial class Form1 : Form
    {

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле должно содержать цифры");
            }
        }

        public Form1()
        {
            InitializeComponent();
            PrintDlegateFunc = new PrintRichTextBox(PrintFunc);
        }


        private void Button_Start_Click(object sender, EventArgs e)
        {
            int Value = 0;
            if (int.TryParse(TextBox_Input.Text, out Value))
            {
                AsyncSumm summdelegate = new AsyncSumm(Summ);
                AsyncCallback cb = new AsyncCallback(CallBackMethod);
                summdelegate.BeginInvoke(Value, cb, summdelegate);
            }
        }



        /*Вызов через асинхронный метод через делегат*/
        private delegate int AsyncSumm(int a);
        delegate void PrintRichTextBox(string str);
        private PrintRichTextBox PrintDlegateFunc;
        void PrintFunc(string str)
        {
            RichTextBox_OutPut.Text += str;
        }
        private void CallBackMethod(IAsyncResult ar)
        {
            RichTextBox_OutPut.Invoke(PrintDlegateFunc, new object[] { ";\n" });
        }

        private int Summ(int Value)
        {

            RichTextBox_OutPut.Invoke(PrintDlegateFunc, new object[] { "Расчет для числа (" + Value + "): " });
            for (int trial = 2; trial <= Value; trial++)
            {
                System.Threading.Thread.Sleep(1000);
                bool isPrime = true;
                for (int divisor = 2; divisor <= Math.Sqrt(trial); divisor++)
                {
                    if (trial % divisor == 0)
                    {
                        isPrime = false; break;
                    }
                }
                if (isPrime)
                {
                    RichTextBox_OutPut.Invoke(PrintDlegateFunc, new object[] { " " + trial });
                }
            }
            return Value;
        }

    }
}