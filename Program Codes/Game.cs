using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCodes
{
    /// <summary>
    /// Represents a <c>Game</c> with saves, etc
    /// </summary>
    public class Game
    {
        /// <summary>The name of the game</summary>
        public string Name;
        /// <summary>The link to the game website</summary>
        public string Link;
        /// <summary>The list of saves. Should be sorted in date order</summary>
        public List<Save> Saves;
        
        /// <summary>
        /// Initialises an existing instance of a <c>Game</c> from parameters
        /// </summary>
        /// <param name="name">The name of the game</param>
        /// <param name="link">The link for the website</param>
        /// <param name="saves">The saves contained in the game</param>
        public Game(string name, string link, List<Save> saves)
        {
            Name = name;
            Link = link;
            Saves = saves;
        }

        /// <summary>
        /// Initialises a new instance of a <c>Game</c> from a set of parameters
        /// </summary>
        /// <param name="name">The name of the game</param>
        /// <param name="link">The link for the website</param>
        public Game(string name, string link)
        {
            Name = name;
            Link = link;
            Saves = new List<Save>();
        }

        /// <summary>
        /// Initialises a new instance of a <c>Game</c> from a string array
        /// </summary>
        /// <param name="stringArray">The game in the ToStringArray() format</param>
        public Game(string[] stringArray)
        {
            // Set basic properties
            Name = stringArray[0];
            Link = stringArray[1];
            Saves = new List<Save>();

            // Separate saves into individual lists of strings
            List<List<string>> saves = new List<List<string>>();
            for (int i = 2; i < stringArray.Length; i++)
            {
                if (stringArray[i] == "-------------")
                {
                    saves.Add(new List<string>());
                }
                else
                {
                    saves[saves.Count - 1].Add(stringArray[i]);
                }
            }

            // Add each save into the Save list and order result
            foreach (List<string> save in saves)
            {
                Saves.Add(new Save(save.ToArray()));
            }
            Saves = Saves.OrderBy(x => x.Date).ToList();
        }

        /// <summary>Gets the <c>Game</c> as a string array</summary>
        /// <returns>The <c>Game</c> as a string array</returns>
        public string[] ToStringArray()
        {
            List<string> gameData = new List<string>() { Name, Link };
            foreach (Save save in Saves)
            {
                gameData.Add("-------------");
                gameData.AddRange(save.ToStringArray());
            }
            return gameData.ToArray();
        }

        /// <summary>Adds a <c>Save</c> to the list of saves from a <c>Save</c> parameter</summary>
        /// <param name="save">The save to be added</param>
        public void AddSave(Save save)
        {
            Saves.Add(save);
            Saves = Saves.OrderBy(x => x.Date).ToList();
        }

        /// <summary>Adds a <c>Save</c> to the list of saves via parameters</summary>
        /// <param name="title">The title of the save</param>
        /// <param name="date">The string version of the date when the save was logged</param>
        /// <param name="saveData">The data for the save</param>
        /// <param name="favourited">Whether the <c>Save</c> is favourited</param>
        /// <param name="notes">Any notes for the save</param>
        public void AddSave(string title, string date, bool favourited, string saveData, string[] notes)
        {
            Saves.Add(new Save(title, date, favourited, saveData, notes));
            Saves = Saves.OrderByDescending(x => x.Date).ToList();
        }

        /// <summary>Adds a <c>Save</c> to the list of saves via a string array</summary>
        /// <param name="saveArray">The <c>Save</c> as an array</param>
        public void AddSave(string[] saveArray)
        {
            Saves.Add(new Save(saveArray));
            Saves = Saves.OrderBy(x => x.Date).ToList();
        }

        /// <summary>Edits a <c>Save</c> by replacing specific parameters</summary>
        /// <param name="date">The date of the save to be changed</param>
        /// <param name="newTitle">The new title of the save</param>
        /// <param name="newFavourited">Whether the new save will be a favourite</param>
        /// <param name="newSaveData">The new save data</param>
        /// <param name="newNotes">The new notes for the edited save</param>
        public void EditSave(string date, string newTitle, bool newFavourited, string newSaveData, string[] newNotes)
        {
            int index = Saves.FindIndex(x => x.Date.ToString(Save.Culture) == date);
            Saves[index].Title = newTitle;
            Saves[index].Favourited = newFavourited;
            Saves[index].SaveData = newSaveData;
            Saves[index].Notes = newNotes;
        }

        /// <summary>Change the favourited status of a save according to the date</summary>
        /// <param name="date">The date of the save</param>
        public void ChangeFavouriteStatus(string date)
        {
            int saveIndex = Saves.FindIndex(x => x.Date.ToString(Save.Culture) == date);
            Saves[saveIndex].Favourited = Saves[saveIndex].Favourited == false;
        }

        /// <summary>Removes a save according to the date</summary>
        /// <param name="date">The date of the save</param>
        public void RemoveSave(string date)
        {
            Saves.RemoveAt(Saves.FindIndex(x => x.Date.ToString(Save.Culture) == date));
        }

        /// <summary>
        /// Returns the <c>Game</c> as a readable string
        /// </summary>
        /// <returns>The <c>Game</c> as a readable string</returns>
        public override string ToString()
        {
            // Decides between plural or non-plural form of save
            if (Saves.Count == 1)
            {
                return Name + ": 1 save (" + Link + ")";
            }
            else
            {
                return Name + ": " + Saves.Count + " saves (" + Link + ")";
            }
        }

        /// <summary>
        /// Determines whether two <c>Game</c> instances are equal
        /// </summary>
        /// <param name="obj">The <c>Game</c> to be tested against</param>
        /// <returns>If the two instances are the same</returns>
        public override bool Equals(object obj)
        {
            Game game = obj as Game;
            if (ReferenceEquals(game, null))
            {
                return false;
            }
            
            // See if any basic properties are different
            if (game.Name != Name || game.Link != Link || game.Saves.Count != Saves.Count)
            {
                return false;
            }

            // Checks if any saves are different
            for (int i = 0; i < Saves.Count; i++)
            {
                if (!game.Saves[i].Equals(Saves[i]))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Gets the Hash Code of the <c>Game</c> instance
        /// </summary>
        /// <returns>The unchecked hash code of the <c>Game</c> instance</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Name.GetHashCode();
                hash = hash * 23 + Link.GetHashCode();
                hash = hash * 23 + Saves.GetHashCode();
                return hash;
            }
        }
    }
}
