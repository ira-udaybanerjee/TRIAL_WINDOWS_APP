
namespace TRIAL_WINDOWS_APP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label myIdLabel;
            System.Windows.Forms.Label myNameLabel;
            System.Windows.Forms.Label myCityLabel;
            System.Windows.Forms.Label myStateLabel;
            this.mYDBDataSet = new TRIAL_WINDOWS_APP.MYDBDataSet();
            this.myTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myTableTableAdapter = new TRIAL_WINDOWS_APP.MYDBDataSetTableAdapters.MyTableTableAdapter();
            this.tableAdapterManager = new TRIAL_WINDOWS_APP.MYDBDataSetTableAdapters.TableAdapterManager();
            this.myTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.myTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.myIdTextBox = new System.Windows.Forms.TextBox();
            this.myNameTextBox = new System.Windows.Forms.TextBox();
            this.myCityComboBox = new System.Windows.Forms.ComboBox();
            this.myStateComboBox = new System.Windows.Forms.ComboBox();
            myIdLabel = new System.Windows.Forms.Label();
            myNameLabel = new System.Windows.Forms.Label();
            myCityLabel = new System.Windows.Forms.Label();
            myStateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mYDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTableBindingNavigator)).BeginInit();
            this.myTableBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // mYDBDataSet
            // 
            this.mYDBDataSet.DataSetName = "MYDBDataSet";
            this.mYDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myTableBindingSource
            // 
            this.myTableBindingSource.DataMember = "MyTable";
            this.myTableBindingSource.DataSource = this.mYDBDataSet;
            // 
            // myTableTableAdapter
            // 
            this.myTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MyTableTableAdapter = this.myTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = TRIAL_WINDOWS_APP.MYDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // myTableBindingNavigator
            // 
            this.myTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.myTableBindingNavigator.BindingSource = this.myTableBindingSource;
            this.myTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.myTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.myTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.myTableBindingNavigatorSaveItem});
            this.myTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.myTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.myTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.myTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.myTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.myTableBindingNavigator.Name = "myTableBindingNavigator";
            this.myTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.myTableBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.myTableBindingNavigator.TabIndex = 0;
            this.myTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // myTableBindingNavigatorSaveItem
            // 
            this.myTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.myTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("myTableBindingNavigatorSaveItem.Image")));
            this.myTableBindingNavigatorSaveItem.Name = "myTableBindingNavigatorSaveItem";
            this.myTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.myTableBindingNavigatorSaveItem.Text = "Save Data";
            this.myTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.myTableBindingNavigatorSaveItem_Click_1);
            // 
            // myIdLabel
            // 
            myIdLabel.AutoSize = true;
            myIdLabel.Location = new System.Drawing.Point(38, 54);
            myIdLabel.Name = "myIdLabel";
            myIdLabel.Size = new System.Drawing.Size(36, 13);
            myIdLabel.TabIndex = 1;
            myIdLabel.Text = "My Id:";
            // 
            // myIdTextBox
            // 
            this.myIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.myTableBindingSource, "MyId", true));
            this.myIdTextBox.Location = new System.Drawing.Point(99, 51);
            this.myIdTextBox.Name = "myIdTextBox";
            this.myIdTextBox.Size = new System.Drawing.Size(297, 20);
            this.myIdTextBox.TabIndex = 2;
            // 
            // myNameLabel
            // 
            myNameLabel.AutoSize = true;
            myNameLabel.Location = new System.Drawing.Point(38, 80);
            myNameLabel.Name = "myNameLabel";
            myNameLabel.Size = new System.Drawing.Size(55, 13);
            myNameLabel.TabIndex = 3;
            myNameLabel.Text = "My Name:";
            // 
            // myNameTextBox
            // 
            this.myNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.myTableBindingSource, "MyName", true));
            this.myNameTextBox.Location = new System.Drawing.Point(99, 77);
            this.myNameTextBox.Name = "myNameTextBox";
            this.myNameTextBox.Size = new System.Drawing.Size(297, 20);
            this.myNameTextBox.TabIndex = 4;
            // 
            // myCityLabel
            // 
            myCityLabel.AutoSize = true;
            myCityLabel.Location = new System.Drawing.Point(38, 106);
            myCityLabel.Name = "myCityLabel";
            myCityLabel.Size = new System.Drawing.Size(44, 13);
            myCityLabel.TabIndex = 5;
            myCityLabel.Text = "My City:";
            // 
            // myCityComboBox
            // 
            this.myCityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.myTableBindingSource, "MyCity", true));
            this.myCityComboBox.FormattingEnabled = true;
            this.myCityComboBox.Items.AddRange(new object[] {
            "Saharanpur",
            "Dehradun",
            "Chandigarh",
            "Delhi"});
            this.myCityComboBox.Location = new System.Drawing.Point(99, 103);
            this.myCityComboBox.Name = "myCityComboBox";
            this.myCityComboBox.Size = new System.Drawing.Size(297, 21);
            this.myCityComboBox.TabIndex = 6;
            // 
            // myStateLabel
            // 
            myStateLabel.AutoSize = true;
            myStateLabel.Location = new System.Drawing.Point(38, 133);
            myStateLabel.Name = "myStateLabel";
            myStateLabel.Size = new System.Drawing.Size(52, 13);
            myStateLabel.TabIndex = 7;
            myStateLabel.Text = "My State:";
            // 
            // myStateComboBox
            // 
            this.myStateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.myTableBindingSource, "MyState", true));
            this.myStateComboBox.FormattingEnabled = true;
            this.myStateComboBox.Items.AddRange(new object[] {
            "Uttar Pradesh",
            "Uttarakhand",
            "Chandigarh",
            "Delhi"});
            this.myStateComboBox.Location = new System.Drawing.Point(99, 130);
            this.myStateComboBox.Name = "myStateComboBox";
            this.myStateComboBox.Size = new System.Drawing.Size(297, 21);
            this.myStateComboBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(myIdLabel);
            this.Controls.Add(this.myIdTextBox);
            this.Controls.Add(myNameLabel);
            this.Controls.Add(this.myNameTextBox);
            this.Controls.Add(myCityLabel);
            this.Controls.Add(this.myCityComboBox);
            this.Controls.Add(myStateLabel);
            this.Controls.Add(this.myStateComboBox);
            this.Controls.Add(this.myTableBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mYDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTableBindingNavigator)).EndInit();
            this.myTableBindingNavigator.ResumeLayout(false);
            this.myTableBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MYDBDataSet mYDBDataSet;
        private System.Windows.Forms.BindingSource myTableBindingSource;
        private MYDBDataSetTableAdapters.MyTableTableAdapter myTableTableAdapter;
        private MYDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator myTableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton myTableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox myIdTextBox;
        private System.Windows.Forms.TextBox myNameTextBox;
        private System.Windows.Forms.ComboBox myCityComboBox;
        private System.Windows.Forms.ComboBox myStateComboBox;
    }
}

