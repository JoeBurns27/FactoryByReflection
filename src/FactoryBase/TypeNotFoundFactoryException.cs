using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jebur27.FactoryBase.Exceptions
{
    /// <summary>
    /// Exception class for the Jebur27.FactoryBase.Exceptions.TypeNotFoundFactoryException namespace.
    /// </summary>
    public class TypeNotFoundFactoryException : Exception
    {
        string typeName;

        public string TypeName
        {
            get { return typeName; }
            set { typeName = value; }
        }

        /// <summary>
        /// Creates a new instance of this type.
        /// </summary>
        public TypeNotFoundFactoryException(string typeName)
        {
            this.typeName = typeName;
        }

        /// <summary>
        /// Creates a new instance of this type.
        /// </summary>
        /// <param name="message">The message to include with this exception.</param>
        public TypeNotFoundFactoryException(string typeName, string message)
            : base(message)
        {
            this.typeName = typeName;
        }

        /// <summary>
        /// Creates a new instance of this type.
        /// </summary>
        /// <param name="message">The message to include with this exception.</param>
        /// <param name="inner"></param>
        public TypeNotFoundFactoryException(string typeName, string message, Exception inner)
            : base(message, inner)
        {
            this.typeName = typeName;
        }
    }

}
