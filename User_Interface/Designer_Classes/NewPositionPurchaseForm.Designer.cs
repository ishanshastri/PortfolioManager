namespace IA_Implementation_1
    {
    partial class NewPositionPurchaseForm
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
            this.buy_button = new System.Windows.Forms.Button();
            this.details_groupBox = new System.Windows.Forms.GroupBox();
            this.numToBuy_textBox = new System.Windows.Forms.TextBox();
            this.buyPrice_textBox = new System.Windows.Forms.TextBox();
            this.symbol_textBox = new System.Windows.Forms.TextBox();
            this.numberToBuy_label = new System.Windows.Forms.Label();
            this.buyPrice_label = new System.Windows.Forms.Label();
            this.symbol_label = new System.Windows.Forms.Label();
            this.addPosition_label = new System.Windows.Forms.Label();
            this.details_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // getCurrentPrice_button
            // 
            this.getCurrentPrice_button.Location = new System.Drawing.Point(16, 172);
            this.getCurrentPrice_button.Name = "getCurrentPrice_button";
            this.getCurrentPrice_button.Size = new System.Drawing.Size(73, 34);
            this.getCurrentPrice_button.TabIndex = 9;
            this.getCurrentPrice_button.Text = "Get Current Price";
            this.getCurrentPrice_button.UseVisualStyleBackColor = true;
            this.getCurrentPrice_button.Click += new System.EventHandler(this.getCurrentPrice_button_Click_1);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(105, 183);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(65, 23);
            this.cancel_button.TabIndex = 8;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // buy_button
            // 
            this.buy_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buy_button.Location = new System.Drawing.Point(176, 183);
            this.buy_button.Name = "buy_button";
            this.buy_button.Size = new System.Drawing.Size(64, 23);
            this.buy_button.TabIndex = 7;
            this.buy_button.Text = "Buy";
            this.buy_button.UseVisualStyleBackColor = false;
            this.buy_button.Click += new System.EventHandler(this.buy_button_Click);
            // 
            // details_groupBox
            // 
            this.details_groupBox.Controls.Add(this.numToBuy_textBox);
            this.details_groupBox.Controls.Add(this.buyPrice_textBox);
            this.details_groupBox.Controls.Add(this.symbol_textBox);
            this.details_groupBox.Controls.Add(this.numberToBuy_label);
            this.details_groupBox.Controls.Add(this.buyPrice_label);
            this.details_groupBox.Controls.Add(this.symbol_label);
            this.details_groupBox.Location = new System.Drawing.Point(11, 46);
            this.details_groupBox.Name = "details_groupBox";
            this.details_groupBox.Size = new System.Drawing.Size(229, 120);
            this.details_groupBox.TabIndex = 6;
            this.details_groupBox.TabStop = false;
            this.details_groupBox.Text = "Stock Details";
            this.details_groupBox.Enter += new System.EventHandler(this.details_groupBox_Enter);
            // 
            // numToBuy_textBox
            // 
            this.numToBuy_textBox.Location = new System.Drawing.Point(105, 90);
            this.numToBuy_textBox.Name = "numToBuy_textBox";
            this.numToBuy_textBox.Size = new System.Drawing.Size(100, 20);
            this.numToBuy_textBox.TabIndex = 5;
            // 
            // buyPrice_textBox
            // 
            this.buyPrice_textBox.Location = new System.Drawing.Point(105, 61);
            this.buyPrice_textBox.Name = "buyPrice_textBox";
            this.buyPrice_textBox.Size = new System.Drawing.Size(100, 20);
            this.buyPrice_textBox.TabIndex = 4;
            // 
            // symbol_textBox
            // 
            this.symbol_textBox.Location = new System.Drawing.Point(105, 34);
            this.symbol_textBox.Name = "symbol_textBox";
            this.symbol_textBox.Size = new System.Drawing.Size(100, 20);
            this.symbol_textBox.TabIndex = 3;
            // 
            // numberToBuy_label
            // 
            this.numberToBuy_label.AutoSize = true;
            this.numberToBuy_label.Location = new System.Drawing.Point(15, 90);
            this.numberToBuy_label.Name = "numberToBuy_label";
            this.numberToBuy_label.Size = new System.Drawing.Size(80, 13);
            this.numberToBuy_label.TabIndex = 2;
            this.numberToBuy_label.Text = "Number to Buy:";
            // 
            // buyPrice_label
            // 
            this.buyPrice_label.AutoSize = true;
            this.buyPrice_label.Location = new System.Drawing.Point(15, 64);
            this.buyPrice_label.Name = "buyPrice_label";
            this.buyPrice_label.Size = new System.Drawing.Size(55, 13);
            this.buyPrice_label.TabIndex = 1;
            this.buyPrice_label.Text = "Buy Price:";
            // 
            // symbol_label
            // 
            this.symbol_label.AutoSize = true;
            this.symbol_label.Location = new System.Drawing.Point(15, 37);
            this.symbol_label.Name = "symbol_label";
            this.symbol_label.Size = new System.Drawing.Size(44, 13);
            this.symbol_label.TabIndex = 0;
            this.symbol_label.Text = "Symbol:";
            // 
            // addPosition_label
            // 
            this.addPosition_label.AutoSize = true;
            this.addPosition_label.Font = new System.Drawing.Font("HelvLight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPosition_label.Location = new System.Drawing.Point(12, 9);
            this.addPosition_label.Name = "addPosition_label";
            this.addPosition_label.Size = new System.Drawing.Size(113, 19);
            this.addPosition_label.TabIndex = 5;
            this.addPosition_label.Text = "Add Position";
            this.addPosition_label.Click += new System.EventHandler(this.addPosition_label_Click);
            // 
            // NewPositionPurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 214);
            this.Controls.Add(this.getCurrentPrice_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.buy_button);
            this.Controls.Add(this.details_groupBox);
            this.Controls.Add(this.addPosition_label);
            this.Name = "NewPositionPurchaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock Lab - Buy Position";
            this.Load += new System.EventHandler(this.NewPositionPurchaseForm_Load);
            this.details_groupBox.ResumeLayout(false);
            this.details_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Button getCurrentPrice_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button buy_button;
        private System.Windows.Forms.GroupBox details_groupBox;
        private System.Windows.Forms.TextBox numToBuy_textBox;
        private System.Windows.Forms.TextBox buyPrice_textBox;
        private System.Windows.Forms.TextBox symbol_textBox;
        private System.Windows.Forms.Label numberToBuy_label;
        private System.Windows.Forms.Label buyPrice_label;
        private System.Windows.Forms.Label symbol_label;
        private System.Windows.Forms.Label addPosition_label;
        }
    }