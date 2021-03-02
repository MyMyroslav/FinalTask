using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    [Serializable]
    class NotExistException : ApplicationException
    {

            public NotExistException() { }
            public NotExistException(string message) : base(message) { }
            
            public NotExistException(string message, System.Exception inner)
                : base(message, inner) { }
            protected NotExistException( System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
           
    }
}

