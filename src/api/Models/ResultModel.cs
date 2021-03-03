using System;
using System.Collections.Generic;

namespace Models
{
    public class ResultModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public TimeSpan timeExec { get; set; }

        public string Result { get; set; }

    }
}
