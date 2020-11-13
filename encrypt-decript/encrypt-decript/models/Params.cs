using System;
using System.Collections.Generic;
using System.Text;

namespace encrypt_decript.models
{
    class Params
    {
        String inputString;
        String outputString;
        String key;

        public string InputString { get => inputString; set => inputString = value; }
        public string OutputString { get => outputString; set => outputString = value; }
        public string Key { get => key; set => key = value; }
    }
}
