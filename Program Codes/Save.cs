using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCodes
{
    /// <summary>
    /// Represents a Save
    /// </summary>
    public class Save
    {
        private readonly CultureInfo culture = new CultureInfo("en-gb");

        /// <summary>The title/name of the save</summary>
        public string Title;
        /// <summary>The date that the save was logged</summary>
        public DateTime Date;
        /// <summary>Whether the save is favourited or not</summary>
        public bool Favourited;
        /// <summary>The data that was saved</summary>
        public string SaveData;
        /// <summary>Any notes about the save (the description)</summary>
        public string[] Notes;

        /// <summary>
        /// Initialises a new <c>Save</c> instance from parameters
        /// </summary>
        /// <param name="date">The string version of the date when the save was logged</param>
        /// <param name="title">The title of the save</param>
        /// <param name="saveData">The data for the save</param>
        /// <param name="notes">The notes for the save</param>
        public Save(string date, string title, string saveData, bool favourited, string[] notes)
        {
            Date = Convert.ToDateTime(date, culture);
            Title = title;
            SaveData = saveData;
            Favourited = favourited;
            Notes = notes;
        }
        
        /// <summary>
        /// Initialises a new <c>Save</c> instance from a string array
        /// </summary>
        /// <param name="saveData">The save data as a string array</param>
        public Save(string[] saveData)
        {

        }

        /// <summary>
        /// Returns the <c>Save</c> as a string array
        /// </summary>
        public string[] ToStringArray()
        {
            List<string> stringArray = new List<string>() { Title, Date.ToString(culture), Favourited.ToString(), SaveData };
            stringArray.Concat(Notes);
            return stringArray.ToArray();
        }

        /// <summary>
        /// Gets the save as a string, primarily to help debugging
        /// </summary>
        /// <returns>The <c>Save</c> as a string</returns>
        public override string ToString()
        {
            string resultant = Title + ": " + Date.ToString(culture);
            if (Favourited)
            {
                resultant += " (favourite)";
            }
            return resultant;
        }

        public override bool Equals(object obj)
        {
            Save newSave = obj as Save;
            if (ReferenceEquals(newSave, null))
            {
                return false;
            }
            if (newSave.Title != Title || newSave.Date.ToString(culture) != Date.ToString(culture) || newSave.Favourited != Favourited || newSave.SaveData != SaveData || !ReferenceEquals(newSave.Notes, Notes))
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
