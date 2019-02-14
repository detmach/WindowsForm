using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinForm.Program;

namespace WinForm
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private async void btn1_Click(object sender, EventArgs e)
        {
            Thread tLonger = new Thread(() => CountLonger(50));
            tLonger.Start();

            Thread tShorter = new Thread(() => CountShorter(10, 20));
            tShorter.Start();
        }

        public void CountLonger(int val)
        {
            for (int i = 0; i < val; i++)
            {
                Thread.Sleep(50);
            }
            MessageBox.Show(val + "'e kadar saydım");
        }

        public void CountShorter(int val, int wait)
        {
            for (int i = 0; i < val; i++)
            {
                Thread.Sleep(wait);
            }
            MessageBox.Show(val + "'a kadar saydım");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == NativeMethods.BUNUYAP)
            {
                MessageBox.Show("Bunu Yap");
            }
            else if (m.Msg == NativeMethods.YADABUNU)
            {
                MessageBox.Show("Yada Bunu Yap");
            }
            else if (m.Msg == NativeMethods.BUTONABAS)
            {
                btn1.PerformClick();
            }
            base.WndProc(ref m);
        }
    }
}
