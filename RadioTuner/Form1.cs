using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioTuner
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private int upDown;
        private int counter;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            Trace.WriteLine("btn_MouseDown");
        }

        private void btn_MouseUp(object sender, MouseEventArgs e)
        {
            Trace.WriteLine("btn_MouseUp");

        }

    }
}
