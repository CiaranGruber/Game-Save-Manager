using System;
using ProgramCodes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class GameTests
    {        
        public Game Game
        {
            get
            {
                return new Game("New Game", "www.newGame.com", new List<Save> { new Save(SavesArray[0]), new Save(SavesArray[1]), new Save(SavesArray[2]) });
            }
        }

        public string[] GameArray = new string[]
        {
            "New Game",
            "www.newGame.com",
            "-------------",
            "Save 3",
            "02/08/2003 23:12:01",
            "True",
            "sdjakldjsaldjaslkd - Save Data",
            "Notes",
            "",
            " - Note 1",
            " - Note 2",
            "-------------",
            "Save 1",
            "02/08/2001 23:12:01",
            "False",
            "ffjweljadfwef - Save Data",
            "Notes",
            "",
            " - Note 1",
            " - Note 2",
            "-------------",
            "Save 2",
            "02/08/2002 23:12:01",
            "False",
            "fjdkflsjafdw - Save Data",
            "Notes",
            "",
            " - Note 1",
            " - Note 2"
        };

        public string[][] SavesArray = new string[][]
        {
            new string[]
            {
                "Save 3",
                "02/08/2003 23:12:01",
                "True",
                "sdjakldjsaldjaslkd - Save Data",
                "Notes",
                "",
                " - Note 1",
                " - Note 2"
            },
            new string[]
            {
                "Save 2",
                "02/08/2002 23:12:01",
                "False",
                "fjdkflsjafdw - Save Data",
                "Notes",
                "",
                " - Note 1",
                " - Note 2"
            },
            new string[]
            {
                "Save 1",
                "02/08/2001 23:12:01",
                "False",
                "ffjweljadfwef - Save Data",
                "Notes",
                "",
                " - Note 1",
                " - Note 2"
            }
        };

        [TestMethod]
        public void Equals()
        {
            Assert.IsTrue(Game.Equals(Game), "Equals() method does not work correctly");
        }

        [TestMethod]
        public void Game_Blank()
        {
            Game newGame = new Game("Gamey", "www.gamey.com");
            Assert.IsTrue(newGame.Saves.SequenceEqual(new List<Save>()), "Equals() method does not work correctly");
        }

        [TestMethod]
        public void Game_Parameters()
        {
            Assert.IsTrue(Game.Name == "New Game" && Game.Link == "www.newGame.com" && Game.Saves.SequenceEqual(new List<Save> { new Save(SavesArray[0]), new Save(SavesArray[1]), new Save(SavesArray[2]) }), "Equals() method does not work correctly");
        }

        [TestMethod]
        public void Game_FromArray()
        {
            Game newGame = new Game(GameArray);
            Assert.IsTrue(Game.Equals(newGame), "Game does not load correctly from an array");
        }

        [TestMethod]
        public void AddSave()
        {
            Game newGame = new Game(GameArray);
            string[] newSave = new string[]
            {
                "Save 4",
                "02/08/2004 23:12:01",
                "False",
                "32r9hfieuwhkdn - Save Data",
                "Notes",
                "",
                " - Note 1",
                " - Note 2"
            };
            newGame.AddSave(newSave);
            Assert.IsTrue(newGame.Saves.Find(x => x.Title == "Save 4").Equals(new Save(newSave)), "Game does not add save");
        }

        [TestMethod]
        public void EditSave()
        {
            Game newGame = new Game(GameArray);
            newGame.EditSave("02/08/2002 23:12:01", "Save 10", true, "fdkflsjfklasd - Save Data", new string[] { "These are notes" });
            Assert.IsTrue(newGame.Saves.Find(x => x.Date.ToString(x.Culture) == "02/08/2002 23:12:01").Equals(new Save("Save 10", "02/08/2002 23:12:01", true, "fdkflsjfklasd - Save Data", new string[] { "These are notes" })), "Save was not edited correctly");
        }

        [TestMethod]
        public void RemoveSave()
        {
            Game newGame = new Game(GameArray);
            newGame.RemoveSave("02/08/2002 23:12:01");
            try
            {
                newGame.Saves.Find(x => x.Date.ToString(x.Culture) == "02/08/2002 23:12:01");
                Assert.Fail("Game did not remove the save");
            }
            catch { }
        }
    }
}
