using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jebur27.Security;
using Jebur27.Security.Interfaces;
using Jebur27.FactoryBase;

namespace Jebur27.Security.Factory
{
    /// <summary>
    /// Security Manager Factory in a different Assembly than the Securtiy Manager classes
    /// </summary>
    public class Factory : BaseFactory 
    {
        /// <summary>
        /// Returns the named Security Manager if fould, else throws
        /// </summary>
        /// <param name="securityManageName">Fully qualified name of the Security Manager</param>
        /// <exception cref="Jebur27.FactoryBase.Exceptions.TypeNotFoundFactoryException">Thrown when named Type not found</exception>
        /// <returns>object of named type (ISecurityManager)</returns>
        public ISecurityManager GetSecurityManager(string securityManageName)
        {
            ISecurityManager securityManager = (ISecurityManager)CreateObject(securityManageName, GetType());
            if (securityManager == null)
                throw new Jebur27.FactoryBase.Exceptions.TypeNotFoundFactoryException(securityManageName);
            return securityManager;
        }

        /// <summary>
        /// Returns the named Security Manager if fould, else throws
        /// </summary>
        /// <param name="securityManageName">Fully qualified name of the Security Manager</param>
        /// <param name="userName">Constructor parameter</param>
        /// <exception cref="Jebur27.FactoryBase.Exceptions.TypeNotFoundFactoryException">Thrown when named Type not found</exception>
        /// <returns>object of named type (ISecurityManager)</returns>
        public ISecurityManager GetSecurityManager(string securityManageName, string userName)
        {
            object[] parms = new object[] { userName };

            ISecurityManager securityManager = (ISecurityManager)CreateObject(securityManageName, GetType(), parms);
            if (securityManager == null)
                throw new Jebur27.FactoryBase.Exceptions.TypeNotFoundFactoryException(securityManageName);
            return securityManager;
        }

        /// <summary>
        /// Returns the named Security Manager if fould, else throws
        /// </summary>
        /// <param name="securityManageName">Fully qualified name of the Security Manager</param>
        /// <param name="userName">Constructor parameter</param>
        /// <param name="userSecurityLevel">Constructor parameter</param>
        /// <exception cref="Jebur27.FactoryBase.Exceptions.TypeNotFoundFactoryException">Thrown when named Type not found</exception>
        /// <returns>object of named type (ISecurityManager)</returns>
        public ISecurityManager GetSecurityManager(string securityManageName, string userName, int userSecurityLevel)
        {
            object[] parms = new object[] { userName, userSecurityLevel };

            ISecurityManager securityManager = (ISecurityManager)CreateObject(securityManageName, GetType(), parms);
            if (securityManager == null)
                throw new Jebur27.FactoryBase.Exceptions.TypeNotFoundFactoryException(securityManageName);
            return securityManager;
        }

    }
}
