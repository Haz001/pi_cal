using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace PiCal
{
    public partial class Form1 : Form
    {
        public Random _ran;
        public Form1()
        {
            InitializeComponent();
            _ran = new Random();
             pi_t= new Thread(new ThreadStart(pi_calto));
        }
        public int radious = 10000;
        public decimal pi_f = 0;
        public Thread pi_t;
        public bool notstart = true;
        public bool paused = false;
        private void startworker_Click(object sender, EventArgs e)
        {
            if (notstart)
            {
                notstart = false;
                pi_t.Start();
            }else
            if (paused)
            {
                pi_t.Resume();
                paused = false;

            }
            else
            {
                pi_t.Suspend();
                paused = true;
            }
            
            //pi_calto();
        }
        public ulong count = 0;
        public ulong ccount = 0;
        public void pi_calto()
        {
            while (true)
            {
                for (int i = 0; i < 500000; i++)
                {
                    decimal x = _ran.Next(-radious, radious);
                    decimal y = _ran.Next(-radious, radious);
                    count += 1;
                    //MessageBox.Show(count.ToString());
                    decimal mag = (x * x + y * y);
                    if (mag < radious * radious)
                    {
                        ccount += 1;
                    }
                }
                //MessageBox.Show(count.ToString()+" / "+ccount.ToString());
                pi_f = 4 * ((decimal)ccount / (decimal)count);
                
                //pi_box.Text = pi_f.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pi_f != 0)
            {
                //MessageBox.Show(pi_f.ToString());
                pi_box.Text = pi_f.ToString();
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            pi_t.Abort();
        }
    }
}
