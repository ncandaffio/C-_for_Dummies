using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleProgress
{
    public partial class Form1 : Form
    {
        // Declare the delegate. This one is void.
        delegate void UpdateProgressCallback();

        public Form1()
        {
            InitializeComponent();
        }

        private void DoUpdate()
        {
            // Tells progress bar to update itself
            progressBar1.PerformStep();
        }

        // DoSomethingLengthy -- My workhorse method takes a delegate.
        private void DoSomethingLengthy(UpdateProgressCallback updateProgress)
        {
            int duration = 2000;
            int updateInterval = duration / 10;

            for (int i = 0; i < duration; i++)
            {
                Console.WriteLine("Something or other");

                // Update every tenth of the duration.
                if ((i % updateInterval) == 0 && updateProgress != null)
                {
                    updateProgress();  // Invoke the delegate.
                }

                if (updateProgress != null) updateProgress();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateProgressCallback callback = 
                new UpdateProgressCallback(this.DoUpdate);

            // Do something that needs periodic progress reports. This
            // passes a delegate instance that knows how to update the bar.
            DoSomethingLengthy(callback);

            // Clear the bar so that it can be used again.
            progressBar1.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
