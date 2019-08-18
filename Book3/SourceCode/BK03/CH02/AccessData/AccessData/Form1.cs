using System;
using System.Windows.Forms;

namespace AccessData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, 
            EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(
                this.adventureWorks2012_DataDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 
            // 'adventureWorks2012_DataDataSet.Product' table. 
            // You can move, or remove it, as needed.
            this.productTableAdapter.Fill(
                this.adventureWorks2012_DataDataSet.Product);

        }
    }
}
