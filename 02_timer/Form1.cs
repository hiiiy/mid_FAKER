using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            timer1= new Timer();
            timer1.Interval = 1000;
            timer1.Tick += timer_Tick;
            timer1.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
