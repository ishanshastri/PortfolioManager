namespace IA_Implementation_1
    {
    partial class StartupMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupMenuForm));
            this.welcomMessage_label = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.viewMyPortfolios_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomMessage_label
            // 
            this.welcomMessage_label.AutoSize = true;
            this.welcomMessage_label.Font = new System.Drawing.Font("HelvLight", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomMessage_label.Location = new System.Drawing.Point(23, 13);
            this.welcomMessage_label.Name = "welcomMessage_label";
            this.welcomMessage_label.Size = new System.Drawing.Size(256, 25);
            this.welcomMessage_label.TabIndex = 0;
            this.welcomMessage_label.Text = "Welcome to Stock Lab!";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.ImageLocation = "";
            this.pictureBox.Location = new System.Drawing.Point(28, 41);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(251, 125);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // viewMyPortfolios_button
            // 
            this.viewMyPortfolios_button.Location = new System.Drawing.Point(111, 172);
            this.viewMyPortfolios_button.Name = "viewMyPortfolios_button";
            this.viewMyPortfolios_button.Size = new System.Drawing.Size(76, 35);
            this.viewMyPortfolios_button.TabIndex = 2;
            this.viewMyPortfolios_button.Text = "Go To My Accounts";
            this.viewMyPortfolios_button.UseVisualStyleBackColor = true;
            this.viewMyPortfolios_button.Click += new System.EventHandler(this.viewMyPortfolios_button_Click);
            // 
            // StartupMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(304, 219);
            this.Controls.Add(this.viewMyPortfolios_button);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.welcomMessage_label);
            this.Name = "StartupMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Lab";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label welcomMessage_label;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button viewMyPortfolios_button;
        }
    }

