using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace IA_Implementation_1
    {
    /// <inheritdoc/>
    public class Database : IDatabase
        {
        /// <summary>
        /// The separator between elements in string representation of the symbol-price map
        /// </summary>
        private const string SEP = ",";

        /// <summary>
        /// The file name where the symbol-to-price matcher is stored
        /// </summary>
        private const string symbToPriceFileName = "ProgramFile__StockInformation.txt";

        /// <summary>
        /// The account file extension (.stlab)
        /// </summary>
        private const string ACCOUNT_FILE_EXTENSION = ".stlab";

        /// <summary>
        /// The accounts
        /// </summary>
        private List<Account> accounts;

        /// <summary>
        /// The program directory
        /// </summary>
        private string directory;

        /// <summary>
        /// The symbol to price map (maps unique symbols, owned by user, to respective prices)
        /// </summary>
        private Dictionary<string, double> symbolToPriceMap;

        private string symbolToPriceMapFilePath
            {
            get { return Path.Combine(this.directory, symbToPriceFileName); }
            }
        //private HashSet<StockInfo> stocks;
        //private HashSet<string> symbols;

        /// <summary>
        /// Initializes a new instance of the <see cref="Database"/> class.
        /// </summary>
        /// <param name="directory">The directory.</param>
        public Database(string directory)
            {
            this.accounts = new List<Account>();
            this.symbolToPriceMap = new Dictionary<string, double>();
            this.directory = directory;
            }

        /// <summary>
        /// Initializes a new instance of the <see cref="Database"/> class.
        /// </summary>
        public Database()
            {
            //Initialize storage
            this.accounts = new List<Account>();
            this.symbolToPriceMap = new Dictionary<string, double>();
            }

        /// <summary>
        /// Opens path to file where application data is stored, and initializes everything necessary for communication with application
        /// </summary>
        public static Database Open(string directory)
            {
            Database database = new Database(directory);

            //Populate list of accounts from memory (create copy for use by application during runtime)
            database.Read();
            return database;
            }

        /// <inheritdoc/>
        public void Save()
            {
            this.Write();
            }

        /// <summary>
        /// Creates the Database in memory
        /// </summary>
        /// <param name="directory">The directory in which to store the database.</param>
        /// <returns></returns>
        public static Database Create(string directory)
            {
            Database database = new Database(directory);
            database.Write();
            return database;
            }

        /// <summary>
        /// Reads the serialized databse from memory and populates the run-time instance
        /// </summary>
        private void Read()
            {
            //Retrieve accounts from file
            this.retrieveAccounts();

            //Retrieve Symbol to Price Map from file
            this.retrieveSymbolToPriceMap();
            }

        private void retrieveSymbolToPriceMap()
            {
            //Clear the dictionary before updating it
            this.symbolToPriceMap.Clear();
            double price = 0;

            //Check if file exists; if not, create it
            if (!Directory.GetFiles(this.directory).Contains(this.symbolToPriceMapFilePath))
                {
                File.WriteAllText(this.symbolToPriceMapFilePath, string.Empty);
                }

            //Gather string input from file
            string[] info = File.ReadAllLines(this.symbolToPriceMapFilePath);

            //Iteratively populate dictionary
            foreach (string line in info)
                {
                if (!line.Contains(SEP))
                    {
                    continue;
                    }
                string[] sep = line.Split(SEP.ToCharArray());
                if (!Double.TryParse(sep[1], out price))
                    {
                    throw new Exception("Symbol To Price Map File Error: Incorrect File Format");
                    }
                this.symbolToPriceMap.Add(sep[0], price);
                }
            }

        /// <summary>
        /// Writes the entire database to memory
        /// </summary>
        private void Write()
            {
            //Update each account
            foreach (Account a in this.accounts)
                {
                this.updateAccountFile(a);
                }

            //Write the stock symbol information (for each unique stock contained in database)
            string symbolPriceMap_string = string.Empty;
            foreach (string symbol in this.symbolToPriceMap.Keys)
                {
                symbolPriceMap_string = symbolPriceMap_string + symbol + SEP + this.symbolToPriceMap[symbol] + (Environment.NewLine);
                }
            File.WriteAllText(this.symbolToPriceMapFilePath, symbolPriceMap_string + Environment.NewLine);
            }

        /// <summary>
        /// Retrieves the accounts from memory (disc).
        /// </summary>
        private void retrieveAccounts()
            {
            //Initialize hash-set of symbols
            //stocks = new HashSet<StockInfo>();
            //symbols = new HashSet<string>();
            StockInfoProvider sip = new StockInfoProvider();

            //Populate list of accounts from memory (create copy for use by application during runtime)
            foreach (string accountFileName in Directory.GetFiles(this.directory))
                {
                if (!accountFileName.Contains(ACCOUNT_FILE_EXTENSION))
                    {
                    continue;
                    }
                Account a = GetAccountFromFile(accountFileName);
                this.accounts.Add(a);
                /*
                //Populate the collection of symbols (no duplicates)
                foreach(Position p in a.Positions)
                    {
                    //StockInfo si = sip.GetStockInformation(p.Symbol);
                    //this.stocks.Add(si);
                    this.symbols.Add(p.Symbol);
                    }

                //Gather stock information for each symbol
                foreach(string symbol in this.symbols)
                    {
                    StockInfo si = sip.GetStockInformation(symbol);
                    this.stocks.Add(si);
                    }*/
                }
            }

        /// <summary>
        /// Updates the prices in stock to symbol map.
        /// </summary>
        private void updatePrices()
            {

            }

        private Account GetAccountFromFile(string path)
            {
            Account a = new Account(Path.GetFileNameWithoutExtension(path));
            //Get information from file to populate portfolio *(consider moving to Portfolio class)*
            string[] info = File.ReadAllLines(path);
            Position pos = null;
            foreach (string p in info)
                {
                if (!p.Contains(','))
                    {
                    continue;
                    }
                pos = new Position(p);
                a.AddPosition(pos);
                //temp = p.Split(',');//Move these lines to sep. function 'GetPosition(arg1, arg2, arg3, arg4)'
                //pos = new Position(Guid.Parse(temp[0]), temp[1], Int32.Parse(temp[2]), Double.Parse(temp[3]));//*UPDATE THE GUID ARGUMENT*
                //pos.SetBuyDate(temp[4]);
                //a.AddPosition(pos);
                }
            return a;
            }

        /// <summary>
        /// Gets the account infos.
        /// </summary>
        /// <returns>a list of AccountInfo objects</returns>
        public List<AccountInfo> GetAccountInfos()
            {
            List<AccountInfo> ais = new List<AccountInfo>();
            foreach (Account a in this.accounts)
                {
                ais.Add(a.GetAccountInfo());
                }
            this.SortAccountInfos(ais);
            return ais;
            }

        /// <summary>
        /// Retrieves the real account corresponding with the respective AccountInfo object sent as parameter.
        /// </summary>
        /// <param name="ai">The AccountInfo object (account information).</param>
        /// <returns></returns>
        private Account retrieveRealAccount(AccountInfo ai)
            {
            foreach (Account a in this.accounts)
                {
                if (a.Name.Equals(ai.Name))
                    {
                    return a;
                    }
                }
            return null;
            }

        /// <summary>
        /// Retrieves the real account corresponding with the respective AccountInfo object sent as parameter.
        /// </summary>
        /// <param name="name">The Account's name.</param>
        /// <returns></returns>
        private Account retrieveRealAccount(string name)
            {
            foreach (Account a in this.accounts)
                {
                if (a.Name.Equals(name))
                    {
                    return a;
                    }
                }
            return null;
            }

        private Account OLDRetrieveRealAccount(AccountInfo ai)
            {
            return null;
            }

        /// <summary>
        /// Sorts the accounts alphabetically (by name).
        /// </summary>
        public void SortAccountInfos(List<AccountInfo> ais)
            {
            mergeSortAccountInfos(ais);
            }

        /// <summary>
        /// Gets the current (last updated) price of a stock.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        /// <returns></returns>
        public double GetLastUpdatedPrice(string symbol)
            {
            //Check if the symbol exists in symbol dictionary
            if (!this.symbolToPriceMap.ContainsKey(symbol))
                {
                //Retrieve stock information
                StockInfoProvider sip = new StockInfoProvider();
                StockInfo si = sip.GetStockInformation(symbol.ToUpper());//Move processing to separate method
                this.symbolToPriceMap.Add(si.Symbol, si.CurrentMarketPrice);
                this.Save();
                }

            //Return price corresponding to symbol
            return this.symbolToPriceMap[symbol];
            }

        /// <summary>
        /// Checks if a given account name has already been taken
        /// </summary>
        /// <param name="accountName">Name of the account.</param>
        /// <returns></returns>
        public bool IsExistingAccountName(string accountName)
            {
            foreach(Account a in this.accounts)
                {
                if (accountName.Equals(a.Name))
                    {
                    return true;
                    }
                }
            return false;
            }

        /// <summary>
        /// Determines whether [is valid account name] [the specified account name].
        /// </summary>
        /// <param name="accountName">Name of the account.</param>
        /// <returns>
        ///   <c>true</c> if [is valid account name] [the specified account name]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsValidAccountName(string accountName)
            {
            return (this.IsExistingAccountName(accountName) && (accountName.Equals(this.symbolToPriceMapFilePath.Replace(".txt", ""))));
            }

        /// <summary>
        /// merge-sorts a collection of accounts
        /// </summary>
        /// <param name="a">the list of accounts.</param>
        private static void mergeSortAccounts(List<Account> a)
            {
            if (a.Count >= 2)
                {
                List<Account> left = new List<Account>();
                List<Account> right = new List<Account>();

                for (int i = 0; i < a.Count / 2; i++)
                    {
                    left.Add(a[i]);
                    }
                for (int i = 0; i < (a.Count - a.Count / 2); i++)
                    {
                    right.Add(a[i + a.Count / 2]);
                    }

                mergeSortAccounts(left);
                mergeSortAccounts(right);

                merge(a, left, right);
                }
            }

        /// <summary>
        /// merge-sorts a collection of accounts
        /// </summary>
        /// <param name="a">the list of accounts.</param>
        public static void mergeSortAccountInfos(List<AccountInfo> a)
            {
            if (a.Count >= 2)
                {
                List<AccountInfo> left = new List<AccountInfo>();
                List<AccountInfo> right = new List<AccountInfo>();

                for (int i = 0; i < a.Count / 2; i++)
                    {
                    left.Add(a[i]);
                    }
                for (int i = 0; i < (a.Count - a.Count / 2); i++)
                    {
                    right.Add(a[i + a.Count / 2]);
                    }

                mergeSortAccountInfos(left);
                mergeSortAccountInfos(right);

                mergeAccountInfo(a, left, right);
                }
            }

        /// <summary>
        /// Used by merge-sort (performs comparison for base case)
        /// </summary>
        /// <param name="result">The result.</param>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        public static void merge(List<Account> result, List<Account> left, List<Account> right)
            {
            int ind1 = 0;
            int ind2 = 0;
            for (int i = 0; i < result.Count; i++)
                {
                if (ind2 >= right.Count || (ind1 < left.Count && left[ind1].Name.CompareTo(right[ind2].Name) < 0))
                    {
                    result[i] = left[ind1];
                    ind1++;
                    }
                else
                    {
                    result[i] = right[ind2];
                    ind2++;
                    }
                }
            }

        /// <summary>
        /// Used by merge-sort (performs comparison for base case)
        /// </summary>
        /// <param name="result">The result.</param>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        public static void mergeAccountInfo(List<AccountInfo> result, List<AccountInfo> left, List<AccountInfo> right)
            {
            int ind1 = 0;
            int ind2 = 0;
            for (int i = 0; i < result.Count; i++)
                {
                if (ind2 >= right.Count || (ind1 < left.Count && left[ind1].Name.CompareTo(right[ind2].Name) < 0))
                    {
                    result[i] = left[ind1];
                    ind1++;
                    }
                else
                    {
                    result[i] = right[ind2];
                    ind2++;
                    }
                }
            }

        /// <summary>
        /// Creates a real account with same identifier as the AccountInfo object sent as parameter (creates real mirror corresponding to Data View Object)
        /// </summary>
        /// <param name="ai">The account information.</param>
        /// <returns></returns>
        private Account CreateRealAccount(AccountInfo ai)
            {
            return new Account(ai.Name);
            }

        /// <summary>
        /// Gets the positions of a given account.
        /// </summary>
        /// <param name="ai">The account information.</param>
        /// <returns></returns>
        public List<PositionInfo> GetPositions(AccountInfo ai)//Return PositionInfos
            {
            //return this.RetrieveRealAccount(ai).Positions;
            List<PositionInfo> result = new List<PositionInfo>();
            foreach (Position p in this.retrieveRealAccount(ai).GetPositions())
                {
                result.Add(new PositionInfo(p));
                }
            return result;
            }

        /// <summary>
        /// Gets the held positions.
        /// </summary>
        /// <param name="ai">The account information.</param>
        /// <returns></returns>
        public List<PositionInfo> GetHeldPositions(AccountInfo ai)
            {
            //return this.RetrieveRealAccount(ai).Positions;
            List<PositionInfo> result = new List<PositionInfo>();
            foreach (Position p in this.retrieveRealAccount(ai).HeldPositions)
                {
                result.Add(new PositionInfo(p));
                }
            return result;
            }

        /// <summary>
        /// Gets the sold positions.
        /// </summary>
        /// <param name="ai">The account information.</param>
        /// <returns></returns>
        public List<PositionInfo> GetSoldPositions(AccountInfo ai)
            {
            //return this.RetrieveRealAccount(ai).Positions;
            List<PositionInfo> result = new List<PositionInfo>();
            foreach (Position p in this.retrieveRealAccount(ai).SoldPositions)
                {
                Account a = this.retrieveRealAccount(ai);
                result.Add(new PositionInfo(p));
                }
            return result;
            }

        /// <summary>
        /// Sells the position.
        /// </summary>
        /// <param name="ai">The ai.</param>
        /// <param name="pi">The pi.</param>
        /// <param name="toSell">To sell.</param>
        /// <param name="sellPrice">The sell price.</param>
        public void SellPosition(AccountInfo ai, PositionInfo pi, int toSell, double sellPrice)
            {
            //Get account, get real position and sell position
            Account a = retrieveRealAccount(ai);
            Position p = retrieveRealPosition(pi, ai);
            p.SellStocks(toSell, sellPrice, DateTime.Now);

            //Update memory
            this.updateAccountFile(a);
            }

        /// <summary>
        /// Sells the position.
        /// </summary>
        /// <param name="ai">The ai.</param>
        /// <param name="piId">The pi identifier.</param>
        /// <param name="toSell">To sell.</param>
        /// <param name="sellPrice">The sell price.</param>
        public void SellPosition(AccountInfo ai, Guid piId, int toSell, double sellPrice)
            {
            //Get account, get real position and sell position
            Account a = retrieveRealAccount(ai);
            Position p = retrieveRealPosition(piId, ai);
            Position sold = p.SellStocks(toSell, sellPrice, DateTime.Now);
            if (sold != null)//If the entire position is sold, then no 'sold' position is returned; the same position is switched to a status of 'sold'
                {
                a.AddPosition(sold);
                }

            //Update memory
            this.updateAccountFile(a);
            }

        /// <summary>
        /// Adds the position to the given account.
        /// </summary>
        /// <param name="ai">The account information.</param>
        /// <param name="po">The position information.</param>
        public void AddPosition(AccountInfo ai, PositionInfo po)
            {
            //Add position to account
            Account a = this.retrieveRealAccount(ai);
            Position p = new Position(po);
            a.AddPosition(p);

            //Save database
            this.Save();
            }

        /// <summary>
        /// Adds the position.
        /// </summary>
        /// <param name="pbp">The PBP.</param>
        public void AddPosition(PositionBuyParameters pbp)
            {
            //Add position to account
            PositionInfo pi = new PositionInfo(pbp);
            AccountInfo ai = new AccountInfo(pbp.AccountName);
            this.AddPosition(ai, pi);
            }

        /// <summary>
        /// Updates the account file.
        /// </summary>
        /// <param name="a">The acount.</param>
        private void updateAccountFile(Account a)
            {
            string path = Path.Combine(this.directory, a.Name + ".stlab");
            string accountString = string.Empty;

            //write position information to file. 
            foreach (Position p in a.GetPositions())
                {
                accountString = accountString + (p.ToString() + Environment.NewLine);
                }
            File.WriteAllText(path, accountString + Environment.NewLine);
            }

        /// <summary>
        /// Adds the account to the program folder and databse list of accounts (long-term memory and run-time memory, respectively).
        /// </summary>
        /// <param name="ai">The ai.</param>
        public void AddAccount(AccountInfo ai)
            {
            //Create account corresponding to information sent, and add to collection of accounts
            Account a = CreateRealAccount(ai);
            this.accounts.Add(a);

            //Save the database at the current moment
            this.Save();
            /*
            //Add account to folder
            string path = Path.Combine(this.directory, a.Name + ".stlab");
            string portfolioString = string.Empty;

            //write position information to file. 
            foreach (Position p in a.Positions)
                {
                portfolioString = portfolioString + (p.ToString() + Environment.NewLine);
                }
            File.WriteAllText(path, portfolioString + Environment.NewLine);*/
            }

        /// <summary>
        /// Refreshes the stock prices in symbol to price map (all references stock prices).
        /// </summary>
        public void RefreshStockPrices()
            {
            foreach (string symbol in this.symbolToPriceMap.Keys.ToList())
                {
                //Retrieve stock information
                StockInfoProvider sip = new StockInfoProvider();
                StockInfo si = sip.GetStockInformation(symbol.ToUpper());//Move processing to separate method
                this.symbolToPriceMap[symbol] = si.CurrentMarketPrice;
                }
            }

        /// <summary>
        /// Retrieves the real position.
        /// </summary>
        /// <param name="pi">The position information.</param>
        /// <param name="ai">The account information.</param>
        /// <returns></returns>
        private Position retrieveRealPosition(PositionInfo pi, AccountInfo ai)
            {
            foreach (Position p in this.retrieveRealAccount(ai).GetPositions())
                {
                if (p.ID.Equals(pi.ID))
                    {
                    return p;
                    }
                }
            return null;
            }

        /// <summary>
        /// Retrieves the real position.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="ai">The account information (in which the position is).</param>
        /// <returns></returns>
        private Position retrieveRealPosition(Guid id, AccountInfo ai)
            {
            foreach (Position p in this.retrieveRealAccount(ai).GetPositions())
                {
                if (p.ID.Equals(id))
                    {
                    return p;
                    }
                }
            return null;
            }

        /// <inheritdoc/>
        public void DeletePosition(Guid id, AccountInfo ai)
            {
            //Remove position from account
            Account a = this.retrieveRealAccount(ai);
            a.PositionList.Remove(id);

            //Save changes to disk
            this.Save();
            }

        /// <summary>
        /// Gets the position information.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="ai">The account information (in which the position is).</param>
        /// <returns>The Position</returns>
        public PositionInfo GetPosition(Guid id, AccountInfo ai)
            {
            foreach (Position p in this.retrieveRealAccount(ai).GetPositions())
                {
                if (p.ID.Equals(id))
                    {
                    return new PositionInfo(p);
                    }
                }
            return null;
            }
        }
    }
