using System;
using System.Net;
using System.Threading;

namespace IA_Implementation_1
    {
    internal class StockInfoProvider
        {
        private const string YAHOO_URL = "https://finance.yahoo.com/quote/**?ltr=1";
        public StockInfo GetStockInformation(string symbol)
            {
            //Process symbol info
            symbol = symbol.ToUpper();

            //Get html text from source of website
            string html = getHtml(symbol);

            //Return the stock information corresponding to given symbol
            return extractStockInfo(html, symbol);
            }

        /// <summary>
        /// Gets the HTML.
        /// </summary>
        /// <param name="symbol">The stock symbol.</param>
        /// <returns>The HTML</returns>
        private string getHtml(string symbol)
            {
            try
                {
                Thread.Sleep(500);
                WebClient wc = new WebClient();
                return wc.DownloadString(YAHOO_URL.Replace("**", symbol));
                }
            catch
                {
                throw new Exception("Unable to retrieve stock information. Please check your internet connection and try again.");
                }
            }

        /// <summary>
        /// Gets the populated Stock Information.
        /// </summary>
        /// <param name="html">The text from the HTML source page</param>
        /// <param name="stockSymbol">The stock symbol</param>
        /// <returns>The StockInfo object</returns>
        private StockInfo extractStockInfo(string html, string stockSymbol)
            {
            StockInfo stockInf = new StockInfo();

            //skip to start of "MarketTimeStore"
            string startSearch = "\"" + stockSymbol + "\":{";
            int startIndex = html.IndexOf(startSearch);
            int start;
            int end;
            string tag;
            if (startIndex != -1)
                {
                //Set symbol
                stockInf.Symbol = stockSymbol;

                //skip to start of "message"
                //Get Short Name
                tag = "\"shortName\":\"";
                start = html.IndexOf(tag, startIndex);
                end = html.IndexOf("\",", start + tag.Length);
                stockInf.ShortName = html.Substring(start + tag.Length, end - (start + tag.Length));

                //Get Stock  Currency
                tag = "\"currency\":\"";
                start = html.IndexOf(tag, startIndex);
                end = html.IndexOf("\",", start + tag.Length);
                stockInf.Currency = html.Substring(start + tag.Length, end - (start + tag.Length));

                //Get current market price
                tag = "\"regularMarketPrice\":{\"raw\":";
                start = html.IndexOf(tag, startIndex);
                end = html.IndexOf(",", start + tag.Length);
                string str = html.Substring(start + tag.Length, end - (start + tag.Length));
                stockInf.SetPrice(html.Substring(start + tag.Length, end - (start + tag.Length)));

                //Return pupulated StockInfo
                return stockInf;
                }
            //Could not extract market info
            throw new Exception("Invalid Stock Symbol");
            }
        }
    }
