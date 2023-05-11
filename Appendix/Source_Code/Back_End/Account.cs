using System;
using System.Collections.Generic;

namespace IA_Implementation_1
    {
    /// <summary>
    /// Contains functionality for an Account/Portfolio
    /// </summary>
    public class Account
        {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountInfo"/> class.
        /// </summary>
        /// <param name="name">Name of the account.</param>
        public Account(string name)
            {
            this.Name = name;
            this.PositionList = new PositionLinkedList();
            }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the name of the account.
        /// </summary>
        /// <value>
        /// The [user facing] name.
        /// </value>
        public string Name { get; private set; }

        /// <summary>
        /// The identifier (a guid)
        /// </summary>
        public Guid Identifier { get; private set; }

        /// <summary>
        /// Gets the collection of positions.
        /// </summary>
        /// <value>
        /// The position list.
        /// </value>
        public PositionLinkedList PositionList { get; private set; }

        /// <summary>
        /// Gets the sold positions.
        /// </summary>
        /// <value>
        /// The sold positions.
        /// </value>
        public List<Position> SoldPositions
            {
            get
                {
                List<Position> result = new List<Position>();
                Node<Position> cur = this.PositionList.Head;

                //Gather positions from linked list
                while (cur != null)
                    {
                    if (cur.Value.IsSold)
                        {
                        result.Add(cur.Value);
                        }
                    cur = cur.Next;
                    }
                return result;
                }
            }

        /// <summary>
        /// Gets the held positions.
        /// </summary>
        /// <value>
        /// The held positions.
        /// </value>
        public List<Position> HeldPositions
            {
            get
                {
                List<Position> result = new List<Position>();
                Node<Position> cur = this.PositionList.Head;

                //Gather positions from linked list
                while (cur != null)
                    {
                    if (!cur.Value.IsSold)
                        {
                        result.Add(cur.Value);
                        }
                    cur = cur.Next;
                    }
                return result;
                }
            }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the positions (dynamic List representation).
        /// </summary>
        /// <returns>A List representation of the collection of positions</returns>
        public List<Position> GetPositions()
            {
            List<Position> result = new List<Position>();
            Node<Position> cur = this.PositionList.Head;

            //Gather positions from linked list
            while (cur != null)
                {
                result.Add(cur.Value);
                cur = cur.Next;
                }

            //Return resulting list
            return result;
            }

        /// <summary>
        /// Adds a position to the account.
        /// </summary>
        /// <param name="position">The position.</param>
        public void AddPosition(Position position)
            {
            this.PositionList.Add(position);
            }

        /// <summary>
        /// Determines whether the specified account is this account.
        /// </summary>
        /// <param name="ai">The account.</param>
        /// <returns>
        ///   <c>true</c> if the specified account is this account; otherwise, <c>false</c>.
        /// </returns>
        public bool IsAccount(AccountInfo ai)
            {
            if (ai.Identifier.Equals(this.Identifier))
                {
                return true;
                }
            return false;
            }

        /// <summary>
        /// Sets the name.
        /// </summary>
        /// <param name="n">The name.</param>
        public void SetName(string n)
            {
            this.Name = n;
            }

        /// <summary>
        /// Gets the account information (Data View Object) that represents this account.
        /// </summary>
        /// <returns>the AccountInfo</returns>
        public AccountInfo GetAccountInfo()
            {
            //Populate properties
            AccountInfo ai = new AccountInfo(this.Name);
            //ai.Positions = this.Positions;

            //Return info
            return ai;
            }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// The name of the account
        /// </returns>
        public override string ToString()
            {
            return this.Name;
            }

        #endregion
        }
    }
