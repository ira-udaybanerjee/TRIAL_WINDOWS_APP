using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRIAL_WINDOWS_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void myTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.myTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mYDBDataSet);

        }

        private void myTableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.myTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mYDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mYDBDataSet.MyTable' table. You can move, or remove it, as needed.
            this.myTableTableAdapter.Fill(this.mYDBDataSet.MyTable);

        }
    }
}
