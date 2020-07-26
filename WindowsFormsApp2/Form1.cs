﻿using System;
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
        Color[] colors = {
        Color.Red,
        Color.Firebrick,
        Color.AliceBlue,
        Color.Cyan,
        Color.DarkSalmon
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count - 1 >= 0)
                this.BackColor = colors[--count];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count + 1 < colors.Length )
                this.BackColor = colors[++count];
        }
    }
}
