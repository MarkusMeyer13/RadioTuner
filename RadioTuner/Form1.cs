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
        private System.Timers.Timer timer = new System.Timers.Timer();
        private int upDown;
        private int counter;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            Trace.WriteLine("btn_MouseDown Start - " + this.upDown.ToString());
            if (sender == this.btnLeft)
            {
                this.upDown = -1;
            }
            else if (sender == this.btnRight)
            {
                this.upDown = 1;
            }
            this.timer.Interval = 100;
            this.timer.Elapsed += Timer_Elapsed;
            this.timer.Enabled = true;
            Trace.WriteLine("btn_MouseDown End - " + this.upDown.ToString());
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Trace.WriteLine("elapsed - " + counter.ToString());
            this.counter += 1;

            if (this.counter >= 10 && this.counter < 25)
            {
                this.Invoke((Func<int, bool>)MovePointer, this.upDown);
            }
            else if (this.counter >= 25 && this.counter < 50)
            {
                this.Invoke((Func<int, bool>)MovePointer, this.upDown);
                this.Invoke((Func<int, bool>)MovePointer, this.upDown);
                this.Invoke((Func<int, bool>)MovePointer, this.upDown);
                this.Invoke((Func<int, bool>)MovePointer, this.upDown);

            }
            else if (this.counter >= 50)
            {
                this.Invoke((Func<int, bool>)MovePointer, this.upDown);
                this.Invoke((Func<int, bool>)MovePointer, this.upDown);
                this.Invoke((Func<int, bool>)MovePointer, this.upDown);
                this.Invoke((Func<int, bool>)MovePointer, this.upDown);
                this.Invoke((Func<int, bool>)MovePointer, this.upDown);
                this.Invoke((Func<int, bool>)MovePointer, this.upDown);
                this.Invoke((Func<int, bool>)MovePointer, this.upDown);
                this.Invoke((Func<int, bool>)MovePointer, this.upDown);

            }
        }

        private bool MovePointer(int count)
        {
            Trace.WriteLine("MovePointer");

            if ((this.pbPointer.Location.X > this.pbScala.Location.X) && (this.pbPointer.Location.X < this.pbScala.Location.X + this.pbScala.Size.Width))
            {
                this.pbPointer.Location = new Point(this.pbPointer.Location.X + count, this.pbPointer.Location.Y);
            }
            return true;
        }


        private void btn_MouseUp(object sender, MouseEventArgs e)
        {
            Trace.WriteLine("btn_MouseUp");
            if (this.timer != null)
            {
                this.timer.Stop();
                this.timer.Enabled = false;
                Trace.WriteLine("btn_MouseUpc - Timer stopped");
            }

        }

    }
}
