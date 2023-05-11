namespace IA_Implementation_1
    {
    partial class PositionSaleForm
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
            this.getCurrentPrice_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.sell_button = new System.Windows.Forms.Button();
            this.details_groupBox = new System.Windows.Forms.GroupBox();
            this.totalNum_label = new System.Windows.Forms.Label();
            this.symbol_label = new System.Windows.Forms.Label();
            this.numToSell_textBox = new System.Windows.Forms.TextBox();
            this.sellPrice_textBox = new System.Windows.Forms.TextBox();
            this.numberToSell_label = new System.Windows.Forms.Label();
            this.sellPrice_label = new System.Windows.Forms.Label();
            this.sellPosition_label = new System.Windows.Forms.Label();
            this.details_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // getCurrentPrice_button
            // 
            this.getCurrentPrice_button.Location = new System.Drawing.Point(32, 184);
            this.getCurrentPrice_button.Name = "getCurrentPrice_button";
            this.getCurrentPrice_button.Size = new System.Drawing.Size(73, 34);
            this.getCurrentPrice_button.TabIndex = 14;
            this.getCurrentPrice_button.Text = "Get Current Price";
            this.getCurrentPrice_button.UseVisualStyleBackColor = true;
            this.getCurrentPrice_button.Click += new System.EventHandler(this.getCurrentPrice_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(121, 195);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(65, 23);
            this.cancel_button.TabIndex = 13;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // sell_button
            // 
            this.sell_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.sell_button.Location = new System.Drawing.Point(192, 195);
            this.sell_button.Name = "sell_button";
            this.sell_button.Size = new System.Drawing.Size(64, 23);
            this.sell_button.TabIndex = 12;
            this.sell_button.Text = "Sell";
            this.sell_button.UseVisualStyleBackColor = false;
            this.sell_button.Click += new System.EventHandler(this.sell_button_Click);
            // 
            // details_groupBox
            // 
            this.details_groupBox.Controls.Add(this.totalNum_label);
            this.details_groupBox.Controls.Add(this.symbol_label);
            this.details_groupBox.Controls.Add(this.numToSell_textBox);
            this.details_groupBox.Controls.Add(this.sellPrice_textBox);
            this.details_groupBox.Controls.Add(this.numberToSell_label);
            this.details_groupBox.Controls.Add(this.sellPrice_label);
            this.details_groupBox.Location = new System.Drawing.Point(27, 56);
            this.details_groupBox.Name = "details_groupBox";
            this.details_groupBox.Size = new System.Drawing.Size(229, 122);
            this.details_groupBox.TabIndex = 11;
            this.details_groupBox.TabStop = false;
            this.details_groupBox.Text = "Sell Details";
            // 
            // totalNum_label
            // 
            this.totalNum_label.AutoSize = true;
            this.totalNum_label.Location = new System.Drawing.Point(171, 87);
            this.totalNum_label.Name = "totalNum_label";
            this.totalNum_label.Size = new System.Drawing.Size(52, 13);
            this.totalNum_label.TabIndex = 7;
            this.totalNum_label.Text = "#/SELL#";
            this.totalNum_label.Visible = false;
            // 
            // symbol_label
            // 
            this.symbol_label.AutoSize = true;
            this.symbol_label.Location = new System.Drawing.Point(16, 31);
            this.symbol_label.Name = "symbol_label";
            this.symbol_label.Size = new System.Drawing.Size(65, 13);
            this.symbol_label.TabIndex = 6;
            this.symbol_label.Text = "#SYMBOL#";
            this.symbol_label.Visible = false;
            // 
            // numToSell_textBox
            // 
            this.numToSell_textBox.Location = new System.Drawing.Point(105, 84);
            this.numToSell_textBox.Name = "numToSell_textBox";
            this.numToSell_textBox.Size = new System.Drawing.Size(60, 20);
            this.numToSell_textBox.TabIndex = 5;
            // 
            // sellPrice_textBox
            // 
            this.sellPrice_textBox.Location = new System.Drawing.Point(105, 56);
            this.sellPrice_textBox.Name = "sellPrice_textBox";
            this.sellPrice_textBox.Size = new System.Drawing.Size(100, 20);
            this.sellPrice_textBox.TabIndex = 4;
            // 
            // numberToSell_label
            // 
            this.numberToSell_label.AutoSize = true;
            this.numberToSell_label.Location = new System.Drawing.Point(15, 87);
            this.numberToSell_label.Name = "numberToSell_label";
            this.numberToSell_label.Size = new System.Drawing.Size(79, 13);
            this.numberToSell_label.TabIndex = 2;
            this.numberToSell_label.Text = "Number to Sell:";
            // 
            // sellPrice_label
            // 
            this.sellPrice_label.AutoSize = true;
            this.sellPrice_label.Location = new System.Drawing.Point(15, 59);
            this.sellPrice_label.Name = "sellPrice_label";
            this.sellPrice_label.Size = new System.Drawing.Size(54, 13);
            this.sellPrice_label.TabIndex = 1;
            this.sellPrice_label.Text = "Sell Price:";
            // 
            // sellPosition_label
            // 
            this.sellPosition_label.AutoSize = true;
            this.sellPosition_label.Font = new System.Drawing.Font("HelvLight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellPosition_label.Location = new System.Drawing.Point(29, 19);
            this.sellPosition_label.Name = "sellPosition_label";
            this.sellPosition_label.Size = new System.Drawing.Size(110, 19);
            this.sellPosition_label.TabIndex = 10;
            this.sellPosition_label.Text = "Sell Position";
            // 
            // PositionSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 230);
            this.Controls.Add(this.getCurrentPrice_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.sell_button);
            this.Controls.Add(this.details_groupBox);
            this.Controls.Add(this.sellPosition_label);
            this.Name = "PositionSaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock Lab - Sell a Position";
            this.details_groupBox.ResumeLayout(false);
            this.details_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Button getCurrentPrice_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button sell_button;
        private System.Windows.Forms.GroupBox details_groupBox;
        private System.Windows.Forms.TextBox numToSell_textBox;
        private System.Windows.Forms.TextBox sellPrice_textBox;
        private System.Windows.Forms.Label numberToSell_label;
        private System.Windows.Forms.Label sellPrice_label;
        private System.Windows.Forms.Label sellPosition_label;
        private System.Windows.Forms.Label symbol_label;
        private System.Windows.Forms.Label totalNum_label;
        }
    }