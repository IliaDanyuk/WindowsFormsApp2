using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        static int count = 0;
        Timer timer;
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Start();


            button1.Tag = "run_timer";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.BackColor = (++count % 2 == 0) ? Color.Red : Color.Blue;
            this.Text = count.ToString();
            System.Threading.Thread.Sleep(500);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (button1.Tag.Equals("stop_timer"))
            {
                timer.Start();
                button1.Tag  = "run_timer";
                button1.Text  = "stop_timer";
            }
            else if (button1.Tag.Equals("run_timer"))
            {
                timer.Stop();
                button1.Tag = "stop_timer";
                button1.Text = "run_timer";
            }
        }
    }
}
