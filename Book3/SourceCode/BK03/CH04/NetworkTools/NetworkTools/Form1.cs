using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.IO;
using System.Net.Mail;

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

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtain the file.
            DownLoadFile(@"ftp://ftp.yourftpsite.com/afile.txt", 
                @"c:\temp\afile.txt");

            // Send a success message.
            SendEmail(textBox1.Text, textBox1.Text, 
                "FTP Successful", "FTP Successfully downloaded");
        }

        private void DownLoadFile(string remoteFile, string localFile)
        {
            // Create the stream and request objects.
            FileStream localFileStream = 
                new FileStream(localFile, FileMode.OpenOrCreate);
            FtpWebRequest ftpRequest = 
                (FtpWebRequest)WebRequest.Create(remoteFile);

            // Configure the request.
            ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;
            ftpRequest.Credentials = 
                new NetworkCredential("Anonymous", "");

            // Configure the response to the request.
            WebResponse ftpResponse = ftpRequest.GetResponse();
            Stream ftpResponseStream = ftpResponse.GetResponseStream();
            byte[] buffer = new byte[1024];

            // Process the response by downloading data.
            int bytesRead = ftpResponseStream.Read(buffer, 0, 1024);
            while (bytesRead > 0)
            {
                localFileStream.Write(buffer, 0, bytesRead);
                bytesRead = ftpResponseStream.Read(buffer, 0, 1024);
            }

            // Close the streams.
            localFileStream.Close();
            ftpResponseStream.Close();
        }

        private void DownLoadWebFile(string remoteFile, string localFile)
        {
            FileStream localFileStream = 
                new FileStream(localFile, FileMode.OpenOrCreate);
            WebRequest webRequest = WebRequest.Create(remoteFile);
            webRequest.Method = WebRequestMethods.Http.Get;

            WebResponse webResponse = webRequest.GetResponse();
            Stream webResponseStream = webResponse.GetResponseStream();

            byte[] buffer = new byte[1024];
            int bytesRead = webResponseStream.Read(buffer, 0, 1024);
            while (bytesRead > 0)
            {
                localFileStream.Write(buffer, 0, bytesRead);
                bytesRead = webResponseStream.Read(buffer, 0, 1024);
            }

            localFileStream.Close();
            webResponseStream.Close();
        }

        private void SendEmail(string fromAddress, string toAddress, 
            string subject, string body)
        {
            // Define the message.
            MailMessage message = 
                new MailMessage(fromAddress, toAddress, subject, body);

            // Create the connection and send the message.
            SmtpClient mailClient = new SmtpClient("localhost");
            mailClient.Send(message);

            // Release the message and client.
            message = null;
            mailClient = null;
        }
    }
}
