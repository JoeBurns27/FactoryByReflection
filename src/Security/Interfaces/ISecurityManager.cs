using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jebur27.Security.Interfaces
{
    public interface ISecurityManager
    {
        string UserName { get; set; }
        int UserSecurityLevel { get; set; }
    }
}
