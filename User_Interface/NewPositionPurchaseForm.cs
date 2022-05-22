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
    /// <inheritdoc/>
    public partial class NewPositionPurchaseForm : Form
        {
        /// <summary>
        /// Gets the symbol.
        /// </summary>
        /// <value>
        /// The symbol.
        /// </value>
        public string Symbol
            {
            get { return this.symbol_textBox.Text; }
            private set { }
            }

        /// <summary>
        /// Gets the stock information.
        /// </summary>
        /// <value>
        /// The stock information.
        /// </value>
        private StockInfo StockInformation;

        /// <summary>
        /// Gets the position buy parameters.
        /// </summary>
        /// <value>
        /// The position buy parameters.
        /// </value>
        public PositionBuyParameters PositionBuyParams { get; private set; }

        /// <summary>
        /// Gets the number to purchase.
        /// </summary>
        /// <value>
        /// The number to purchase.
        /// </value>
        public int NumberToPurchase
            {
            get { return Int32.Parse(this.numToBuy_textBox.Text); }//Add try-catch
            private set { }
            }

        /// <summary>
        /// Gets the buy price.
        /// </summary>
        /// <value>
        /// The buy price.
        /// </value>
        public double BuyPrice
            {
            get { return Double.Parse(this.buyPrice_textBox.Text); }//Add try-catch
            private set { }
            }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewPositionPurchaseForm"/> class.
        /// </summary>
        public NewPositionPurchaseForm()
            {
            InitializeComponent();
            }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewPositionPurchaseForm"/> class.
        /// </summary>
        /// <param name="accountName">Name of the account.</param>
        public NewPositionPurchaseForm(string accountName)
            {
            this.accountName = accountName;
            InitializeComponent();
            }

        private void NewPositionPurchaseForm_Load(object sender, EventArgs e)
            {

            }

        private void getCurrentPrice_button_Click_1(object sender, EventArgs e)
            {
            string symbol = this.symbol_textBox.Text;//Process and verify

            //Retrieve stock information
            StockInfoProvider sip = new StockInfoProvider();
            try
                {
                this.Cursor = Cursors.WaitCursor;
                this.StockInformation = sip.GetStockInformation(symbol.ToUpper());//Move processing to separate method
                this.Cursor = Cursors.Default;
                }
            //A custom exception is thrown, which alerts the user that an invalid stock symbol was entered (if 'try' fails)
            catch (Exception ex)
                {
                this.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
                return; 
                }

            //If no exception thrown, update text in text-box
            this.buyPrice_textBox.Text = this.StockInformation.CurrentMarketPrice.ToString("N2");
            }

        private void buy_button_Click(object sender, EventArgs e)
            {
            try
                {
                this.PositionBuyParams = new PositionBuyParameters(this.symbol_textBox.Text.ToUpper(), 
                                                                   Int32.Parse(this.numToBuy_textBox.Text), 
                                                                   Double.Parse(this.buyPrice_textBox.Text), 
                                                                   DateTime.Now, 
                                                                   this.accountName);
                if (!this.getConfirmation())
                    {
                    this.PositionBuyParams = null;
                    return;
                    }
                this.DialogResult = DialogResult.OK;
                this.Close();
                }
            catch (FormatException)
                {
                MessageBox.Show("Please Enter Valid Input");
                }
            catch (Exception ex)
                {
                MessageBox.Show("Error: " + ex.Message);
                }
            }

        /// <summary>
        /// Gets the confirmation for stock purchase from user
        /// </summary>
        /// <returns>boolean (flag)</returns>
        private bool getConfirmation()
            {
            // Checks the value of the text.
            if (true)
                {
                // Initializes the variables to pass to the MessageBox.Show() method.
                StockInfoProvider sip = new StockInfoProvider();
                try
                    {
                    this.Cursor = Cursors.WaitCursor;
                    this.StockInformation = sip.GetStockInformation(this.symbol_textBox.Text.ToUpper());
                    this.Cursor = Cursors.Default;
                    }

                catch (Exception ex)
                    {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                    }

                string message = ("Confirm Purchase of " + (this.PositionBuyParams.Quantity) + " shares of " + (this.StockInformation.Symbol)  + " (" + (this.StockInformation.ShortName) + ")?");
                string caption = "Confirmation";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                    return true;
                    }
                else
                    {
                    return false;
                    }
                }
            }

        private void cancel_button_Click(object sender, EventArgs e)
            {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            }

        private void details_groupBox_Enter(object sender, EventArgs e)
            {

            }

        private void addPosition_label_Click(object sender, EventArgs e)
            {

            }

        private string accountName;
        }
    }
