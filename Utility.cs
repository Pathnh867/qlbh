using QLBH.Models;

namespace QLBH
{
    class Utility
    {
        public static string Username = "";
        public static Employee? Employee { get; set; }
        static public string ImagePath =
            Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\Images\";

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