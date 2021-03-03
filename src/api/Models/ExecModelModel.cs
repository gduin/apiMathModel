using System.Collections.Generic;

namespace Models
{
    public class ExecModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Interpreter { get; set; }

        public string ScriptFile { get; set; }

        public string Arg0 { get; set;}

        public string Arg1 { get; set;}

        public string Data1 { get; set; }
    }
}