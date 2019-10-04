using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleProgress
{
    public partial class ProgressBarForm : Form
    {

        //Declare Delegates
        delegate void UpdateProgressCallback(string label);

        private void DoSomethingLengthy(UpdateProgressCallback updateProgress)
        {
            int duration = 2000;
            int updateInterval = 10;

            for (int i = 0; i < duration; i++)
            {
                double summation = 1;
                Console.WriteLine("Step {0}", i);
                for (int j = 0; j < i; j++)
                {
                    summation += Math.Pow(summation, Math.Sqrt(j));
                }

                //Update every 10th
                if (i % updateInterval == 0 && updateProgress != null)
                {
                    Console.WriteLine("Update progress");
                    updateProgress("Step " + i + " Complete");
                }
                
            }
        }

        public ProgressBarForm()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Refresh();
            UpdateProgressCallback callback = new UpdateProgressCallback(this.DoUpdate);
            DoSomethingLengthy(callback);
            progressBar1.Value = 0;
            label1.Visible = false;
            label1.Refresh();
        }

        private void DoUpdate(string label)
        {
            label1.Text = label;
            label1.Refresh();
            progressBar1.PerformStep();
        }

    }
}
