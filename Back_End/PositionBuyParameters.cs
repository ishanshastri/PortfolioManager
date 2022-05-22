using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_Implementation_1
    {
    /// <summary>
    /// Data Transfer Object: Holds the necessary information to make a position purchase request
    /// </summary>
    public class PositionBuyParameters
        {
        /// <summary>
        /// The stock symbol for this position
        /// </summary>
        public string Symbol { get; private set; }

        /// <summary>
        /// The number of stocks in the position (each stock is of same type)
        /// </summary>
        public int Quantity { get; private set; }

        /// <summary>
        /// The price at which the stocks were bought (per share)
        /// </summary>
        public double BuyPrice { get; private set; }

        /// <summary>
        /// The buy date
        /// </summary>
        public DateTime BuyDate { get; private set; }

        /// <summary>
        /// Gets the account identifier for the account to which the position is being added.
        /// </summary>
        /// <value>
        /// The account identifier.
        /// </value>
        public string AccountName { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PositionBuyParameters"/> class.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        /// <param name="quantity">The quantity.</param>
        /// <param name="buyPrice">The buy price.</param>
        /// <param name="buyDate">The buy date.</param>
        /// <param name="accountName">Name of the account where the position is being added.</param>
        public PositionBuyParameters(string symbol, int quantity, double buyPrice, DateTime buyDate, string accountName)
            {
            this.BuyPrice = buyPrice;
            this.Quantity = quantity;
            this.Symbol = symbol;
            this.BuyDate = buyDate;
            this.AccountName = accountName;
            }
        }
    }
