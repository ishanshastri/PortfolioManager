using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA_Implementation_1
    {
    /// <summary>
    /// The Startup Menu Display Form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class StartupMenuForm : Form
        {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartupMenuForm"/> class.
        /// </summary>
        public StartupMenuForm()
            {
            InitializeComponent();
            }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
            {
            //Exit the program whenever the the 'x' button is clicked.
            Application.Exit();
            }

        //On load event
        private void Form1_Load(object sender, EventArgs e) { }

        private void viewMyPortfolios_button_Click(object sender, EventArgs e)
            {
            //Create a new Portoflio View and display it. 
            PortfolioView pv = new PortfolioView();
            pv.Show();

            //Hide menu.
            this.Hide();
            }

        private void startNewPortfolio_button_Click(object sender, EventArgs e)
            {

            }
        }
    }
