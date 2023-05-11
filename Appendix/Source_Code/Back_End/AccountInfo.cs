using System;

namespace IA_Implementation_1
    {
    /// <summary>
    /// Data Transfer Object: Contains the identifying information of an <see cref="Account"/>; 
    /// each instance mirrors a real instance of a <see cref="Account"/> object.
    /// </summary>
    public class AccountInfo
        {
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
        /// Initializes a new instance of the <see cref="AccountInfo"/> class.
        /// </summary>
        /// <param name="name">Name of the account.</param>
        public AccountInfo(string name)
            {
            this.Name = name;
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
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// The name of the account
        /// </returns>
        public override string ToString()
            {
            return this.Name;
            }
        }
    }
