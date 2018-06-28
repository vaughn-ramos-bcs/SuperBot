using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperBot.Models
{
    [Serializable]
    public class Modules
    {
        //Will use when db will be applied
        //public List<string> modules { get; set; }

        //Hard coded for now
        public static List<string>  ModulesList()
        {
            return new List<string>() { "Onboard Me", "Äsk HR", "Contact IT", "File Leave", "Get Payslip", "Contact Graphic" };
        }
    }
}