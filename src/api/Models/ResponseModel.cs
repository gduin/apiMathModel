using Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class ResponseModel<T>
    {
        public string Message { get; set; }

        public ResponseCodes Code { get; set; }

        public T Response { get; set; }
    }
}
