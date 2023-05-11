namespace IA_Implementation_1
    {
    /// <summary>
    /// Dialog displayed for user to create a new Account/Portfolio
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class PortfolioSetupForm
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
            this.create_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.PortfolioName_textBox = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // create_button
            // 
            this.create_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.create_button.Location = new System.Drawing.Point(181, 61);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(75, 23);
            this.create_button.TabIndex = 11;
            this.create_button.Text = "Create";
            this.create_button.UseVisualStyleBackColor = false;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.SystemColors.Control;
            this.cancel_button.Location = new System.Drawing.Point(100, 61);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 10;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // PortfolioName_textBox
            // 
            this.PortfolioName_textBox.Location = new System.Drawing.Point(100, 23);
            this.PortfolioName_textBox.Name = "PortfolioName_textBox";
            this.PortfolioName_textBox.Size = new System.Drawing.Size(156, 20);
            this.PortfolioName_textBox.TabIndex = 7;
            this.PortfolioName_textBox.Text = "Untitled";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(21, 26);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(84, 13);
            this.name_label.TabIndex = 6;
            this.name_label.Text = "Account Name: ";
            // 
            // PortfolioSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 101);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.PortfolioName_textBox);
            this.Controls.Add(this.name_label);
            this.Name = "PortfolioSetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock Lab - New Account";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.TextBox PortfolioName_textBox;
        private System.Windows.Forms.Label name_label;
        }
    }