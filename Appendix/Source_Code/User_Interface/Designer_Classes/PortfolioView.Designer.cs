namespace IA_Implementation_1
    {
    /// <summary>
    /// The main view of the program; displays all of the user's accounts, and the contents of those accounts. The user interacts with the program through this form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class PortfolioView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortfolioView));
            this.portfolioViewMenu_menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileButton_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAccountButton_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.newPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePosition_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitButton_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasePositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellPositionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.refreshPrices_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.heldButton_button = new System.Windows.Forms.Button();
            this.soldButton_button = new System.Windows.Forms.Button();
            this.portfolioList_listBox = new System.Windows.Forms.ListBox();
            this.accountPositionViewHeld_listView = new System.Windows.Forms.ListView();
            this.symbol_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buyPrice_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buyDate_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.currPrice_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.costBasis_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalValue_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gain_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.accountPositionViewSold_listView = new System.Windows.Forms.ListView();
            this.symbol_sold_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity_sold_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buyDate_sold_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buyPrice_sold_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sellDate_sold_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sellPrice_sold_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.costBasis_sold_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soldValue_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gain_sold_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userSummary_groupBox = new System.Windows.Forms.GroupBox();
            this.gain_label = new System.Windows.Forms.Label();
            this.totalValue_label = new System.Windows.Forms.Label();
            this.accountDetails_held_groupBox = new System.Windows.Forms.GroupBox();
            this.costBasis_label = new System.Windows.Forms.Label();
            this.netProfitLoss_label = new System.Windows.Forms.Label();
            this.netChange_label = new System.Windows.Forms.Label();
            this.totalStockValue_label = new System.Windows.Forms.Label();
            this.accountDetails_sold_groupBox = new System.Windows.Forms.GroupBox();
            this.costBasis_sold_label = new System.Windows.Forms.Label();
            this.percentChange_sold_label = new System.Windows.Forms.Label();
            this.netChange_sold_label = new System.Windows.Forms.Label();
            this.totalValSold_label = new System.Windows.Forms.Label();
            this.accounts_label = new System.Windows.Forms.Label();
            this.portfolioViewMenu_menuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.userSummary_groupBox.SuspendLayout();
            this.accountDetails_held_groupBox.SuspendLayout();
            this.accountDetails_sold_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // portfolioViewMenu_menuStrip
            // 
            this.portfolioViewMenu_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileButton_ToolStripMenuItem,
            this.actionsToolStripMenuItem});
            this.portfolioViewMenu_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.portfolioViewMenu_menuStrip.Name = "portfolioViewMenu_menuStrip";
            this.portfolioViewMenu_menuStrip.Size = new System.Drawing.Size(776, 24);
            this.portfolioViewMenu_menuStrip.TabIndex = 0;
            this.portfolioViewMenu_menuStrip.Text = "Menu Bar";
            // 
            // fileButton_ToolStripMenuItem
            // 
            this.fileButton_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAccountButton_ToolStripMenuItem,
            this.toolStripSeparator2,
            this.newPositionToolStripMenuItem,
            this.sellPositionToolStripMenuItem,
            this.deletePosition_toolStripMenuItem,
            this.toolStripSeparator1,
            this.exitButton_toolStripMenuItem});
            this.fileButton_ToolStripMenuItem.Name = "fileButton_ToolStripMenuItem";
            this.fileButton_ToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileButton_ToolStripMenuItem.Text = "File";
            // 
            // newAccountButton_ToolStripMenuItem
            // 
            this.newAccountButton_ToolStripMenuItem.Name = "newAccountButton_ToolStripMenuItem";
            this.newAccountButton_ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newAccountButton_ToolStripMenuItem.Text = "New Account";
            this.newAccountButton_ToolStripMenuItem.Click += new System.EventHandler(this.newPortfolioButton_ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(150, 6);
            // 
            // newPositionToolStripMenuItem
            // 
            this.newPositionToolStripMenuItem.Enabled = false;
            this.newPositionToolStripMenuItem.Name = "newPositionToolStripMenuItem";
            this.newPositionToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newPositionToolStripMenuItem.Text = "New Position";
            this.newPositionToolStripMenuItem.Click += new System.EventHandler(this.newPositionToolStripMenuItem_Click);
            // 
            // sellPositionToolStripMenuItem
            // 
            this.sellPositionToolStripMenuItem.Name = "sellPositionToolStripMenuItem";
            this.sellPositionToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.sellPositionToolStripMenuItem.Text = "Sell Position";
            this.sellPositionToolStripMenuItem.Click += new System.EventHandler(this.sellPositionToolStripMenuItem_Click);
            // 
            // deletePosition_toolStripMenuItem
            // 
            this.deletePosition_toolStripMenuItem.Name = "deletePosition_toolStripMenuItem";
            this.deletePosition_toolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.deletePosition_toolStripMenuItem.Text = "Delete Position";
            this.deletePosition_toolStripMenuItem.Click += new System.EventHandler(this.deletePosition_toolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // exitButton_toolStripMenuItem
            // 
            this.exitButton_toolStripMenuItem.Name = "exitButton_toolStripMenuItem";
            this.exitButton_toolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exitButton_toolStripMenuItem.Text = "Exit";
            this.exitButton_toolStripMenuItem.Click += new System.EventHandler(this.exitButton_toolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchasePositionToolStripMenuItem,
            this.sellPositionToolStripMenuItem1});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            this.actionsToolStripMenuItem.Visible = false;
            // 
            // purchasePositionToolStripMenuItem
            // 
            this.purchasePositionToolStripMenuItem.Name = "purchasePositionToolStripMenuItem";
            this.purchasePositionToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.purchasePositionToolStripMenuItem.Text = "Purchase Position";
            // 
            // sellPositionToolStripMenuItem1
            // 
            this.sellPositionToolStripMenuItem1.Name = "sellPositionToolStripMenuItem1";
            this.sellPositionToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.sellPositionToolStripMenuItem1.Text = "Sell Position";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshPrices_toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 448);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(776, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // refreshPrices_toolStripStatusLabel
            // 
            this.refreshPrices_toolStripStatusLabel.Image = ((System.Drawing.Image)(resources.GetObject("refreshPrices_toolStripStatusLabel.Image")));
            this.refreshPrices_toolStripStatusLabel.Name = "refreshPrices_toolStripStatusLabel";
            this.refreshPrices_toolStripStatusLabel.Size = new System.Drawing.Size(96, 17);
            this.refreshPrices_toolStripStatusLabel.Text = "Refresh Prices";
            this.refreshPrices_toolStripStatusLabel.Click += new System.EventHandler(this.refreshPrices_toolStripStatusLabel_Click);
            this.refreshPrices_toolStripStatusLabel.MouseLeave += new System.EventHandler(this.refreshPrices_toolStripStatusLabel_MouseLeave);
            this.refreshPrices_toolStripStatusLabel.MouseHover += new System.EventHandler(this.refreshPrices_toolStripStatusLabel_MouseHover);
            // 
            // heldButton_button
            // 
            this.heldButton_button.Enabled = false;
            this.heldButton_button.Location = new System.Drawing.Point(204, 27);
            this.heldButton_button.Name = "heldButton_button";
            this.heldButton_button.Size = new System.Drawing.Size(284, 45);
            this.heldButton_button.TabIndex = 5;
            this.heldButton_button.Text = "Held";
            this.heldButton_button.UseVisualStyleBackColor = true;
            this.heldButton_button.Click += new System.EventHandler(this.heldButton_button_Click);
            // 
            // soldButton_button
            // 
            this.soldButton_button.Enabled = false;
            this.soldButton_button.Location = new System.Drawing.Point(493, 27);
            this.soldButton_button.Name = "soldButton_button";
            this.soldButton_button.Size = new System.Drawing.Size(283, 45);
            this.soldButton_button.TabIndex = 6;
            this.soldButton_button.Text = "Sold";
            this.soldButton_button.UseVisualStyleBackColor = true;
            this.soldButton_button.Click += new System.EventHandler(this.soldButton_button_Click);
            // 
            // portfolioList_listBox
            // 
            this.portfolioList_listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.portfolioList_listBox.FormattingEnabled = true;
            this.portfolioList_listBox.IntegralHeight = false;
            this.portfolioList_listBox.Location = new System.Drawing.Point(0, 72);
            this.portfolioList_listBox.Name = "portfolioList_listBox";
            this.portfolioList_listBox.Size = new System.Drawing.Size(198, 307);
            this.portfolioList_listBox.TabIndex = 7;
            this.portfolioList_listBox.SelectedValueChanged += new System.EventHandler(this.portfolioList_listBox_SelectedValueChanged);
            // 
            // accountPositionViewHeld_listView
            // 
            this.accountPositionViewHeld_listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountPositionViewHeld_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.symbol_column,
            this.quantity_column,
            this.buyPrice_column,
            this.buyDate_columnHeader,
            this.currPrice_columnHeader,
            this.costBasis_columnHeader,
            this.totalValue_columnHeader,
            this.gain_columnHeader});
            this.accountPositionViewHeld_listView.Enabled = false;
            this.accountPositionViewHeld_listView.FullRowSelect = true;
            this.accountPositionViewHeld_listView.GridLines = true;
            this.accountPositionViewHeld_listView.Location = new System.Drawing.Point(203, 72);
            this.accountPositionViewHeld_listView.MultiSelect = false;
            this.accountPositionViewHeld_listView.Name = "accountPositionViewHeld_listView";
            this.accountPositionViewHeld_listView.Size = new System.Drawing.Size(573, 307);
            this.accountPositionViewHeld_listView.TabIndex = 8;
            this.accountPositionViewHeld_listView.UseCompatibleStateImageBehavior = false;
            this.accountPositionViewHeld_listView.View = System.Windows.Forms.View.Details;
            // 
            // symbol_column
            // 
            this.symbol_column.Text = "Symbol";
            this.symbol_column.Width = 53;
            // 
            // quantity_column
            // 
            this.quantity_column.Text = "Quantity";
            this.quantity_column.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantity_column.Width = 55;
            // 
            // buyPrice_column
            // 
            this.buyPrice_column.Text = "Buy Price";
            this.buyPrice_column.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buyPrice_column.Width = 59;
            // 
            // buyDate_columnHeader
            // 
            this.buyDate_columnHeader.Text = "Buy Date";
            this.buyDate_columnHeader.Width = 81;
            // 
            // currPrice_columnHeader
            // 
            this.currPrice_columnHeader.Text = "Current Price";
            this.currPrice_columnHeader.Width = 75;
            // 
            // costBasis_columnHeader
            // 
            this.costBasis_columnHeader.Text = "Cost Basis";
            this.costBasis_columnHeader.Width = 68;
            // 
            // totalValue_columnHeader
            // 
            this.totalValue_columnHeader.Text = "Total Value";
            this.totalValue_columnHeader.Width = 73;
            // 
            // gain_columnHeader
            // 
            this.gain_columnHeader.Text = "Gain";
            this.gain_columnHeader.Width = 90;
            // 
            // accountPositionViewSold_listView
            // 
            this.accountPositionViewSold_listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountPositionViewSold_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.symbol_sold_columnHeader,
            this.quantity_sold_columnHeader,
            this.buyDate_sold_columnHeader,
            this.buyPrice_sold_columnHeader,
            this.sellDate_sold_columnHeader,
            this.sellPrice_sold_columnHeader,
            this.costBasis_sold_columnHeader,
            this.soldValue_columnHeader,
            this.gain_sold_columnHeader});
            this.accountPositionViewSold_listView.Enabled = false;
            this.accountPositionViewSold_listView.FullRowSelect = true;
            this.accountPositionViewSold_listView.GridLines = true;
            this.accountPositionViewSold_listView.Location = new System.Drawing.Point(203, 72);
            this.accountPositionViewSold_listView.MultiSelect = false;
            this.accountPositionViewSold_listView.Name = "accountPositionViewSold_listView";
            this.accountPositionViewSold_listView.Size = new System.Drawing.Size(573, 307);
            this.accountPositionViewSold_listView.TabIndex = 9;
            this.accountPositionViewSold_listView.UseCompatibleStateImageBehavior = false;
            this.accountPositionViewSold_listView.View = System.Windows.Forms.View.Details;
            this.accountPositionViewSold_listView.Visible = false;
            // 
            // symbol_sold_columnHeader
            // 
            this.symbol_sold_columnHeader.Text = "Symbol";
            this.symbol_sold_columnHeader.Width = 56;
            // 
            // quantity_sold_columnHeader
            // 
            this.quantity_sold_columnHeader.Text = "Quantity";
            this.quantity_sold_columnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantity_sold_columnHeader.Width = 53;
            // 
            // buyDate_sold_columnHeader
            // 
            this.buyDate_sold_columnHeader.Text = "Buy Date";
            this.buyDate_sold_columnHeader.Width = 72;
            // 
            // buyPrice_sold_columnHeader
            // 
            this.buyPrice_sold_columnHeader.Text = "Buy Price";
            // 
            // sellDate_sold_columnHeader
            // 
            this.sellDate_sold_columnHeader.Text = "Sell Date";
            this.sellDate_sold_columnHeader.Width = 68;
            // 
            // sellPrice_sold_columnHeader
            // 
            this.sellPrice_sold_columnHeader.Text = "Sell Price";
            this.sellPrice_sold_columnHeader.Width = 57;
            // 
            // costBasis_sold_columnHeader
            // 
            this.costBasis_sold_columnHeader.Text = "Cost Basis";
            this.costBasis_sold_columnHeader.Width = 63;
            // 
            // soldValue_columnHeader
            // 
            this.soldValue_columnHeader.Text = "Sold Value";
            this.soldValue_columnHeader.Width = 63;
            // 
            // gain_sold_columnHeader
            // 
            this.gain_sold_columnHeader.Text = "Net Gain";
            this.gain_sold_columnHeader.Width = 56;
            // 
            // userSummary_groupBox
            // 
            this.userSummary_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userSummary_groupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userSummary_groupBox.Controls.Add(this.gain_label);
            this.userSummary_groupBox.Controls.Add(this.totalValue_label);
            this.userSummary_groupBox.Location = new System.Drawing.Point(1, 385);
            this.userSummary_groupBox.Name = "userSummary_groupBox";
            this.userSummary_groupBox.Size = new System.Drawing.Size(197, 60);
            this.userSummary_groupBox.TabIndex = 5;
            this.userSummary_groupBox.TabStop = false;
            // 
            // gain_label
            // 
            this.gain_label.AutoSize = true;
            this.gain_label.Location = new System.Drawing.Point(6, 37);
            this.gain_label.Name = "gain_label";
            this.gain_label.Size = new System.Drawing.Size(59, 13);
            this.gain_label.TabIndex = 1;
            this.gain_label.Text = "Total Gain:";
            // 
            // totalValue_label
            // 
            this.totalValue_label.AutoSize = true;
            this.totalValue_label.Location = new System.Drawing.Point(6, 16);
            this.totalValue_label.Name = "totalValue_label";
            this.totalValue_label.Size = new System.Drawing.Size(106, 13);
            this.totalValue_label.TabIndex = 0;
            this.totalValue_label.Text = "Total Value in Stock:";
            // 
            // accountDetails_held_groupBox
            // 
            this.accountDetails_held_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountDetails_held_groupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.accountDetails_held_groupBox.Controls.Add(this.costBasis_label);
            this.accountDetails_held_groupBox.Controls.Add(this.netProfitLoss_label);
            this.accountDetails_held_groupBox.Controls.Add(this.netChange_label);
            this.accountDetails_held_groupBox.Controls.Add(this.totalStockValue_label);
            this.accountDetails_held_groupBox.Location = new System.Drawing.Point(204, 385);
            this.accountDetails_held_groupBox.Name = "accountDetails_held_groupBox";
            this.accountDetails_held_groupBox.Size = new System.Drawing.Size(572, 60);
            this.accountDetails_held_groupBox.TabIndex = 6;
            this.accountDetails_held_groupBox.TabStop = false;
            // 
            // costBasis_label
            // 
            this.costBasis_label.AutoSize = true;
            this.costBasis_label.Location = new System.Drawing.Point(6, 37);
            this.costBasis_label.Name = "costBasis_label";
            this.costBasis_label.Size = new System.Drawing.Size(79, 13);
            this.costBasis_label.TabIndex = 3;
            this.costBasis_label.Text = "Net Cost Basis:";
            // 
            // netProfitLoss_label
            // 
            this.netProfitLoss_label.AutoSize = true;
            this.netProfitLoss_label.Location = new System.Drawing.Point(302, 16);
            this.netProfitLoss_label.Name = "netProfitLoss_label";
            this.netProfitLoss_label.Size = new System.Drawing.Size(87, 13);
            this.netProfitLoss_label.TabIndex = 2;
            this.netProfitLoss_label.Text = "Percent Change:";
            // 
            // netChange_label
            // 
            this.netChange_label.AutoSize = true;
            this.netChange_label.Location = new System.Drawing.Point(302, 37);
            this.netChange_label.Name = "netChange_label";
            this.netChange_label.Size = new System.Drawing.Size(67, 13);
            this.netChange_label.TabIndex = 1;
            this.netChange_label.Text = "Net Change:";
            // 
            // totalStockValue_label
            // 
            this.totalStockValue_label.AutoSize = true;
            this.totalStockValue_label.Location = new System.Drawing.Point(6, 16);
            this.totalStockValue_label.Name = "totalStockValue_label";
            this.totalStockValue_label.Size = new System.Drawing.Size(106, 13);
            this.totalStockValue_label.TabIndex = 0;
            this.totalStockValue_label.Text = "Total Value in Stock:";
            // 
            // accountDetails_sold_groupBox
            // 
            this.accountDetails_sold_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.accountDetails_sold_groupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.accountDetails_sold_groupBox.Controls.Add(this.costBasis_sold_label);
            this.accountDetails_sold_groupBox.Controls.Add(this.percentChange_sold_label);
            this.accountDetails_sold_groupBox.Controls.Add(this.netChange_sold_label);
            this.accountDetails_sold_groupBox.Controls.Add(this.totalValSold_label);
            this.accountDetails_sold_groupBox.Location = new System.Drawing.Point(204, 385);
            this.accountDetails_sold_groupBox.Name = "accountDetails_sold_groupBox";
            this.accountDetails_sold_groupBox.Size = new System.Drawing.Size(572, 60);
            this.accountDetails_sold_groupBox.TabIndex = 7;
            this.accountDetails_sold_groupBox.TabStop = false;
            // 
            // costBasis_sold_label
            // 
            this.costBasis_sold_label.AutoSize = true;
            this.costBasis_sold_label.Location = new System.Drawing.Point(6, 37);
            this.costBasis_sold_label.Name = "costBasis_sold_label";
            this.costBasis_sold_label.Size = new System.Drawing.Size(79, 13);
            this.costBasis_sold_label.TabIndex = 3;
            this.costBasis_sold_label.Text = "Net Cost Basis:";
            // 
            // percentChange_sold_label
            // 
            this.percentChange_sold_label.AutoSize = true;
            this.percentChange_sold_label.Location = new System.Drawing.Point(302, 16);
            this.percentChange_sold_label.Name = "percentChange_sold_label";
            this.percentChange_sold_label.Size = new System.Drawing.Size(87, 13);
            this.percentChange_sold_label.TabIndex = 2;
            this.percentChange_sold_label.Text = "Percent Change:";
            // 
            // netChange_sold_label
            // 
            this.netChange_sold_label.AutoSize = true;
            this.netChange_sold_label.Location = new System.Drawing.Point(302, 37);
            this.netChange_sold_label.Name = "netChange_sold_label";
            this.netChange_sold_label.Size = new System.Drawing.Size(67, 13);
            this.netChange_sold_label.TabIndex = 1;
            this.netChange_sold_label.Text = "Net Change:";
            this.netChange_sold_label.Click += new System.EventHandler(this.netChange_sold_label_Click);
            // 
            // totalValSold_label
            // 
            this.totalValSold_label.AutoSize = true;
            this.totalValSold_label.Location = new System.Drawing.Point(6, 16);
            this.totalValSold_label.Name = "totalValSold_label";
            this.totalValSold_label.Size = new System.Drawing.Size(88, 13);
            this.totalValSold_label.TabIndex = 0;
            this.totalValSold_label.Text = "Total Value Sold:";
            // 
            // accounts_label
            // 
            this.accounts_label.AutoSize = true;
            this.accounts_label.Font = new System.Drawing.Font("HelvLight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accounts_label.Location = new System.Drawing.Point(44, 50);
            this.accounts_label.Name = "accounts_label";
            this.accounts_label.Size = new System.Drawing.Size(85, 19);
            this.accounts_label.TabIndex = 10;
            this.accounts_label.Text = "Accounts";
            // 
            // PortfolioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 470);
            this.Controls.Add(this.accounts_label);
            this.Controls.Add(this.userSummary_groupBox);
            this.Controls.Add(this.portfolioList_listBox);
            this.Controls.Add(this.soldButton_button);
            this.Controls.Add(this.heldButton_button);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.portfolioViewMenu_menuStrip);
            this.Controls.Add(this.accountPositionViewHeld_listView);
            this.Controls.Add(this.accountDetails_held_groupBox);
            this.Controls.Add(this.accountDetails_sold_groupBox);
            this.Controls.Add(this.accountPositionViewSold_listView);
            this.MainMenuStrip = this.portfolioViewMenu_menuStrip;
            this.Name = "PortfolioView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Lab - My Accounts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PortfolioView_FormClosing);
            this.Load += new System.EventHandler(this.PortfolioView_Load);
            this.Shown += new System.EventHandler(this.PortfolioView_Shown);
            this.portfolioViewMenu_menuStrip.ResumeLayout(false);
            this.portfolioViewMenu_menuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.userSummary_groupBox.ResumeLayout(false);
            this.userSummary_groupBox.PerformLayout();
            this.accountDetails_held_groupBox.ResumeLayout(false);
            this.accountDetails_held_groupBox.PerformLayout();
            this.accountDetails_sold_groupBox.ResumeLayout(false);
            this.accountDetails_sold_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.MenuStrip portfolioViewMenu_menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button heldButton_button;
        private System.Windows.Forms.Button soldButton_button;
        private System.Windows.Forms.ToolStripMenuItem fileButton_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAccountButton_ToolStripMenuItem;
        private System.Windows.Forms.ListBox portfolioList_listBox;
        private System.Windows.Forms.ListView accountPositionViewHeld_listView;
        private System.Windows.Forms.ColumnHeader symbol_column;
        private System.Windows.Forms.ColumnHeader quantity_column;
        private System.Windows.Forms.ColumnHeader buyPrice_column;
        private System.Windows.Forms.ToolStripMenuItem newPositionToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader buyDate_columnHeader;
        private System.Windows.Forms.ToolStripMenuItem sellPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel refreshPrices_toolStripStatusLabel;
        private System.Windows.Forms.ListView accountPositionViewSold_listView;
        private System.Windows.Forms.ColumnHeader symbol_sold_columnHeader;
        private System.Windows.Forms.ColumnHeader quantity_sold_columnHeader;
        private System.Windows.Forms.ColumnHeader buyDate_sold_columnHeader;
        private System.Windows.Forms.ColumnHeader buyPrice_sold_columnHeader;
        private System.Windows.Forms.ColumnHeader sellDate_sold_columnHeader;
        private System.Windows.Forms.ColumnHeader sellPrice_sold_columnHeader;
        private System.Windows.Forms.ColumnHeader gain_sold_columnHeader;
        private System.Windows.Forms.GroupBox userSummary_groupBox;
        private System.Windows.Forms.Label gain_label;
        private System.Windows.Forms.Label totalValue_label;
        private System.Windows.Forms.ColumnHeader currPrice_columnHeader;
        private System.Windows.Forms.ColumnHeader costBasis_columnHeader;
        private System.Windows.Forms.ColumnHeader totalValue_columnHeader;
        private System.Windows.Forms.ColumnHeader gain_columnHeader;
        private System.Windows.Forms.ColumnHeader soldValue_columnHeader;
        private System.Windows.Forms.GroupBox accountDetails_held_groupBox;
        private System.Windows.Forms.Label netChange_label;
        private System.Windows.Forms.Label totalStockValue_label;
        private System.Windows.Forms.Label costBasis_label;
        private System.Windows.Forms.Label netProfitLoss_label;
        private System.Windows.Forms.GroupBox accountDetails_sold_groupBox;
        private System.Windows.Forms.Label costBasis_sold_label;
        private System.Windows.Forms.Label percentChange_sold_label;
        private System.Windows.Forms.Label netChange_sold_label;
        private System.Windows.Forms.Label totalValSold_label;
        private System.Windows.Forms.ColumnHeader costBasis_sold_columnHeader;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchasePositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellPositionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitButton_toolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deletePosition_toolStripMenuItem;
        private System.Windows.Forms.Label accounts_label;
        }
    }