using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jebur27.Security.Interfaces;

namespace Jebur27.Security
{
    public class SecurityManagerOne : ISecurityManager
    {
        string _userName;
        int _userSecurityLevel;

        public int UserSecurityLevel
        {
            get { return _userSecurityLevel; }
            set { _userSecurityLevel = value; }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public SecurityManagerOne()
        {
        }

        public SecurityManagerOne(string userName)
            : this()
        {
            _userName = userName;
        }

        public SecurityManagerOne(string userName, int userSecurityLevel)
            : this()
        {
            _userName = userName;
            _userSecurityLevel = userSecurityLevel;
        }

    }
}
