using System;

namespace IA_Implementation_1
    {
    /// <summary>
    /// Data Transfer Object: Contains the identifying information of a <see cref="Position"/>; 
    /// each instance mirrors a real instance of a <see cref="Position"/> object.
    /// </summary>
    public class PositionInfo
        {
        /// <summary>
        /// The identifier of the position info
        /// </summary>
        public Guid ID { get; private set; }

        /// <summary>
        /// The stock symbol for this position
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// The number of stocks in the position (each stock is of same type)
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// The price at which the stocks were bought (per share)
        /// </summary>
        public double BuyPrice { get; set; }

        /// <summary>
        /// The buy date
        /// </summary>
        public DateTime BuyDate { get; set; }

        /// <summary>
        /// Gets the cost basis.
        /// </summary>
        /// <value>
        /// The cost basis.
        /// </value>
        public double CostBasis
            {
            get { return this.BuyPrice * this.Quantity; }
            }

        /// <summary>
        /// Gets the current value.
        /// </summary>
        /// <value>
        /// The current value.
        /// </value>
        public double CurrentValue { get; private set; }

        /// <summary>
        /// Gets the current price per share.
        /// </summary>
        /// <value>
        /// The current price.
        /// </value>
        public double CurrentPrice { get; private set; }

        /// <summary>
        /// Gets the date of sale.
        /// </summary>
        public DateTime SellDate { get; private set; }

        /// <summary>
        /// Gets the per-share sale price of the stocks.
        /// </summary>
        public double SellPrice { get; private set; }

        /// <summary>
        /// Gets the sale value.
        /// </summary>
        /// <value>
        /// The sell value.
        /// </value>
        public double SellValue
            {
            get { return this.SellPrice * this.Quantity; }
            }

        /// <summary>
        /// Initializes a new instance of the <see cref="PositionInfo"/> class.
        /// </summary>
        /// <param name="p">The p.</param>
        public PositionInfo(Position p)
            {
            this.BuyPrice = p.BuyPrice;
            this.Quantity = p.Quantity;
            this.Symbol = p.Symbol;
            this.ID = p.ID;
            this.BuyDate = p.BuyDate;
            this.SellDate = p.SellDate;
            this.SellPrice = p.SellPrice;

            this.CurrentPrice = p.LastUpdatedPrice;
            this.CurrentValue = this.CurrentPrice * this.Quantity;
            }

        /// <summary>
        /// Initializes a new instance of the <see cref="PositionInfo"/> class.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        /// <param name="quantity">The quantity.</param>
        /// <param name="buyPrice">The buy price.</param>
        /// <param name="buyDate">The buy date.</param>
        public PositionInfo(string symbol, int quantity, double buyPrice, DateTime buyDate)
            {
            this.BuyPrice = buyPrice;
            this.Quantity = quantity;
            this.Symbol = symbol;
            this.BuyDate = buyDate;
            this.ID = Guid.NewGuid();
            }

        /// <summary>
        /// Initializes a new instance of the <see cref="PositionInfo"/> class.
        /// </summary>
        /// <param name="pbp">The PBP.</param>
        public PositionInfo(PositionBuyParameters pbp)
            {
            this.Symbol = pbp.Symbol;
            this.BuyDate = pbp.BuyDate;
            this.Quantity = pbp.Quantity;
            this.BuyPrice = pbp.BuyPrice;
            this.ID = Guid.NewGuid();
            }
        }
    }
