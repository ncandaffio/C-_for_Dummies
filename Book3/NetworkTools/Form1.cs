using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.IO;

namespace NetworkTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                toolStripStatusLabel1.Text = "Connected";
            }
            else
            {
                toolStripStatusLabel1.Text = "Disconnected";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void DownloadFile(string remoteFile, string localFile)
        {
            FileStream localFileStream = new FileStream(localFile, FileMode.OpenOrCreate);
            FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(remoteFile);
        }
    }
}
