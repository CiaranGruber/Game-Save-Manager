using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProgramCodes;
using System.Threading.Tasks;
using System.Threading;

namespace Game_Save_Manager_Console_App
{
    class Program
    {
        public static DisplayScreenCode Screen = new DisplayScreenCode("./savefile.txt");
        
        /// <summary>
        /// The screen where games are added
        /// </summary>
        static void AddGameScreen()
        {
            int maxWidth;
            int menuOption = -1;

            Console.Title = "Game Save Manager - Created By Ciaran";

            while (menuOption != 3)
            {
                ConsoleUtils.PrepNewScreen("Game Save Manager");
                ShowGamesBox();

                if (Console.WindowWidth > 80)
                {
                    maxWidth = Console.WindowWidth - 60;
                }
                else
                {
                    maxWidth = 27;
                }

                // Show different menu if there are any games
                if (Screen.Games.Count > 0)
                {
                    // Create menu
                    ConsoleUtils.CreateMenu(new string[] { "Add Game", "Remove Game", "Back" }, "Main Menu:");
                    menuOption = ConsoleUtils.FancyGetInteger("Menu Option: ", "Menu choice must be an integer", "Default", 1, 3, new FormattedWriteSettings { NewLine = false, MaximumWidth = maxWidth }, maxCharLength: 1);
                }
                else
                {

                    // Create menu
                    ConsoleUtils.CreateMenu(new string[] { "Add Game", "Back" }, "Main Menu:");
                    menuOption = ConsoleUtils.FancyGetInteger("Menu Option: ", "Menu choice must be an integer", "Default", 1, 2, new FormattedWriteSettings { NewLine = false, MaximumWidth = maxWidth }, maxCharLength: 1);

                    // Set back option to 3 so it actually quits
                    if (menuOption == 2)
                    {
                        menuOption = 3;
                    }

                    // Add game
                    if (menuOption == 1)
                    {
                        string gameName;
                        string gameLink;

                        ConsoleUtils.FormattedWrite("Game name: ", new FormattedWriteSettings { NewLine = false, InnerPadding = new Padding(1, 4, 0) });
                        gameName = ConsoleUtils.GetLimitedSizeInput(maxWidth - 15, int.MaxValue);
                        Console.CursorLeft -= "Game name: ".Length;

                        ConsoleUtils.FormattedWrite("Link to Game: ", new FormattedWriteSettings { NewLine = false });
                        gameLink = ConsoleUtils.GetLimitedSizeInput(maxWidth - 15, int.MaxValue);
                        Console.CursorLeft -= "Link to Game: ".Length;

                        Screen.AddGame(gameName, gameLink);
                    }
                }
            }
        }

        static void ShowGamesBox()
        {
            // Check console size
            if (Console.WindowWidth > 55)
            {
                int allowedWidth = 50;
                int cursorAddition;

                // Change width of box depending on console size
                if (Console.WindowWidth < 80)
                {
                    allowedWidth = 50 - (80 - Console.WindowWidth);
                }

                // Set location of box
                Location gameBoxLocation = new Location(Console.WindowWidth - allowedWidth - 5, 5);
                
                // Create games text
                cursorAddition = ConsoleUtils.FormattedWrite("Games:", new FormattedWriteSettings
                {
                    Location = new Location(gameBoxLocation.X + 3, gameBoxLocation.Y + 4),
                    ResetCursorPosition = true
                }).Y + 2;
                foreach (Game game in Screen.Games)
                {
                    cursorAddition = ConsoleUtils.FormattedWrite(game.ToString(), new FormattedWriteSettings
                    {
                        Location = new Location(gameBoxLocation.X + 3, cursorAddition),
                        MaximumWidth = allowedWidth - 4,
                        ResetCursorPosition = true
                    }).Y + 1;
                }

                // Create the box
                ConsoleUtils.CreateBox(gameBoxLocation, new Location(gameBoxLocation.X + allowedWidth, cursorAddition + 4), new Borders(true)
                {
                    TopStyle = "_\\*",
                    LeftStyle = "|:|",
                    RightStyle = "|:|",
                    BottomStyle = "-+"
                });
            }
        }

