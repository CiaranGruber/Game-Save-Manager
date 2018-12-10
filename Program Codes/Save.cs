using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCodes
{
    /// <summary>
    /// Represents a <c>Save</c> with a title, date, favourited status, save data and extra notes
    /// </summary>
    public class Save
    {
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

        /// <summary>The culture for the DateTime</summary>
        public readonly CultureInfo Culture = new CultureInfo("en-gb");

        /// <summary>
        /// Initialises a new <c>Save</c> instance from parameters
        /// </summary>
        /// <param name="title">The title of the save</param>
        /// <param name="date">The string version of the date when the save was logged</param>
        /// <param name="saveData">The data for the save</param>
        /// <param name="favourited">Whether the <c>Save</c> is favourited</param>
        /// <param name="notes">Any notes for the save</param>
        public Save(string title, string date, bool favourited, string saveData, string[] notes)
        {
            Title = title;
            Date = Convert.ToDateTime(date, Culture);
            Favourited = favourited;
            SaveData = saveData;
            Notes = notes;
        }
        
        /// <summary>
        /// Initialises a new <c>Save</c> instance from a string array
        /// </summary>
        /// <param name="saveData">The save data as a string array</param>
        public Save(string[] saveData)
        {
            List<string> newSaveData = saveData.ToList();

            // Set basic properties
            Title = saveData[0];
            Date = Convert.ToDateTime(saveData[1], Culture);
            Favourited = saveData[2].ToLower() == "true";
            SaveData = saveData[3];

            // Set notes to any remaining lines
            newSaveData = newSaveData.GetRange(4, newSaveData.Count - 4);
            Notes = newSaveData.ToArray();
        }

        /// <summary>
        /// Returns the <c>Save</c> as a string array
        /// </summary>
        public string[] ToStringArray()
        {
            return new string[] { Title, Date.ToString(Culture), Favourited.ToString(), SaveData }.Concat(Notes).ToArray();
        }

        /// <summary>
        /// Gets the save as a string, primarily to help debugging
        /// </summary>
        /// <returns>The <c>Save</c> as a string</returns>
        public override string ToString()
        {
            string resultant = Title + ": " + Date.ToString(Culture);
            if (Favourited)
            {
                resultant += " (favourite)";
            }
            return resultant;
        }
        
        /// <summary>Determines whether two <c>Save</c>s have equal values</summary>
        /// <param name="obj">The save that is being tested</param>
        /// <returns>Whether the two saves are equal</returns>
        public override bool Equals(object obj)
        {
            Save newSave = obj as Save;
            if (ReferenceEquals(newSave, null))
            {
                return false;
            }
            if (newSave.Title != Title || newSave.Date.ToString() != Date.ToString() || newSave.Favourited != Favourited || newSave.SaveData != SaveData || !newSave.Notes.SequenceEqual(Notes))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Gets the Hash Code of the <c>Save</c>
        /// </summary>
        /// <returns>The hash code</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Title.GetHashCode();
                hash = hash * 23 + Date.GetHashCode();
                hash = hash * 23 + Favourited.GetHashCode();
                hash = hash * 23 + SaveData.GetHashCode();
                hash = hash * 23 + Notes.GetHashCode();
                return hash;
            }
        }
    }
}
