using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; // For Thread.Sleep

namespace CsharpStudying
{
    public partial class Form7MultiThread : Form
    {
        BackgroundWorker worker = new BackgroundWorker();
        //static int sharedData = 0; // Static variable to keep track of the count

        public Form7MultiThread()
        {
            InitializeComponent();
            worker.WorkerReportsProgress = true; // Enable progress reporting
            worker.WorkerSupportsCancellation = false; // Disable cancellation
            worker.DoWork += new DoWorkEventHandler(Worker_DoWork);
            worker.ProgressChanged += new ProgressChangedEventHandler(Worker_ProgressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Worker_RunWorkerCompleted);


            #region # Thread Example
            /*
            Thread thread1 = new Thread(ThreadMethod1);
            Thread thread2 = new Thread(new ThreadStart(ThreadMethod2));

            thread1.Start();
            thread2.Start();
            */
            #endregion

        }


        #region # Thread Methods
        /*
        private void ThreadMethod1()
        {
            for (int i = 0; i < 10; i++)
            {
                sharedData++;
                Thread.Sleep(10); // CPU 점유 방지용 딜레이
                textBox1.Text += $"1: {sharedData}\r\n";
            }
        }

        private void ThreadMethod2()
        {
            for (int i = 0; i < 10; i++)
            {
                sharedData++;
                Thread.Sleep(10); // Simulate work
                textBox1.Text += $"2: {sharedData}\r\n";
            }
        }*/
        #endregion


        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Perform a time-consuming operation here
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(30); // Simulate work
                worker.ReportProgress(i); // Report progress
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!worker.IsBusy)
            {
                lblStatus.Text = "Processing...";
                progressBar1.Value = 0; // Reset progress bar
                worker.RunWorkerAsync(); // Start the background worker
            }
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage; // Update progress bar //e.ProgressPercentage는 ReportProgress에서 전달한 값. %로 전달.
            lblStatus.Text = $"Progress: {e.ProgressPercentage}%"; // Update status label
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Completed!");
            progressBar1.Value = 100; // Set progress bar to 100%
        }
    }
}
