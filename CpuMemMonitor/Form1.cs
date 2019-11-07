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

namespace CpuMemMonitor
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer _timer;
        bool startflag = false;

        public Form1()
        {
            InitializeComponent();
            _timer = new System.Timers.Timer();
            _timer.Interval = 2000;
            _timer.Elapsed += OntimeEvent;
            _timer.AutoReset = true;
        }


        private void OntimeEvent(object source, System.Timers.ElapsedEventArgs e)
        {
           // CheckForIllegalCrossThreadCalls = false;    //UNSAFE

            // Je veux monitorer et obtenir les valeurs du cpu et de la mémmoire
            int cpuValue = GetCpuValue();
            int memvalue = GetMemValue();

        

            if (progressBarCpu.InvokeRequired)
            {
                progressBarCpu.Invoke(new Action(() => progressBarCpu.Value = cpuValue));
            }
            else 
            {
                progressBarCpu.Value = cpuValue;
            }


            if (CpuUsage.InvokeRequired)
            {
                progressBarCpu.Invoke(new Action(() => CpuUsage.Text = cpuValue.ToString() + " %"));
            }
            else
            {
                CpuUsage.Text = cpuValue.ToString() + " %";
            }



            if (progressBarMem.InvokeRequired)
                {
                progressBarMem.Invoke(new Action(() => progressBarMem.Value = memvalue));
            }
            else
            {
                progressBarMem.Value = memvalue;
            }

            if (MemUsage.InvokeRequired)
            {
                progressBarMem.Invoke(new Action(() => MemUsage.Text = memvalue.ToString() + " %"));
            }

            else
            {
                MemUsage.Text = memvalue.ToString() + " %";
            }


            progressBarCpu.Value = cpuValue;
            progressBarMem.Value = memvalue;

        }

        private int GetCpuValue()
        {
            var CpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            CpuCounter.NextValue();
            System.Threading.Thread.Sleep(1000);
            int returnvalue = (int)CpuCounter.NextValue();
            return returnvalue;
        }

        private int GetMemValue()
        {
            var MemCounter = new PerformanceCounter("Memory", "% Committed Bytes in Use");
            int returnvalue = (int)MemCounter.NextValue();
            return returnvalue;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (startflag == false)
            {
                startflag = true;
                _timer.Enabled = true;
                buttonStart.Text = "Stop";
            }
            else
            {
                startflag = false;
                _timer.Enabled = false;
                buttonStart.Text = "Start";
            }
            
        }

    }
}
