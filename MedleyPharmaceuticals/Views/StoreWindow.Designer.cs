namespace MedleyPharmaceuticals.Views
{
    partial class StoreWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreWindow));
            this.receivedGoodBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.receivedGoodBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.receivedGoodDataGridView = new System.Windows.Forms.DataGridView();
            this.btnStoredProducts = new System.Windows.Forms.Button();
            this.btnDeliveredProducts = new System.Windows.Forms.Button();
            this.btnNondeliveredProducts = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.receivedGoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.receivedGoodBindingNavigator)).BeginInit();
            this.receivedGoodBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receivedGoodDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivedGoodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // receivedGoodBindingNavigator
            // 
            this.receivedGoodBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.receivedGoodBindingNavigator.BindingSource = this.receivedGoodBindingSource;
            this.receivedGoodBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.receivedGoodBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.receivedGoodBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.receivedGoodBindingNavigatorSaveItem});
            this.receivedGoodBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.receivedGoodBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.receivedGoodBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.receivedGoodBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.receivedGoodBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.receivedGoodBindingNavigator.Name = "receivedGoodBindingNavigator";
            this.receivedGoodBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.receivedGoodBindingNavigator.Size = new System.Drawing.Size(1279, 25);
            this.receivedGoodBindingNavigator.TabIndex = 0;
            this.receivedGoodBindingNavigator.Text = "bindingNavigator1";
            this.receivedGoodBindingNavigator.RefreshItems += new System.EventHandler(this.receivedGoodBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // receivedGoodBindingNavigatorSaveItem
            // 
            this.receivedGoodBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.receivedGoodBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("receivedGoodBindingNavigatorSaveItem.Image")));
            this.receivedGoodBindingNavigatorSaveItem.Name = "receivedGoodBindingNavigatorSaveItem";
            this.receivedGoodBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.receivedGoodBindingNavigatorSaveItem.Text = "Save Data";
            this.receivedGoodBindingNavigatorSaveItem.Click += new System.EventHandler(this.receivedGoodBindingNavigatorSaveItem_Click);
            // 
            // receivedGoodDataGridView
            // 
            this.receivedGoodDataGridView.AllowUserToAddRows = false;
            this.receivedGoodDataGridView.AutoGenerateColumns = false;
            this.receivedGoodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receivedGoodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewCheckBoxColumn1});
            this.receivedGoodDataGridView.DataSource = this.receivedGoodBindingSource;
            this.receivedGoodDataGridView.Location = new System.Drawing.Point(12, 28);
            this.receivedGoodDataGridView.Name = "receivedGoodDataGridView";
            this.receivedGoodDataGridView.Size = new System.Drawing.Size(1243, 220);
            this.receivedGoodDataGridView.TabIndex = 1;
            // 
            // btnStoredProducts
            // 
            this.btnStoredProducts.Location = new System.Drawing.Point(528, 275);
            this.btnStoredProducts.Name = "btnStoredProducts";
            this.btnStoredProducts.Size = new System.Drawing.Size(100, 23);
            this.btnStoredProducts.TabIndex = 2;
            this.btnStoredProducts.Text = "Stored Products";
            this.btnStoredProducts.UseVisualStyleBackColor = true;
            this.btnStoredProducts.Click += new System.EventHandler(this.btnStoredProducts_Click);
            // 
            // btnDeliveredProducts
            // 
            this.btnDeliveredProducts.Location = new System.Drawing.Point(409, 275);
            this.btnDeliveredProducts.Name = "btnDeliveredProducts";
            this.btnDeliveredProducts.Size = new System.Drawing.Size(113, 23);
            this.btnDeliveredProducts.TabIndex = 3;
            this.btnDeliveredProducts.Text = "Delivered Products";
            this.btnDeliveredProducts.UseVisualStyleBackColor = true;
            this.btnDeliveredProducts.Click += new System.EventHandler(this.btnDeliveredProducts_Click);
            // 
            // btnNondeliveredProducts
            // 
            this.btnNondeliveredProducts.Location = new System.Drawing.Point(635, 275);
            this.btnNondeliveredProducts.Name = "btnNondeliveredProducts";
            this.btnNondeliveredProducts.Size = new System.Drawing.Size(133, 23);
            this.btnNondeliveredProducts.TabIndex = 4;
            this.btnNondeliveredProducts.Text = "Nondelivered Products";
            this.btnNondeliveredProducts.UseVisualStyleBackColor = true;
            this.btnNondeliveredProducts.Click += new System.EventHandler(this.btnNondeliveredProducts_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ReceivingDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "ReceivingDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GRNNo";
            this.dataGridViewTextBoxColumn3.HeaderText = "GRNNo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaterialName";
            this.dataGridViewTextBoxColumn4.HeaderText = "MaterialName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BatchNo";
            this.dataGridViewTextBoxColumn5.HeaderText = "BatchNo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MfgDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "MfgDate";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ExpDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "ExpDate";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "QuantityReceived";
            this.dataGridViewTextBoxColumn8.HeaderText = "QuantityReceived";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "NoOfCartons";
            this.dataGridViewTextBoxColumn9.HeaderText = "NoOfCartons";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Supplier";
            this.dataGridViewTextBoxColumn10.HeaderText = "Supplier";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ReferenceNo";
            this.dataGridViewTextBoxColumn11.HeaderText = "ReferenceNo";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "DeliveredToStore";
            this.dataGridViewCheckBoxColumn1.HeaderText = "DeliveredToStore";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // receivedGoodBindingSource
            // 
            this.receivedGoodBindingSource.DataSource = typeof(Medley.Core.Models.RawProduct);
            // 
            // StoreWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 354);
            this.Controls.Add(this.btnNondeliveredProducts);
            this.Controls.Add(this.btnDeliveredProducts);
            this.Controls.Add(this.btnStoredProducts);
            this.Controls.Add(this.receivedGoodDataGridView);
            this.Controls.Add(this.receivedGoodBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StoreWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StoreWindow";
            this.Load += new System.EventHandler(this.StoreWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.receivedGoodBindingNavigator)).EndInit();
            this.receivedGoodBindingNavigator.ResumeLayout(false);
            this.receivedGoodBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receivedGoodDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivedGoodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource receivedGoodBindingSource;
        private System.Windows.Forms.BindingNavigator receivedGoodBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton receivedGoodBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView receivedGoodDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button btnStoredProducts;
        private System.Windows.Forms.Button btnDeliveredProducts;
        private System.Windows.Forms.Button btnNondeliveredProducts;
    }
}