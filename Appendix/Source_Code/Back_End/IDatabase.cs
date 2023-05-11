using System;
using System.Collections.Generic;

namespace IA_Implementation_1
    {
    /// <summary>
    /// A collection of database services (back-end to UI that connects UI with disk memory)
    /// </summary>
    public interface IDatabase
        {
        /// <summary>
        /// Saves this instance of the database to disk.
        /// </summary>
        void Save();

        /// <summary>
        /// Gets the account infos.
        /// </summary>
        /// <returns>a list of AccountInfo objects</returns>
        List<AccountInfo> GetAccountInfos();

        /// <summary>
        /// Sorts the accounts alphabetically (by name).
        /// </summary>
        void SortAccountInfos(List<AccountInfo> ais);

        /// <summary>
        /// Gets the positions of a given account.
        /// </summary>
        /// <param name="ai">The account information.</param>
        /// <returns></returns>
        List<PositionInfo> GetPositions(AccountInfo ai);

        /// <summary>
        /// Gets the held positions.
        /// </summary>
        /// <param name="ai">The account information.</param>
        /// <returns></returns>
        List<PositionInfo> GetHeldPositions(AccountInfo ai);

        /// <summary>
        /// Gets the sold positions.
        /// </summary>
        /// <param name="ai">The account information.</param>
        /// <returns></returns>
        List<PositionInfo> GetSoldPositions(AccountInfo ai);

        /// <summary>
        /// Gets the position information.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="ai">The account information (in which the position is).</param>
        /// <returns></returns>
        PositionInfo GetPosition(Guid id, AccountInfo ai);

        /// <summary>
        /// Sells the position.
        /// </summary>
        /// <param name="ai">The ai.</param>
        /// <param name="pi">The pi.</param>
        /// <param name="toSell">To sell.</param>
        /// <param name="sellPrice">The sell price.</param>
        void SellPosition(AccountInfo ai, PositionInfo pi, int toSell, double sellPrice);

        /// <summary>
        /// Sells the position.
        /// </summary>
        /// <param name="ai">The ai.</param>
        /// <param name="piId">The pi identifier.</param>
        /// <param name="toSell">To sell.</param>
        /// <param name="sellPrice">The sell price.</param>
        void SellPosition(AccountInfo ai, Guid piId, int toSell, double sellPrice);

        /// <summary>
        /// Adds the position to the given account.
        /// </summary>
        /// <param name="ai">The account information.</param>
        /// <param name="po">The position.</param>
        void AddPosition(AccountInfo ai, PositionInfo po);

        /// <summary>
        /// Adds the position.
        /// </summary>
        /// <param name="pbp">The PBP.</param>
        void AddPosition(PositionBuyParameters pbp);

        /// <summary>
        /// Adds the account to the program folder and database list of accounts (long-term and run-time memory).
        /// </summary>
        /// <param name="ai">The ai.</param>
        void AddAccount(AccountInfo ai);

        /// <summary>
        /// Refreshes the stock prices in symbol to price map (all references stock prices).
        /// </summary>
        void RefreshStockPrices();

        /// <summary>
        /// Deletes the position in the given account.
        /// </summary>
        /// <param name="ID">The position ID.</param>
        /// <param name="ai">The account information.</param>
        void DeletePosition(Guid ID, AccountInfo ai);
        }
    }
