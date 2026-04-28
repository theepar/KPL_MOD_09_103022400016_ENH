using System;
using System.Collections.Generic;
using System.Text;

namespace KPL_MOD_09_103022400016_ENH
{
   public class config
    {
        public string lang { get; set; }
        public Transfer transfer { get; set; }
        public List<string> methods { get; set; }
        public Confirmation confirm { get; set; }

        public config(string lang, Transfer transfer, List<string> methods, Confirmation confirm)
        {
            this.lang = lang;
            this.transfer = transfer;
            this.methods = methods;
            this.confirm = confirm;
        }

        public config()
        {
        }
    }
}
