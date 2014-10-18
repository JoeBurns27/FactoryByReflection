using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Jebur27.FactoryBase
{
    public class BaseFactory
    {
        public object CreateObject(string typeName, Type typeOfCaller)
        {
            Type namedType = GetNamedType(typeName, typeOfCaller);
            object o = null;
            if(namedType != null)
                o = Activator.CreateInstance(namedType);

            return o;
        }

        public object CreateObject(string typeName, Type typeOfCaller, object[] parms)
        {
            object o = null;
            Type namedType = GetNamedType(typeName, typeOfCaller);
            if (namedType != null)
                o = Activator.CreateInstance(namedType, parms);

            return o;
        }

        protected Type GetNamedType(string typeName, Type typeOfCaller)
        {
            Assembly assembly = Assembly.GetAssembly(typeOfCaller);
            Assembly answer = null;
            Type type = assembly.GetTypes().Where(t => t.FullName == typeName).FirstOrDefault();
            if (type == null)
            {
                List<AssemblyName> assemblyNames = assembly.GetReferencedAssemblies().ToList();
                foreach (var name in assemblyNames)
                {
                    answer = Assembly.Load(name);
                    type = answer.GetTypes().Where(t => t.FullName == typeName).FirstOrDefault();
                    if (type != null)
                        break;
                }
            }

            return type;
        }

    }
}
