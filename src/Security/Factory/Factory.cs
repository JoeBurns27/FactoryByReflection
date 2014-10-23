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
    public class Factory : BaseFactory 
    {
        public ISecurityManager GetSecurityManager(string securityManageName)
        {
            ISecurityManager secMan;
            secMan = (ISecurityManager)CreateObject(securityManageName, GetType());
            if (secMan == null)
                throw new Jebur27.FactoryBase.Exceptions.TypeNotFoundFactoryException(securityManageName);
            return secMan;
        }

    }
}
