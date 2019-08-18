using System;
using System.Windows.Forms;
using System.Security.Principal;

namespace SecureButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get the user's identity.
            WindowsIdentity myIdentity = WindowsIdentity.GetCurrent();

            // Obtain information about the user's rights.
            WindowsPrincipal myPrincipal = 
                new WindowsPrincipal(myIdentity);

            // Determine which buttons to show based on
            // the user's rights.
            if (myPrincipal.IsInRole("Accounting"))
            {
                AccountingButton.Visible = true;
            }
            else if (myPrincipal.IsInRole("Sales"))
            {
                SalesButton.Visible = true;
            }
            else if (myPrincipal.IsInRole("Management"))
            {
                ManagerButton.Visible = true;
            }
        }
    }
}
