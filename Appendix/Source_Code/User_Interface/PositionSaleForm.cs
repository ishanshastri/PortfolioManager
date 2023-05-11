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
    /// Dialog displayed to perform a sale operation
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class PositionSaleForm : Form
        {
        /// <summary>
        /// Gets the stock information.
        /// </summary>
        /// <value>
        /// The stock information.
        /// </value>
        private StockInfo StockInformation;

        /// <summary>
        /// Gets the number to sell.
        /// </summary>
        /// <value>
        /// The number to sell.
        /// </value>
        public int NumberToSell
            {
            get { return this.numToSell; }
            private set { }
            }

        /// <summary>
        /// Gets the sale price.
        /// </summary>
        /// <value>
        /// The sale price.
        /// </value>
        public double SellPrice
            {
            get { return this.sellPrice; }
            private set { }
            }

        /// <summary>
        /// The number to sell
        /// </summary>
        private int numToSell;

        /// <summary>
        /// The sell price
        /// </summary>
        private double sellPrice;

        /// <summary>
        /// the position information (PositionInfo).
        /// </summary>
        /// <value>
        /// The position information.
        /// </value>
        private PositionInfo positionInfo;//old method to pass over just symbol

        /// <summary>
        /// Initializes a new instance of the <see cref="PositionSaleForm"/> class.
        /// </summary>
        /// <param name="pi">The position info.</param>
        public PositionSaleForm(PositionInfo pi)
            {
            InitializeComponent();
            setupFormDetails(pi);
            }

        private void getCurrentPrice_button_Click(object sender, EventArgs e)
            {
            string symbol = this.positionInfo.Symbol;//Process and verify

            //Retrieve stock information
            try
                {
                this.Cursor = Cursors.WaitCursor;
                StockInfoProvider sip = new StockInfoProvider();
                this.StockInformation = sip.GetStockInformation(symbol.ToUpper());//Move processing to separate method
                this.Cursor = Cursors.Default;
                this.sellPrice_textBox.Text = this.StockInformation.CurrentMarketPrice.ToString();
                }
            catch(Exception ex)
                {
                this.Cursor = Cursors.Default;
                MessageBox.Show("Error: " + ex.Message);
                }
            }

        /// <summary>
        /// Sets up the form details.
        /// </summary>
        private void setupFormDetails(PositionInfo pi)
            {
            //Initialize private variable
            this.positionInfo = pi;

            //Set appropriate values to each label
            this.symbol_label.Text = "Symbol: " + this.positionInfo.Symbol;
            this.totalNum_label.Text = "/" + this.positionInfo.Quantity.ToString();

            //Make these labels visible
            this.symbol_label.Visible = true;
            this.totalNum_label.Visible = true;
            }

        private void cancel_button_Click(object sender, EventArgs e)
            {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            }

        private void sell_button_Click(object sender, EventArgs e)
            {
            try
                {
                //Parse number of stocks to sell
                this.numToSell = Int32.Parse(this.numToSell_textBox.Text);
                
                //Verify that the number of stocks being sold is less or equal to total stocks
                if(this.numToSell > this.positionInfo.Quantity)
                    {
                    MessageBox.Show("A maximum of " + this.positionInfo.Quantity + " stock(s) can be sold");
                    return;
                    }

                //Continue parsing values
                this.sellPrice = Double.Parse(this.sellPrice_textBox.Text);
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
        }
    }