        /// <summary>
        /// The menu screen for the program and the base running code
        /// </summary>
        static void ActualProgram()
        {
            int menuOption = -1;
            
            Console.Title = "Game Save Manager - Created By Ciaran";

            while (menuOption != 3)
            {
                ConsoleUtils.PrepNewScreen("Game Save Manager");
                ShowGamesBox();

                // Show different menu if there are any games
                if (Screen.Games.Count > 0)
                {
                    // Create menu
                    ConsoleUtils.CreateMenu(new string[] { "Add/Remove Games", "Edit Games", "Quit" }, "Main Menu:");
                    if (Console.WindowWidth > 80)
                    {
                        menuOption = ConsoleUtils.FancyGetInteger("Menu Option: ", "Menu choice must be an integer", "Default", 1, 3, new FormattedWriteSettings { NewLine = false, MaximumWidth = Console.WindowWidth - 60 }, maxCharLength: 1);
                    }
                    else
                    {
                        menuOption = ConsoleUtils.FancyGetInteger("Menu Option: ", "Menu choice must be an integer", "Default", 1, 3, new FormattedWriteSettings { NewLine = false, MaximumWidth = 27 }, maxCharLength: 1);
                    }
                }
                else
                {
                    // Create menu
                    ConsoleUtils.CreateMenu(new string[] { "Add/Remove Games", "Quit" }, "Main Menu:");
                    if (Console.WindowWidth > 80)
                    {
                        menuOption = ConsoleUtils.FancyGetInteger("Menu Option: ", "Menu choice must be an integer", "Default", 1, 2, new FormattedWriteSettings { NewLine = false, MaximumWidth = Console.WindowWidth - 60 }, maxCharLength: 1);
                    }
                    else
                    {
                        menuOption = ConsoleUtils.FancyGetInteger("Menu Option: ", "Menu choice must be an integer", "Default", 1, 2, new FormattedWriteSettings { NewLine = false, MaximumWidth = 27 }, maxCharLength: 1);
                    }

                    // Set quit option to 3 so it actually quits
                    if (menuOption == 2)
                    {
                        menuOption = 3;
                    }

                    if (menuOption == 1)
                    {
                        AddGameScreen();
                    }
                }
            }
        }

        /// <summary>
        /// A testing screen where I test various things
        /// </summary>
        static void Tests()
        {
            int test = 2;

            // Test the FormattedWrite method
            if (test == 1)
            {
                ConsoleUtils.PrepNewScreen("Header");
                ConsoleUtils.FormattedWrite("--Title--", new FormattedWriteSettings
                {
                    MaximumWidth = 33,
                    TextAlignment = Alignment.Centre,
                    Location = new Location(20, 8),
                    SlowWrite = false,
                    BorderSettings = new Borders(true)
                    {
                        BottomEnabled = false,
                        LeftStyle = "\\:|--|",
                        RightStyle = "|--|:/",
                        TopStyle = "_\\=",
                        BottomStyle = "-4324"
                    }
                });
                ConsoleUtils.FormattedWrite("This is a paragraph of text which will format itself accordingly to whatever I want it to do", new FormattedWriteSettings
                {
                    NewLine = false,
                    InnerPadding = new Padding(2, 4),
                    MinToJustify = new MinimumJustification(70, true),
                    MaximumWidth = 33,
                    Justified = true,
                    SlowWrite = true,
                    BorderSettings = new Borders(true)
                    {
                        TopEnabled = false,
                        LeftStyle = "\\:|--|",
                        RightStyle = "|--|:/",
                        BottomStyle = "+-+"
                    }
                });
                Console.ReadKey(true);

                ConsoleUtils.FormattedWrite("--Title 2--", new FormattedWriteSettings()
                {
                    MaximumWidth = 33,
                    TextAlignment = Alignment.Centre,
                    Location = new Location(80, 5),
                    ResetCursorPosition = true
                });
                ConsoleUtils.FormattedWrite("This is another paragraph of text which will also format itself accordingly", new FormattedWriteSettings()
                {
                    MaximumWidth = 33,
                    Justified = true,
                    Location = new Location(80, 6),
                    SlowWrite = true,
                    ThreadGap = 30,
                    ShowCursor = false,
                    ResetCursorPosition = true
                });
            }

            // Test the FancyGetInteger method
            else if (test == 2)
            {
                int number = ConsoleUtils.FancyGetInteger("What is the input value? ", minValue: 0, writeOptions: new FormattedWriteSettings()
                {
                    Location = new Location(5, 5),
                    InnerPadding = new Padding(0, 4),
                    MaximumWidth = 20,
                    NewLine = false
                }, maxCharLength: 10, maxCharHeight: 3);
                ConsoleUtils.FormattedWrite("The resulting number is: " + number, new FormattedWriteSettings() { InnerPadding = new Padding(0, 4) });
            }

            // Test the CreateBox method
            else if (test == 3)
            {
                ConsoleUtils.CreateBox(new Location(10, 4), new Location(50, 10), new Borders(true)
                {
                    LeftStyle = "\\:|:|--|",
                    RightStyle = "|--|:|:/"
                });
            }

            // Test the GetLimitedSizeInput method
            else if (test == 4)
            {
                Console.SetCursorPosition(10, 6);
                ConsoleUtils.GetLimitedSizeInput(5, 2);
            }

            // Test the FancyGetAllowedInput method
            else if (test == 5)
            {
                string input = ConsoleUtils.FancyGetAllowedInput(new string[] { "y", "n" }, "What is the input value? ", "Input must be y/n", false, new FormattedWriteSettings()
                {
                    Location = new Location(5, 5),
                    InnerPadding = new Padding(0, 4),
                    MaximumWidth = 20,
                    NewLine = false
                }, maxCharLength: 10, maxCharHeight: 3);
                ConsoleUtils.FormattedWrite("The resulting input is: " + input, new FormattedWriteSettings() { InnerPadding = new Padding(0, 4) });
            }
            Console.ReadKey(true);
        }

        static void Main(string[] args)
        {
            ActualProgram();
            //Tests();
        }
    }
}
