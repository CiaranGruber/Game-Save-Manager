using ProgramCodes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSaveManager
{
    public static class NavigationClass
    {
        public static string FormSaveLocation = "./Next Form (Runtime data).txt";

        /// <summary>Finds the form that is to be opened next</summary>
        /// <returns>The form to be opened</returns>
        public static string[] GetNextForm()
        {
            return File.ReadAllLines(FormSaveLocation);
        }

        /// <summary>Saves the form in the navigation file</summary>
        /// <param name="formName">The form name to be opened</param>
        public static void SaveNextForm(string[] formNameAndData)
        {
            File.WriteAllLines(FormSaveLocation, formNameAndData);
        }
    }
}

