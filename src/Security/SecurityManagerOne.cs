using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jebur27.Security.Interfaces;

namespace Jebur27.Security
{
    /// <summary>
    /// Class used for testing the Factory
    /// </summary>
    public class SecurityManagerOne : ISecurityManager
    {
        string _userName;
        int _userSecurityLevel;

        /// <summary>
        /// User's Security Level
        /// </summary>
        public int UserSecurityLevel
        {
            get { return _userSecurityLevel; }
            set { _userSecurityLevel = value; }
        }

        /// <summary>
        /// User Nmae
        /// </summary>
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public SecurityManagerOne()
        {
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="userName">User Name</param>
        public SecurityManagerOne(string userName)
            : this()
        {
            _userName = userName;
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="userName">User Name</param>
        /// <param name="userSecurityLevel">User's Security Level</param>
        public SecurityManagerOne(string userName, int userSecurityLevel)
            : this()
        {
            _userName = userName;
            _userSecurityLevel = userSecurityLevel;
        }

    }
}
