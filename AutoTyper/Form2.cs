using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace AutoTyper
{
    public partial class Form2 : Form
    {
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        bool enabled = false;
        Timer timerX = new Timer();
        char[] vs;
        int position;

        public Form2()
        {
            InitializeComponent();
            timerX.Interval = 1000;
            timerX.Tick += TimerX_Tick;
        }

        private void TimerX_Tick(object sender, EventArgs e)
        {
            if (enabled)
                timer3.Enabled = true;
            else if (!enabled)
                timer2.Enabled = true;
            timer1.Enabled = enabled;
            timerX.Enabled = false;
            if (!enabled)
                MessageBox.Show($"TyperStatus: {enabled.ToString().ToUpper()}\nTyping Completed!");
        }

        private void btn_Simple_Click(object sender, EventArgs e)
        {
            FormChanger.SwitchMainForm(new Form1());
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            short keyState = GetAsyncKeyState(0x04);
            bool prntScrnIsPressed = ((keyState >> 10) & 0x0020) == 0x0020;

            if (prntScrnIsPressed && !enabled && txt_Text.Text.Trim().Length != 0)
            {
                enabled = true;
                timer2.Enabled = false;
                timerX.Enabled = true;
            }
        }


        private void timer3_Tick(object sender, EventArgs e)
        {
            short keyState = GetAsyncKeyState(0x04);
            bool prntScrnIsPressed = ((keyState >> 10) & 0x0020) == 0x0020;

            if (prntScrnIsPressed && enabled && txt_Text.Text.Trim().Length != 0)
            {
                enabled = false;
                timer3.Enabled = false;
                timerX.Enabled = true;
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (position != vs.Length)
            {
                position++;
            z:
                try
                {
                    if (vs[position-1] != vs.Length  || vs[position-1] != ' ')
                    {
                        int x = (int)Min_C.Value;
                        int y = (int)Max_C.Value;
                        timer1.Interval = new Random().Next(x - new Random().Next(-(x / 2), x / 2), y +  new Random().Next(-(x / 2), x / 2));
                        SendKeys.SendWait(vs[position - 1].ToString());
                    }
                    else
                    {
                        int x = (int)Min_W.Value;
                        int y = (int)Max_W.Value;
                        timer1.Interval = new Random().Next(x - new Random().Next(-(x / 2), x / 3), y + new Random().Next(-(x / 3), x / 2));
                        SendKeys.SendWait(vs[position - 1].ToString());
                    }
                }
                catch (Exception)
                {
                    goto z;
                }
            }
            else
            {
                enabled = false;
                position = 0;
                timer3.Enabled = false;
                timerX.Enabled = true;
                timer1.Enabled = false;
            }
        }

        private void txt_Text_TextChanged(object sender, EventArgs e)
        {
            vs = txt_Text.Text.ToArray();
            position = 0;
        }
    }
    }

