using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Utils.Exceptions
{
    class FieldsNotFilledException : Exception
    {
        public FieldsNotFilledException() : base("Fields not filled")
        {

        }
        public FieldsNotFilledException(string message) : base(message)
        {

        }
    }
}
