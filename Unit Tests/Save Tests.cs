using System;
using ProgramCodes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class SaveTests
    {
        public Save Save
        {
            get
            {
                return new Save("New Save", "02/08/2001 23:12:01", true, "sdjakldjsaldjaslkd - Save Data", new string[] { "Notes", "", " - Note 1", " - Note 2" });
            }
        }

        public string[] SaveArray =
            new string[]
            {
                "New Save",
                "02/08/2001 23:12:01",
                "True",
                "sdjakldjsaldjaslkd - Save Data",
                "Notes",
                "",
                " - Note 1",
                " - Note 2"
            };

        [TestMethod]
        public void Equals()
        {
            Assert.IsTrue(Save.Equals(Save), "Save did not return as equalling");
        }

        [TestMethod]
        public void Save_FromArray()
        {
            Save newSave = new Save(SaveArray);
            Assert.IsTrue(Save.Equals(newSave), "\n\nExpected:\n" + Save.ToString() + "\n\nActual:\n" + newSave.ToString() + "\n\nMessage:\nSave data did not initialise correctly from parameters");
        }

        [TestMethod]
        public void Save_Parameters()
        {
            Save newSave = new Save(SaveArray);
            Assert.IsTrue(Save.Equals(newSave), "\n\nExpected:\n" + Save.ToString() + "\n\nActual:\n" + newSave.ToString() + "\n\nMessage:\nSave data did not initialise correctly from parameters");
        }

        [TestMethod]
        public void ToStringArray()
        {
            Assert.IsTrue(SaveArray.SequenceEqual(Save.ToStringArray()), "Save Data string array was not formatted properly");
        }
    }
}
