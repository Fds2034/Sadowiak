﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sadowiak1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();

            Random rand = new Random();
            int x = rand.Next(0, 1140);
            int y = rand.Next(0, 800);
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(x, y);
        }
    }
}
