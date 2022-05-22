using System;

namespace IA_Implementation_1
    {
    /// <summary>
    /// Class to store a stock's information
    /// </summary>
    internal class StockInfo
        {
        public double CurrentMarketPrice
            {
            get { return this.currentPrice; }
            }

        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        /// <value>
        /// The symbol.
        /// </value>
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or sets the short name.
        /// </summary>
        /// <value>
        /// The short name.
        /// </value>
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>
        /// The currency.
        /// </value>
        public string Currency { get; set; }//Make an enum

        /// <summary>
        /// The current price
        /// </summary>
        private double currentPrice;

        /// <summary>
        /// Initializes a new instance of the <see cref="StockInfo"/> class.
        /// </summary>
        public StockInfo()
            {

            }

        /// <summary>
        /// Sets the price.
        /// </summary>
        /// <param name="strInt">The price (string representation).</param>
        public void SetPrice(string strInt)
            {
            bool success = double.TryParse(strInt, out this.currentPrice);
            if (!success)
                {
                throw new Exception("Please send valid double value");
                }
            }

        /// <summary>
        /// Sets the price.
        /// </summary>
        /// <param name="price">The price.</param>
        public void SetPrice(int price)
            {
            this.currentPrice = price;
            }
        }
    }
