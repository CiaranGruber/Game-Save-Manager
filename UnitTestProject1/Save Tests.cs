using System;
using ProgramCodes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class SaveTests
    {
        public Save Save
        {
            get
            {
                return new Save("1/1/0001 12:00:00 AM", "New Save", "sdjakldjsaldjaslkd - Save Data", true, new string[] { "Notes", "", " - Note 1", " - Note 2" });
            }
        }

        public string[] SaveArray =
            new string[]
            {
                "1/1/0001 12:00:00 AM",
                "New Save",
                "sdjakldjsaldjaslkd - Save Data",
                "True",
                "Notes",
                "",
                " - Note 1",
                " - Note 2"
            };

        [TestMethod]
        public void Save_FromArray()
        {
            Assert.IsTrue(Save.Equals(new Save(SaveArray)), "Save data did not initialise correctly from array");
        }

        [TestMethod]
        public void Save_Parameters()
        {
            Assert.IsTrue(Save.Equals(new Save(SaveArray)), "Save data did not initialise correctly from parameters");
        }

        [TestMethod]
        public void ToStringArray()
        {
            Assert.IsTrue(ReferenceEquals(Save.ToStringArray(), SaveArray), "Save Data string array was not formatted properly");
        }
    }
}
