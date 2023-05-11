using System;

namespace IA_Implementation_1
    {
    /// <summary>
    /// Represents a Position that can be bought and sold by the user
    /// </summary>
    public class Position
        {
        /// <summary>
        /// Gets the stock symbol.
        /// </summary>
        /// <value>
        /// The symbol.
        /// </value>
        public string Symbol
            {
            get { return this.symbol; }
            }
        /// <summary>
        /// Gets the quantity of stocks in position.
        /// </summary>
        /// <value>
        /// The quantity.
        /// </value>
        public int Quantity
            {
            get { return this.quantity; }
            }
        /// <summary>
        /// Gets the per-share buy price of the stocks.
        /// </summary>
        /// <value>
        /// The buy price.
        /// </value>
        public double BuyPrice
            {
            get { return this.buyPrice; }
            }
        /// <summary>
        /// Gets the date of purchase.
        /// </summary>
        /// <value>
        /// The buy date.
        /// </value>
        public DateTime BuyDate
            {
            get { return this.buyDate; }
            }
        /// <summary>
        /// Gets the date of sale.
        /// </summary>
        /// <value>
        /// The sell date.
        /// </value>
        public DateTime SellDate
            {
            get { return this.sellDate; }
            }
        /// <summary>
        /// Gets the per-share sale price of the stocks.
        /// </summary>
        /// <value>
        /// The sell price.
        /// </value>
        public double SellPrice
            {
            get { return this.sellPrice; }
            }
        /// <summary>
        /// Gets a value indicating whether this position is sold.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is sold; otherwise, <c>false</c>.
        /// </value>
        public bool IsSold
            {
            get
                {
                if (this.sellPrice == 0)
                    {
                    return false;
                    }
                return true;
                }
                //return false ? this.sellPrice == 0 : true; }
            }

        /// <summary>
        /// Gets the last updated price.
        /// </summary>
        /// <value>
        /// The last updated price.
        /// </value>
        public double LastUpdatedPrice
            {
            get { return Program.TheDatabase.GetLastUpdatedPrice(this.symbol); }
            }

        /// <summary>
        /// The identifier of the position
        /// </summary>
        public Guid ID { get; private set; }

        /// <summary>
        /// The separator between elements in string representation of position
        /// </summary>
        private const string SEP = ",";

        /// <summary>
        /// The sell date
        /// </summary>
        private DateTime sellDate;

        /// <summary>
        /// The sell price
        /// </summary>
        private double sellPrice;

        /// <summary>
        /// The stock symbol for this position
        /// </summary>
        private string symbol;

        /// <summary>
        /// The number of stocks in the position (each stock is of same type)
        /// </summary>
        private int quantity;

        /// <summary>
        /// The price at which the stocks were bought (per share)
        /// </summary>
        private double buyPrice;

        /// <summary>
        /// The buy date
        /// </summary>
        private DateTime buyDate;

        /// <summary>
        /// Event for when the number of stocks in the portfolio reaches 0 after a given number of stocks have been sold
        /// </summary>
        public EventHandler NumberOfStocksReachedZero;

        /// <summary>
        /// Initializes a new instance of the <see cref="Position"/> class.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <param name="symbol">The symbol.</param>
        /// <param name="quantity">The quantity.</param>
        /// <param name="buyPrice">The buy price.</param>
        /// <param name="buyDate">The buy date.</param>
        public Position(Guid ID, string symbol, int quantity, double buyPrice, DateTime? buyDate = null)
            {
            this.symbol = symbol;
            this.quantity = quantity;
            this.buyPrice = buyPrice;
            this.buyDate = (buyDate == null) ? DateTime.Now : (DateTime)buyDate;//If null argument, assume current time
            this.ID = ID;
            }

        /// <summary>
        /// Initializes a new instance of the <see cref="Position"/> class.
        /// </summary>
        /// <param name="pi">The position information.</param>
        public Position(PositionInfo pi)
            {
            this.symbol = pi.Symbol;
            this.buyDate = pi.BuyDate;
            this.quantity = pi.Quantity;
            this.buyPrice = pi.BuyPrice;
            this.ID = Guid.NewGuid();
            }

        /// <summary>
        /// Initializes a new instance of the <see cref="Position"/> class.
        /// </summary>
        /// <param name="pbp">The Position Buy Parameters.</param>
        public Position(PositionBuyParameters pbp)
            {
            this.symbol = pbp.Symbol;
            this.buyDate = pbp.BuyDate;
            this.quantity = pbp.Quantity;
            this.buyPrice = pbp.BuyPrice;
            this.ID = Guid.NewGuid();
            }

        /// <summary>
        /// Initializes a new instance of the <see cref="Position"/> class.
        /// </summary>
        /// <param name="positionString">The string representation of a Position.</param>
        public Position(string positionString)//Format: GUID,SYMBOL,NUM_STOCKS,BUY_PRICE,BUY_DATE,SELL_PRICE,SELL_DATE
            {
            string[] splitPos = positionString.Split(',');//Get indexed array of different string elements

            //Populate local fields (properties)
            this.ID = (Guid.Parse(splitPos[0]));
            this.symbol = splitPos[1];
            this.quantity = Int32.Parse(splitPos[2]);
            this.buyPrice = Double.Parse(splitPos[3]);
            this.buyDate = DateTime.Parse(splitPos[4]);

            //If the position has been sold, these values will get set; otherwise they will recieve default values
            this.sellPrice = Double.Parse(splitPos[5]);
            this.sellDate = DateTime.Parse(splitPos[6]);
            }

        /// <summary>
        /// Gets the total value.
        /// </summary>
        /// <returns></returns>
        public double GetTotalValue()
            {
            //Return the current price of each stock, multiplied by the number of stocks in the position
            return this.GetPricePerStock() * this.quantity;
            }

        /// <summary>
        /// Gets the current price per stock.
        /// </summary>
        /// <returns>the price</returns>
        public double GetPricePerStock()
            {
            //*STUB*
            //Retrieve current price from Yahoo Finance
            //...
            //neu*returns current price
            return this.buyPrice;
            }//OLD

        /// <summary>
        /// Sells the stocks, and returns value liquidated.
        /// </summary>
        /// <param name="num">The number of stocks to sell.</param>
        /// <returns>the value of the stocks sold</returns>
        public double OLD_SellStocks(int num)
            {
            if (num <= quantity)//Verify that the number of stocks being sold is less than or equal to the number of stocks in the position
                {
                //Subtract the number indicated from the stock count
                quantity -= num;

                //If the number of stocks in a position are 0, then the position might become invalid; an event is thus raised
                if (quantity == 0)
                    {
                    this.NumberOfStocksReachedZero(this, new EventArgs());
                    }

                //Return value of liquidation
                return GetPricePerStock() * num;
                }

            //If more stocks are being requested to be sold than exist in the position, return -1 to indicate an error
            return -1;
            }

        /// <summary>
        /// Sells a partial position (individual number of stocks)
        /// </summary>
        /// <param name="num">The number of stocks to sell.</param>
        /// /// <param name="sellDate">The date of sale.</param>
        /// /// <param name="sellPrice">The sale price.</param>
        /// <returns>the sold position split off from the original position</returns>
        public Position SellStocks(int num, double sellPrice, DateTime sellDate)
            {
            //Check to make sure a valid sale quantity; should not be more than the number of shares held in position
            if(this.quantity < num)
                {
                throw new Exception("Invalid sell amount: not enough stocks in position");
                }

            //If the quantity being sold is equal to the number held in the position, liquidate entire position
            if(this.quantity == num)
                {
                this.SellFullPosition(sellPrice, sellDate);
                return null;
                }

            this.quantity -= num;//Subtract the sold shares

            //Create a new position and populate it with sold shares
            PositionInfo pi = new PositionInfo(this.symbol, (num), this.buyPrice, this.buyDate);
            Position soldPosition = new Position(pi);
            soldPosition.SellFullPosition(sellPrice, sellDate);

            return soldPosition;//Return the sold position
            }

        /// <summary>
        /// Sells the entire position.
        /// </summary>
        /// <param name="sellPrice">The sell price.</param>
        /// <param name="sellDate">The sell date.</param>
        public void SellFullPosition(double sellPrice, DateTime sellDate)
            {
            this.sellDate = sellDate;
            this.sellPrice = sellPrice;
            }

        /// <summary>
        /// Gets the string representation of the position
        /// </summary>
        /// <returns>
        /// A string that represents this instance.
        /// </returns>
        public override string ToString()//ID, SYMBOL,NUMBER_BOUGHT,BUY_PRICE,BUY_DATE, SELL_PRICE,SELL_DATE
            {
            return (this.ID.ToString().ToLower() + SEP +
                this.symbol.ToString() + SEP +
                this.quantity.ToString() + SEP +
                this.buyPrice.ToString() + SEP +
                this.buyDate.ToString() + SEP + 
                this.sellPrice.ToString() + SEP +
                this.sellDate.ToString());
            }

        /// <summary>
        /// Sets the buy-date.
        /// </summary>
        /// <param name="date">The date (string representation).</param>
        public void SetBuyDate(string date)
            {
            this.buyDate = DateTime.Parse(date);
            }

        /// <summary>
        /// Sets the buy date.
        /// </summary>
        /// <param name="date">The date.</param>
        public void SetBuyDate(DateTime date)
            {
            this.buyDate = date;
            }
        }
    }
