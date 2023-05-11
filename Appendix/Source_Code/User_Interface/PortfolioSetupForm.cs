using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA_Implementation_1
    {
    public partial class PortfolioSetupForm : Form
        {
        /// <summary>
        /// Gets the name of the portfolio.
        /// </summary>
        /// <value>
        /// The name of the portfolio.
        /// </value>
        private string portfolioName { get { return Path.GetFileNameWithoutExtension(this.PortfolioName_textBox.Text.Trim()); } }

        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioSetupForm"/> class.
        /// </summary>
        public PortfolioSetupForm()
            {
            InitializeComponent();
            }

        private void cancel_button_Click(object sender, EventArgs e)
            {
            //Indicate that the setup form has been cancelled
            this.DialogResult = DialogResult.Cancel;
            }

        /// <summary>
        /// Gets the account information.
        /// </summary>
        /// <returns>AccountInfo object</returns>
        public AccountInfo GetAccountInfo()
            {
            //Get account information, populate necessary properties
            AccountInfo ai = new AccountInfo(this.portfolioName);

            //Return the information
            return ai;
            }

        private void create_button_Click(object sender, EventArgs e)
            {
            //Verify user input
            if (!isValidPortfolioName())
                {               
                return;
                }
            
            //If conditions met, set dialog result to 'OK'
            this.DialogResult = DialogResult.OK;
            }

        /// <summary>
        /// Verifies the portfolio name.
        /// </summary>
        /// <returns>true (valid name) or false (invalid name)</returns>
        private bool isValidPortfolioName()
            {
            //Check if any invalid file-name characters --> Move to Database?
            if (this.portfolioName.IndexOfAny(Path.GetInvalidFileNameChars()) != -1)
                {
                MessageBox.Show("Invalid Name for a File");
                return false;
                }

            //Check for existing file-name
            if (Program.TheDatabase.IsExistingAccountName(this.portfolioName))
                {
                MessageBox.Show("Filename Alread Exists: " + this.portfolioName);
                return false;
                }

            //...Add any new conditions here

            //If all conditions met, return true
            return true;
            }
        }
    }
