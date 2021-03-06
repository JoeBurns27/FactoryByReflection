﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jebur27.FactoryBase;
using Jebur27.Security;
using Jebur27.Security.Interfaces;

namespace Jebur27.Security.Factory
{
    /// <summary>
    /// Security Manager Factory within the same Assembly as the Securtiy Manager classes
    /// </summary>
    public class SecurityFactory : BaseFactory
    {
        /// <summary>
        /// Returns the named Security Manager if fould, else throws
        /// </summary>
        /// <param name="securityManagerName">Fully qualified name of the Security Manager</param>
        /// <exception cref="Jebur27.FactoryBase.Exceptions.TypeNotFoundFactoryException">Thrown when named Type not found</exception>
        /// <returns>object of named type (ISecurityManager)</returns>
        public ISecurityManager GetSecurityManager(string securityManagerName)
        {
            ISecurityManager securityManager = (ISecurityManager)CreateObject(securityManagerName, GetType());
            if (securityManager == null)
                throw new Jebur27.FactoryBase.Exceptions.TypeNotFoundFactoryException(securityManagerName);
            return securityManager;
        }

        /// <summary>
        /// Returns the named Security Manager if fould, else throws
        /// </summary>
        /// <param name="securityManagerName">Fully qualified name of the Security Manager</param>
        /// <param name="userName">Constructor parameter</param>
        /// <exception cref="Jebur27.FactoryBase.Exceptions.TypeNotFoundFactoryException">Thrown when named Type not found</exception>
        /// <returns>object of named type (ISecurityManager)</returns>
        public ISecurityManager GetSecurityManager(string securityManagerName, string userName)
        {
            object[] parms = new object[] { userName };

            ISecurityManager securityManager = (ISecurityManager)CreateObject(securityManagerName, GetType(), parms);
            if (securityManager == null)
                throw new Jebur27.FactoryBase.Exceptions.TypeNotFoundFactoryException(securityManagerName);
            return securityManager;
        }

        /// <summary>
        /// Returns the named Security Manager if fould, else throws
        /// </summary>
        /// <param name="securityManagerName">Fully qualified name of the Security Manager</param>
        /// <param name="userName">Constructor parameter</param>
        /// <param name="userSecurityLevel">Constructor parameter</param>
        /// <exception cref="Jebur27.FactoryBase.Exceptions.TypeNotFoundFactoryException">Thrown when named Type not found</exception>
        /// <returns>object of named type (ISecurityManager)</returns>
        public ISecurityManager GetSecurityManager(string securityManagerName, string userName, int userSecurityLevel)
        {
            object[] parms = new object[] { userName, userSecurityLevel };

            ISecurityManager securityManager = (ISecurityManager)CreateObject(securityManagerName, GetType(), parms);
            if (securityManager == null)
                throw new Jebur27.FactoryBase.Exceptions.TypeNotFoundFactoryException(securityManagerName);
            return securityManager;
        }

    }
}
