using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    //атрибут Serializable - не успадковується від базового класу, ним ми створюєм власу серіалізацію.
    //1. ств конструктор серіалізації (protected)
    //2. дозволяєм базовому класу зберегти власний стан (info, context)
    [Serializable]
    class BusySeatException : ApplicationException
    {
        public BusySeatException() { }
        public BusySeatException(string message) : base(message) { }

        public BusySeatException(string message, System.Exception inner)
            : base(message, inner) { }
        protected BusySeatException(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context)
        : base(info, context) { }

    }
}
