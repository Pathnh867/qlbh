using QLBH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH
{
    class Utility
    {
        public static string Username = "";
        public static Employee? Employee { get; set; }

        public static bool IsOpeningForm(string formname)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == formname)
                    return true;
            }
            return false;
        }
    }
}
