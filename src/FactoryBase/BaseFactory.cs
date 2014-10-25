using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Jebur27.FactoryBase
{
    /// <summary>
    /// Base class used to create specific Factories
    /// </summary>
    public class BaseFactory
    {
        /// <summary>
        /// Using Reflection, creates an object of Type typeName
        /// </summary>
        /// <param name="typeName">Fully qualified name of the Type to create</param>
        /// <param name="typeOfCaller">Used by GetNamedType method to find the type to create</param>
        /// <returns>If found, an object of the named Type, else null</returns>
        public object CreateObject(string typeName, Type typeOfCaller)
        {
            Type namedType = GetNamedType(typeName, typeOfCaller);
            object o = null;
            if(namedType != null)
                o = Activator.CreateInstance(namedType);

            return o;
        }

        /// <summary>
        /// Using Reflection, creates an object of Type typeName
        /// </summary>
        /// <param name="typeName">Fully qualified name of the Type to create</param>
        /// <param name="typeOfCaller">Used by GetNamedType method to find the type to create</param>
        /// <param name="parms">An Object array of constructor parameters</param>
        /// <returns>If found, an object of the named Type, else null</returns>
        public object CreateObject(string typeName, Type typeOfCaller, object[] parms)
        {
            object o = null;
            Type namedType = GetNamedType(typeName, typeOfCaller);
            if (namedType != null)
                o = Activator.CreateInstance(namedType, parms);

            return o;
        }

        /// <summary>
        /// Using Reflection, finds Type typeName
        /// </summary>
        /// <param name="typeName">Fully qualified name of the Type to create</param>
        /// <param name="typeOfCaller">Starting Type to find the type to create</param>
        /// <returns>Type if found, else null</returns>
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
