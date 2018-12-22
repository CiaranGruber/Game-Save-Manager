using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCodes
{
    /// <summary>
    /// Contains program code for the Game Save Manager
    /// </summary>
    public class DisplayScreenCode
    {
        /// <summary>Contains all the games in the collection</summary>
        public List<Game> Games;
        /// <summary>The save location that is set whenever saving/loading saves</summary>
        public string SaveLocation;

        /// <summary>
        /// Intialises a new instance of a <c>DisplayScreenCode</c> object
        /// </summary>
        /// <param name="saveLocation">The save location for the display screen</param>
        /// <param name="load">Whether to load everything from the save location</param>
        public DisplayScreenCode(string saveLocation, bool load = true)
        {
            SaveLocation = saveLocation;
            if (load)
            {
                Load();
            }
        }

        /// <summary>Loads everything from the location saved</summary>
        public void Load()
        {
            Load(SaveLocation);
        }

        /// <summary>Loads everything from a save file in a specific location</summary>
        /// <param name="saveLocation">The location of the save</param>
        public void Load(string saveLocation)
        {
            if (!File.Exists(saveLocation))
            {
                File.WriteAllText(saveLocation, "");
            }
            Load(File.ReadAllLines(saveLocation));
        }

        /// <summary>
        /// Loads everything from a string array
        /// </summary>
        /// <param name="saveLines">The save lines using the ToString() method</param>
        public void Load(string[] saveLines)
        {
            Games = new List<Game>();

            // Separate games into individual lists of strings
            List<List<string>> games = new List<List<string>>();
            for (int i = 0; i < saveLines.Length; i++)
            {
                if (saveLines[i] == "--------------------------------")
                {
                    games.Add(new List<string>());
                }
                else
                {
                    games[games.Count - 1].Add(saveLines[i]);
                }
            }

            // Add each game into the Games list
            foreach (List<string> game in games)
            {
                Games.Add(new Game(game.ToArray()));
            }
        }

        /// <summary>Saves the save data in the preset location</summary>
        public void Save()
        {
            Save(SaveLocation);
        }

        /// <summary>Saves the save data in a specific location</summary>
        /// <param name="saveLocation">The location where the data is to be saved</param>
        public void Save(string saveLocation)
        {
            File.WriteAllLines(saveLocation, ToStringArray());
        }

        /// <summary>Gets the save data as a string array</summary>
        public string[] ToStringArray()
        {
            List<string> stringArray = new List<string>();
            foreach (Game game in Games)
            {
                stringArray.Add("--------------------------------");
                stringArray.AddRange(game.ToStringArray());
            }

            return stringArray.ToArray();
        }

        /// <summary>
        /// Adds a game to the games collection
        /// </summary>
        /// <param name="gameName">The name of the game</param>
        /// <param name="gameLink">The link to the game</param>
        /// <param name="save">Whether to save the list in the save location</param>
        public void AddGame(string gameName, string gameLink, bool save = true)
        {
            Games.Add(new Game(gameName, gameLink));
            if (save)
            {
                Save();
            }
        }

        /// <summary>
        /// Removes a game from the games collection
        /// </summary>
        /// <param name="gameName">The name of the game to remove</param>
        public void RemoveGame(string gameName, bool save = true)
        {
            Games.RemoveAt(Games.FindIndex(x => x.Name.ToLower() == gameName.ToLower()));
            if (save)
            {
                Save();
            }
        }
    }
}
