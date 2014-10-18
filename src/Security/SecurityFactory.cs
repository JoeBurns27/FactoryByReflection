﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jebur27.FactoryBase;
using Jebur27.Security;
using Jebur27.Security.Interfaces;

namespace Jebur27.Security.Factory
{
    public class SecurityFactory : BaseFactory
    {
        public ISecurityManager GetSecurityManager(string securityManageName)
        {
            ISecurityManager secMan = (ISecurityManager)CreateObject(securityManageName, GetType());
            if (secMan == null)
                throw new Jebur27.FactoryBase.Exceptions.TypeNotFoundFactoryException(securityManageName);
            return secMan;
        }
    }
}
