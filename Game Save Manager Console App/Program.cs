using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProgramCodes;
using System.Threading.Tasks;
using System.Threading;

namespace GameSaveManagerConsoleApp
{
    class Program
    {
        /// <summary>
        /// Plays the background music
        /// </summary>
        static Thread ExtraMusic = new Thread(() => BackgroundMusic());

        /// <summary>
        /// The current song being played
        /// </summary>
        public static string CurrentSong;

        /// <summary>
        /// A dictionary that has the song name as a string and the actual song itself
        /// </summary>
        public static Dictionary<string, Songs> SongNameToSong = new Dictionary<string, Songs>()
        {
            { "Für Elise", Songs.FurElise },
            { "Mary had a little lamb", Songs.MaryHadALittleLamb }
        };

        /// <summary>
        /// Any code that is common between interfaces
        /// </summary>
        public static DisplayScreenCode ScreenCode = new DisplayScreenCode("./savefile.txt");

        /// <summary>
        /// Allows the viewing of a save
        /// </summary>
        static void ViewSaveScreen(Save save, int saveIndex)
        {
            ConsoleUtils.PrepNewScreen("Game Save Manager");
            if (Console.WindowWidth > "Game Save Manager".Length + ("Current Music: ".Length + CurrentSong.Length + 6) * 2)
            {
                ConsoleUtils.FormattedWrite("Current Music: " + CurrentSong, new FormattedWriteSettings { Location = new Location(0, 1), TextAlignment = Alignment.Right, InnerPadding = new Padding(0, 2, 0), ResetCursorPosition = true });
            }

            // Create favourited status
            if (save.Favourited)
            {
                ConsoleUtils.FormattedWrite("Favourited", new FormattedWriteSettings
                {
                    AreaBorderSettings = new Borders
                    {
                        TopStyle = "*",
                        LeftStyle = "*",
                        RightStyle = "*",
                        BottomStyle = "*"
                    },
                    ResetCursorPosition = true
                });
            }

            // Create title
            ConsoleUtils.FormattedWrite(save.Title, new FormattedWriteSettings
            {
                TextAlignment = Alignment.Centre,
                Location = new Location(Console.CursorLeft, Console.CursorTop - 1),
                ResetCursorPosition = true,
                TextBorderSettings = new Borders
                {
                    TopStyle = "_",
                    LeftEnabled = false,
                    RightEnabled = false,
                    BottomStyle = "\u0305"
                }
            });

            // Create date
            ConsoleUtils.FormattedWrite("Date Created: " + save.Date, new FormattedWriteSettings
            {
                TextAlignment = Alignment.Right,
                TextBorderSettings = new Borders(false) { BottomEnabled = true },
                ResetCursorPosition = true
            });

            // Create save number
            ConsoleUtils.FormattedWrite("Save Number:" + (saveIndex + 1).ToString().PadLeft(3, '0'), new FormattedWriteSettings
            {
                TextAlignment = Alignment.Right,
                InnerPadding = new Padding(2, 4, 0)
            });
            Console.CursorLeft = 0;

            // Create line
            ConsoleUtils.FormattedWrite("".PadLeft(Console.WindowWidth, '-'), new FormattedWriteSettings
            {
                InnerPadding = new Padding(1, 0, 1)
            });


            // Create save data
            ConsoleUtils.FormattedWrite("Save Data:", new FormattedWriteSettings
            {
                MaximumWidth = Console.WindowWidth / 2,
                ResetCursorPosition = true
            });
            ConsoleUtils.FormattedWrite(save.SaveData, new FormattedWriteSettings
            {
                Location = new Location(Console.CursorLeft, Console.CursorTop + 1),
                MaximumWidth = Console.WindowWidth / 2,
                ResetCursorPosition = true
            });

            // Create notes
            ConsoleUtils.FormattedWrite("Notes:", new FormattedWriteSettings
            {
                Location = new Location(Console.WindowWidth / 2, Console.CursorTop),
                MaximumWidth = Console.WindowWidth / 2
            });
            foreach (string note in save.Notes)
            {
                ConsoleUtils.FormattedWrite(note, new FormattedWriteSettings
                {
                    MaximumWidth = Console.WindowWidth / 2
                });
            }
            Console.SetCursorPosition(0, Console.CursorTop + 2);

            // Create prompt
            ConsoleUtils.FormattedWrite("Press any key to continue", new FormattedWriteSettings { TextAlignment = Alignment.Centre });

            // Create a small footer
            ConsoleUtils.FormattedWrite("".PadLeft(Console.WindowWidth, '_'), new FormattedWriteSettings { InnerPadding = new Padding(0) });
            Console.CursorVisible = false;
            Console.ReadKey(true);
            Console.CursorVisible = true;
        }

        /// <summary>
        /// The screen that is displayed when entering notes
        /// </summary>
        /// <param name="notes">The notes to enter</param>
        /// <returns>The written notes</returns>
        static string[] NotesScreen(List<string> notes)
        {
            string input;
            int menuOption = 0;
            int nextLine;
            Location notesLocation;
            int notesMaxWidth;
            int textMaxWidth;


            while (menuOption != 3)
            {
                // Set values based on console width
                if (Console.WindowWidth >= 120)
                {
                    notesMaxWidth = 60;
                    textMaxWidth = 50;
                    notesLocation = new Location(Console.WindowWidth - notesMaxWidth - 5, 5);
                }
                else if (Console.WindowWidth >= 60)
                {
                    notesMaxWidth = 60 * Console.WindowWidth / 120;
                    textMaxWidth = 50 * Console.WindowWidth / 120;
                    notesLocation = new Location(Console.WindowWidth - notesMaxWidth - 5, 5);
                }
                else
                {
                    notesLocation = new Location(4, 13);
                    notesMaxWidth = 60 * Console.WindowWidth / 60 - 4;
                    textMaxWidth = 50 * Console.WindowWidth / 60;
                }

                ConsoleUtils.PrepNewScreen("Game Save Manager");
                if (Console.WindowWidth > "Game Save Manager".Length + ("Current Music: ".Length + CurrentSong.Length + 6) * 2)
                {
                    ConsoleUtils.FormattedWrite("Current Music: " + CurrentSong, new FormattedWriteSettings { Location = new Location(0, 1), TextAlignment = Alignment.Right, InnerPadding = new Padding(0, 2, 0), ResetCursorPosition = true });
                }

                // Create notes section
                Location prevLocation = new Location();
                ConsoleUtils.FormattedWrite("Notes:", new FormattedWriteSettings { InnerPadding = new Padding(0, 0, 1), Location = notesLocation });
                for (int i = 0; i < notes.Count; i++)
                {
                    ConsoleUtils.FormattedWrite((i + 1) + ".", new FormattedWriteSettings { InnerPadding = new Padding(0), Location = new Location(Console.CursorLeft - i.ToString().Length - 2, Console.CursorTop), ResetCursorPosition = true });
                    ConsoleUtils.FormattedWrite(notes[i], new FormattedWriteSettings { InnerPadding = new Padding(0), MaximumWidth = notesMaxWidth, WrapWords = false });
                }
                nextLine = Console.CursorTop;
                Console.SetCursorPosition(prevLocation.X, prevLocation.Y);

                // Create menu and receive input
                if (notes.Count > 0)
                {
                    ConsoleUtils.CreateMenu(new string[] { "Add notes", "Change Notes", "Back" }, "Main Menu:");
                    menuOption = ConsoleUtils.FancyGetInteger("Menu Option: ", "Menu choice must be an integer", "Default", 1, 3, new FormattedWriteSettings { NewLine = false, MaximumWidth = textMaxWidth }, maxCharLength: 1);
                }
                else
                {
                    ConsoleUtils.CreateMenu(new string[] { "Add notes", "Back" }, "Main Menu:");
                    menuOption = ConsoleUtils.FancyGetInteger("Menu Option: ", "Menu choice must be an integer", "Default", 1, 2, new FormattedWriteSettings { NewLine = false, MaximumWidth = textMaxWidth }, maxCharLength: 1);

                    // Make menuOption back
                    if (menuOption == 2)
                    {
                        menuOption = 3;
                    }
                }

                // Adding notes
                if (menuOption == 1)
                {
                    input = " ";
                    while (input != "")
                    {
                        Console.SetCursorPosition(notesLocation.X, nextLine);
                        ConsoleUtils.FormattedWrite((notes.Count + 1) + ".", new FormattedWriteSettings { InnerPadding = new Padding(0), Location = new Location(Console.CursorLeft - (notes.Count + 1).ToString().Length - 2, Console.CursorTop), ResetCursorPosition = true });

                        input = ConsoleUtils.GetLimitedSizeInput(notesMaxWidth, int.MaxValue);

                        if (input != "")
                        {
                            notes.Add(input);
                            nextLine = Console.CursorTop;
                        }
                    }
                }
                // Editing a specific line in notes
                else if (menuOption == 2)
                {
                    // Get input for new line
                    string newText;
                    int lineToChange = ConsoleUtils.FancyGetInteger("Line to change: ", "Menu choice must be an integer", "Default", 1, notes.Count, new FormattedWriteSettings { NewLine = false, InnerPadding = new Padding(1, 4, 0), MaximumWidth = textMaxWidth }, maxCharLength: notes.Count.ToString().Length) - 1;
                    ConsoleUtils.FormattedWrite("(Just click enter to delete line)", new FormattedWriteSettings { InnerPadding = new Padding(1, 4), MaximumWidth = textMaxWidth });
                    newText = ConsoleUtils.FancyGetInput("New input: ", notesMaxWidth, int.MaxValue);

                    // Remove if input is blank
                    if (newText == "")
                    {
                        notes.RemoveAt(lineToChange);
                    }
                    else
                    {
                        notes[lineToChange] = newText;
                    }
                }
            }
            return notes.ToArray();
        }

        /// <summary>
        /// The screen used to add a save
        /// </summary>
        /// <param name="game">The game where it is being saves</param>
        /// <returns>A completed save</returns>
        static Save EditSaveScreen(Save save)
        {
            int previewMaxWidth = 0;
            int menuMaxWidth = 0;
            int menuOption = 0;
            bool show = true;
            List<string> menuOptions;
            Location previewLocation = new Location();

            while (menuOption != 7)
            {
                ConsoleUtils.PrepNewScreen("Game Save Manager");
                if (Console.WindowWidth > "Game Save Manager".Length + ("Current Music: ".Length + CurrentSong.Length + 6) * 2)
                {
                    ConsoleUtils.FormattedWrite("Current Music: " + CurrentSong, new FormattedWriteSettings { Location = new Location(0, 1), TextAlignment = Alignment.Right, InnerPadding = new Padding(0, 2, 0), ResetCursorPosition = true });
                }

                // Get maximum widths
                if (Console.WindowWidth >= 100)
                {
                    previewMaxWidth = 45;
                    menuMaxWidth = Console.WindowWidth - previewMaxWidth - 25;
                    previewLocation = new Location(Console.WindowWidth - previewMaxWidth - 12, 8);
                }
                else if (Console.WindowWidth >= 80)
                {
                    previewMaxWidth = 45 - (100 - Console.WindowWidth);
                    menuMaxWidth = Console.WindowWidth - previewMaxWidth - 25;
                    previewLocation = new Location(Console.WindowWidth - previewMaxWidth - 12, 8);
                }
                else
                {
                    menuMaxWidth = Console.WindowWidth - 5;
                    show = false;
                }

                if (show)
                {
                    Location prevLocation = new Location();

                    // Write preview
                    Console.SetCursorPosition(previewLocation.X, previewLocation.Y);
                    FormattedWriteSettings sharedSettings = new FormattedWriteSettings { MaximumWidth = previewMaxWidth, InnerPadding = new Padding(0, 0, 1) };
                    if (save.Favourited)
                    {
                        ConsoleUtils.FormattedWrite("**Favourited**", new FormattedWriteSettings() { MaximumWidth = previewMaxWidth, TextAlignment = Alignment.Centre, InnerPadding = new Padding(0) });
                    }
                    ConsoleUtils.FormattedWrite(save.Title, new FormattedWriteSettings(sharedSettings) { Location = new Location() });
                    ConsoleUtils.FormattedWrite("Save Data:", new FormattedWriteSettings { InnerPadding = new Padding(0) });
                    ConsoleUtils.FormattedWrite(save.SaveData, new FormattedWriteSettings(sharedSettings) { Location = new Location() });
                    ConsoleUtils.FormattedWrite("Notes:", new FormattedWriteSettings { InnerPadding = new Padding(0) });
                    foreach (string note in save.Notes)
                    {
                        ConsoleUtils.FormattedWrite(note, new FormattedWriteSettings(sharedSettings) { InnerPadding = new Padding(0), Location = new Location() });
                    }

                    
                    ConsoleUtils.CreateBorder(new Location(previewLocation.X, previewLocation.Y), new Location(previewLocation.X + previewMaxWidth, Console.CursorTop), new Padding(1, 2), new Borders
                    {
                        TopStyle = "_\\*",
                        LeftStyle = "|:|",
                        RightStyle = "|:|",
                        BottomStyle = "-+"
                    });
                    Console.SetCursorPosition(prevLocation.X, prevLocation.Y);
                }

                // Show different menu if there are any games
                menuOptions = new List<string>() { "Title", "Save Data", "Notes" };
                if (save.Favourited)
                {
                    menuOptions.Add("Unfavourite Save");
                }
                else
                {
                    menuOptions.Add("Favourite Save");
                }
                if (save.SaveData != "")
                {
                    menuOptions.Add("Save to collection");
                }
                if (ExtraMusic.ThreadState == ThreadState.Aborted)
                {
                    menuOptions.Add("Start Music");
                }
                else
                {
                    menuOptions.Add("Stop Music");
                }
                menuOptions.Add("Quit (without saving)");
                ConsoleUtils.CreateMenu(menuOptions, "Main Menu:");
                if (save.SaveData == "")
                {
                    // Display menu
                    menuOption = ConsoleUtils.FancyGetInteger("Menu Option: ", "Menu choice must be an integer", "Default", 1, 6, new FormattedWriteSettings { NewLine = false }, maxCharLength: 1);

                    if (menuOption > 4)
                    {
                        menuOption += 1;
                    }
                }
                else
                {
                    // Display menu
                    menuOption = ConsoleUtils.FancyGetInteger("Menu Option: ", "Menu choice must be an integer", "Default", 1, 7, new FormattedWriteSettings { NewLine = false }, maxCharLength: 1);
                }
                
                // Change values
                if (menuOption == 1)
                {
                    Console.WriteLine();
                    save.Title = ConsoleUtils.FancyGetInput("Title: ", menuMaxWidth);
                }
                else if (menuOption == 2)
                {
                    Console.WriteLine();
                    save.SaveData = ConsoleUtils.FancyGetInput("Save Data: ", menuMaxWidth);
                }
                else if (menuOption == 3)
                {
                    save.Notes = NotesScreen(save.Notes.ToList());
                }
                else if (menuOption == 4)
                {
                    save.Favourited = save.Favourited == false;
                }
                else if (menuOption == 5)
                {
                    if (save.Date != null)
                    {
                        save.Date = DateTime.Now;
                    }
                    return save;
                }
                else if (menuOption == 6)
                {
                    if (ExtraMusic.ThreadState == ThreadState.Aborted)
                    {
                        ExtraMusic = new Thread(() => BackgroundMusic());
                        ExtraMusic.Start();
                    }
                    else
                    {
                        ExtraMusic.Abort();
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Goes to the Edit Saves Screen and changes output depending on game
        /// </summary>
        /// <param name="gameName">The name of the game</param>
        static void EditSavesScreen(string gameName)
        {
            int maxWidth;
            int menuOption = -1;
            int gameIndex = ScreenCode.Games.FindIndex(x => x.Name.ToLower() == gameName.ToLower());

            while (menuOption != 5)
            {
                ConsoleUtils.PrepNewScreen("Game Save Manager");
                if (Console.WindowWidth > "Game Save Manager".Length + ("Current Music: ".Length + CurrentSong.Length + 6) * 2)
                {
                    ConsoleUtils.FormattedWrite("Current Music: " + CurrentSong, new FormattedWriteSettings { Location = new Location(0, 1), TextAlignment = Alignment.Right, InnerPadding = new Padding(0, 2, 0), ResetCursorPosition = true });
                }
                ShowFancyBox("Saves:", ScreenCode.Games[gameIndex].Saves);

                if (Console.WindowWidth > 70)
                {
                    maxWidth = Console.WindowWidth - 50;
                }
                else
                {
                    maxWidth = 20;
                }

                // Show different menu if there are any games
                if (ScreenCode.Games[gameIndex].Saves.Count > 0)
                {
                    // Create menu
                    ConsoleUtils.CreateMenu(new string[] { "Add Save", "Edit Save", "Remove Save", "View Save", "Back" }, "Main Menu:");
                    menuOption = ConsoleUtils.FancyGetInteger("Menu Option: ", "Menu choice must be an integer", "Default", 1, 5, new FormattedWriteSettings { NewLine = false, MaximumWidth = maxWidth }, maxCharLength: 1);
                }
                else
                {

                    // Create menu
                    ConsoleUtils.CreateMenu(new string[] { "Add Save", "Back" }, "Main Menu:");
                    menuOption = ConsoleUtils.FancyGetInteger("Menu Option: ", "Menu choice must be an integer", "Default", 1, 2, new FormattedWriteSettings { NewLine = false, MaximumWidth = maxWidth }, maxCharLength: 1);

                    // Set back option to 3 so it actually quits
                    if (menuOption == 2)
                    {
                        menuOption = 5;
                    }
                }

                // Add Save
                if (menuOption == 1)
                {
                    Save newSave;

                    // Gets the save that is to be added and adds it (if it exists)
                    newSave = EditSaveScreen(new Save("Save " + ScreenCode.Games[gameIndex].Saves.Count + 1, null, false, "", new string[] { }));
                    if (newSave != null)
                    {
                        ScreenCode.Games[gameIndex].AddSave(newSave);
                        ScreenCode.Save();
                    }
                }

                // Edit save
                else if (menuOption == 2)
                {
                    string saveDate;
                    int saveIndex;
                    Save editedSave;

                    // Gets the save date and index
                    saveDate = ConsoleUtils.FancyGetAllowedInput(ScreenCode.Games[gameIndex].Saves.Select(x => x.Date.ToString(Save.Culture)), "Date of the save (exactly as seen): ", "Invalid save date", false, new FormattedWriteSettings { NewLine = false, InnerPadding = new Padding(1, 4, 0) }, maxCharLength: maxWidth - 15, maxCharHeight: 1 + 50 / (maxWidth - 15), preventIncorrectText: true);
                    saveIndex = ScreenCode.Games[gameIndex].Saves.FindIndex(x => x.Date.ToString(Save.Culture) == saveDate);

                    // Change save if the saveData hasn't been set to nothing
                    editedSave = EditSaveScreen(ScreenCode.Games[gameIndex].Saves[saveIndex]);
                    if (editedSave != null)
                    {
                        ScreenCode.Games[gameIndex].Saves[saveIndex] = editedSave;
                        ScreenCode.Save();
                    }
                }

                // Remove save
                else if (menuOption == 3)
                {
                    string saveDate;

                    // Gets the save date
                    saveDate = ConsoleUtils.FancyGetAllowedInput(ScreenCode.Games[gameIndex].Saves.Select(x => x.Date.ToString(Save.Culture)), "Date of the save (exactly as seen): ", "Invalid save date", false, new FormattedWriteSettings { NewLine = false, InnerPadding = new Padding(1, 4, 0) }, maxCharLength: maxWidth - 15, maxCharHeight: 1 + 50 / (maxWidth - 15), preventIncorrectText: true);

                    // Delete the save
                    ScreenCode.Games[gameIndex].RemoveSave(saveDate);
                }

                // View save
                else if (menuOption == 4)
                {
                    string saveDate;
                    int saveIndex;

                    // Gets the save date and index
                    saveDate = ConsoleUtils.FancyGetAllowedInput(ScreenCode.Games[gameIndex].Saves.Select(x => x.Date.ToString(Save.Culture)), "Date of the save (exactly as seen): ", "Invalid save date", false, new FormattedWriteSettings { NewLine = false, InnerPadding = new Padding(1, 4, 0) }, maxCharLength: maxWidth - 15, maxCharHeight: 1 + 50 / (maxWidth - 15), preventIncorrectText: true);
                    saveIndex = ScreenCode.Games[gameIndex].Saves.FindIndex(x => x.Date.ToString(Save.Culture) == saveDate);

                    ViewSaveScreen(ScreenCode.Games[gameIndex].Saves[saveIndex], saveIndex);
                }
            }
        }

        /// <summary>
        /// The screen where games are added
        /// </summary>
        static void AddGameScreen()
        {
            int maxWidth;
            int menuOption = -1;

            if (Console.WindowWidth >= 120)
            {
                maxWidth = Console.WindowWidth - 60;
            }
            else
            {
                maxWidth = 20;
            }

            while (menuOption != 3)
            {
                ConsoleUtils.PrepNewScreen("Game Save Manager");
                if (Console.WindowWidth > "Game Save Manager".Length + ("Current Music: ".Length + CurrentSong.Length + 6) * 2)
                {
                    ConsoleUtils.FormattedWrite("Current Music: " + CurrentSong, new FormattedWriteSettings { Location = new Location(0, 1), TextAlignment = Alignment.Right, InnerPadding = new Padding(0, 2, 0), ResetCursorPosition = true });
                }
                ShowFancyBox("Games:", ScreenCode.Games);

                // Show different menu if there are any games
                if (ScreenCode.Games.Count > 0)
                {
                    ConsoleUtils.CreateMenu(new string[] { "Add Game", "Remove Game", "Back" }, "Main Menu:");
                    menuOption = ConsoleUtils.FancyGetInteger("Menu Option: ", "Menu choice must be an integer", "Default", 1, 3, new FormattedWriteSettings { NewLine = false, MaximumWidth = maxWidth }, maxCharLength: 1);
                }
                else
                {
                    ConsoleUtils.CreateMenu(new string[] { "Add Game", "Back" }, "Main Menu:");
                    menuOption = ConsoleUtils.FancyGetInteger("Menu Option: ", "Menu choice must be an integer", "Default", 1, 2, new FormattedWriteSettings { NewLine = false, MaximumWidth = maxWidth }, maxCharLength: 1);

                    // Set back option to 3 so it actually quits
                    if (menuOption == 2)
                    {
                        menuOption = 3;
                    }
                }

                // Add game
                if (menuOption == 1)
                {
                    string gameName;
                    string gameLink;

                    gameName = ConsoleUtils.FancyGetInverseAllowedInput(ScreenCode.Games.Select(x => x.Name), "Game name: ", "Game already exists", false, new FormattedWriteSettings { NewLine = false, InnerPadding = new Padding(1, 4, 0) }, maxCharLength: maxWidth - 15, maxCharHeight: 1 + 50 / (maxWidth - 15));
                    gameLink = ConsoleUtils.FancyGetInput("Link to game: ", maxWidth, int.MaxValue, new FormattedWriteSettings { NewLine = false, InnerPadding = new Padding(1, 4, 0) });

                    ScreenCode.AddGame(gameName, gameLink);
                }

                // Remove game
                else if (menuOption == 2)
                {
                    string gameName;

                    gameName = ConsoleUtils.FancyGetAllowedInput(ScreenCode.Games.Select(x => x.Name), "Name of the game to delete: ", "Invalid Game Name", false, new FormattedWriteSettings { NewLine = false, InnerPadding = new Padding(1, 4, 0) }, maxCharLength: maxWidth - 15, maxCharHeight: 1 + 50 / (maxWidth - 15), preventIncorrectText: true);

                    if (ConsoleUtils.FancyGetAllowedInput(new string[] { "y", "n" }, "Are you really sure? (y/n): ", "Invalid Game Name", false, new FormattedWriteSettings { NewLine = false, InnerPadding = new Padding(1, 4, 0) }, maxCharLength: maxWidth - 15, maxCharHeight: int.MaxValue, preventIncorrectText: true).ToLower() == "y")
                    {
                        ScreenCode.RemoveGame(gameName);
                    }
                }
            }
        }

        /// <summary>
        /// Shows a fancy box on the right of the screen with a title and slightly indented contents
        /// </summary>
        /// <param name="title">The title</param>
        /// <param name="stuffToShow">The stuff to show</param>
        static void ShowFancyBox(string title, IEnumerable<object> stuffToShow)
        {
            // Check console size
            if (Console.WindowWidth > 66)
            {
                int allowedWidth = 36;
                int cursorAddition;
                Location gameBoxLocation;

                // Change width of box depending on console size
                if (Console.WindowWidth < 85)
                {
                    allowedWidth = 36 - (85 - Console.WindowWidth);
                }

                // Set location of box
                if (Console.WindowWidth > 75)
                {
                    gameBoxLocation = new Location(Console.WindowWidth - allowedWidth - 12, 8);
                }
                else
                {
                    gameBoxLocation = new Location(Console.WindowWidth - allowedWidth - 12, 6);
                }

                // Create games text
                cursorAddition = ConsoleUtils.FormattedWrite(title, new FormattedWriteSettings
                {
                    InnerPadding = new Padding(0, 0, 1),
                    Location = new Location(gameBoxLocation.X, gameBoxLocation.Y),
                    ResetCursorPosition = true,
                }).Y + 1;
                foreach (object game in stuffToShow)
                {
                    cursorAddition = ConsoleUtils.FormattedWrite(game.ToString(), new FormattedWriteSettings
                    {
                        InnerPadding = new Padding(1, 2, 0, 0),
                        Location = new Location(gameBoxLocation.X, cursorAddition),
                        MaximumWidth = allowedWidth,
                        ResetCursorPosition = true
                    }).Y + 1;
                }

                // Create the box
                if (Console.WindowWidth > 75)
                {
                    ConsoleUtils.CreateBorder(gameBoxLocation, new Location(gameBoxLocation.X + allowedWidth, cursorAddition), new Padding(1, 4, 4, 0), new Borders
                    {
                        TopStyle = "_\\*",
                        LeftStyle = "|:|",
                        RightStyle = "|:|",
                        BottomStyle = "-+"
                    });
                }
                else
                {
                    ConsoleUtils.CreateBorder(gameBoxLocation, new Location(gameBoxLocation.X + allowedWidth, cursorAddition), new Padding(1, 4, 4, 0), new Borders
                    {
                        TopStyle = "_",
                        LeftStyle = "/",
                        RightStyle = "\\",
                        BottomStyle = "+"
                    });
                }
            }
        }

        /// <summary>
        /// The menu screen for the program and the base running code
        /// </summary>
        static void ActualProgram()
        {
            int menuOption = -1;
            int maxWidth;
            
            Console.Title = "Game Save Manager - Created By Ciaran";

            while (menuOption != 4)
            {
                // Gets the maximum width
                if (Console.WindowWidth > 70)
                {
                    maxWidth = Console.WindowWidth - 50;
                }
                else
                {
                    maxWidth = 20;
                }

                ConsoleUtils.PrepNewScreen("Game Save Manager");
                if (Console.WindowWidth > "Game Save Manager".Length + ("Current Music: ".Length + CurrentSong.Length + 6) * 2)
                {
                    ConsoleUtils.FormattedWrite("Current Music: " + CurrentSong, new FormattedWriteSettings { Location = new Location(0, 1), TextAlignment = Alignment.Right, InnerPadding = new Padding(0, 2, 0), ResetCursorPosition = true });
                }
                ShowFancyBox("Games:", ScreenCode.Games);

                // Show different menu if there are any games
                if (ScreenCode.Games.Count > 0)
                {
                    // Display menu
                    if (ExtraMusic.ThreadState == ThreadState.Aborted)
                    {
                        ConsoleUtils.CreateMenu(new string[] { "Add/Remove Games", "Edit Games", "Start Music", "Quit" }, "Main Menu:");
                    }
                    else
                    {
                        ConsoleUtils.CreateMenu(new string[] { "Add/Remove Games", "Edit Games", "Stop Music", "Quit" }, "Main Menu:");
                    }
                    if (Console.WindowWidth > 80)
                    {
                        menuOption = ConsoleUtils.FancyGetInteger("Menu Option: ", "Menu choice must be an integer", "Default", 1, 4, new FormattedWriteSettings { NewLine = false, InnerPadding = new Padding(1, 4, 0), MaximumWidth = Console.WindowWidth - 60 }, maxCharLength: 1);
                    }
                    else
                    {
                        menuOption = ConsoleUtils.FancyGetInteger("Menu Option: ", "Menu choice must be an integer", "Default", 1, 4, new FormattedWriteSettings { NewLine = false, InnerPadding = new Padding(1, 4, 0), MaximumWidth = 27 }, maxCharLength: 1);
                    }
                }
                else
                {
                    // Display menu
                    if (ExtraMusic.ThreadState == ThreadState.Aborted)
                    {
                        ConsoleUtils.CreateMenu(new string[] { "Add/Remove Games", "Start Music", "Quit" }, "Main Menu:");
                    }
                    else
                    {
                        ConsoleUtils.CreateMenu(new string[] { "Add/Remove Games", "Stop Music", "Quit" }, "Main Menu:");
                    }
                    if (Console.WindowWidth > 80)
                    {
                        menuOption = ConsoleUtils.FancyGetInteger("Menu Option: ", "Menu choice must be an integer", "Default", 1, 3, new FormattedWriteSettings { NewLine = false, InnerPadding = new Padding(1, 4, 0), MaximumWidth = Console.WindowWidth - 60 }, maxCharLength: 1);
                    }
                    else
                    {
                        menuOption = ConsoleUtils.FancyGetInteger("Menu Option: ", "Menu choice must be an integer", "Default", 1, 3, new FormattedWriteSettings { NewLine = false, InnerPadding = new Padding(1, 4, 0), MaximumWidth = 27 }, maxCharLength: 1);
                    }

                    // Set menu option up one due to other available option
                    if (menuOption != 1)
                    {
                        menuOption += 1;
                    }
                }

                // Add/Remove games
                if (menuOption == 1)
                {
                    AddGameScreen();
                }

                // Edit games
                else if (menuOption == 2)
                {
                    string gameName;
                    gameName = ConsoleUtils.FancyGetAllowedInput(ScreenCode.Games.Select(x => x.Name), "Name of the game: ", "Invalid Game Name", false, new FormattedWriteSettings { NewLine = false, InnerPadding = new Padding(1, 4, 0) }, maxCharLength: maxWidth, maxCharHeight: int.MaxValue, preventIncorrectText: true);

                    EditSavesScreen(gameName);
                }

                // Change music setting
                else if (menuOption == 3)
                {
                    if (ExtraMusic.ThreadState == ThreadState.Aborted)
                    {
                        ExtraMusic = new Thread(() => BackgroundMusic());
                        ExtraMusic.Start();
                    }
                    else
                    {
                        ExtraMusic.Abort();
                    }
                }
            }
        }

        /// <summary>
        /// A testing screen where I test various things
        /// </summary>
        static void Tests()
        {
            int test = 6;

            // Test the FormattedWrite method
            if (test == 1)
            {
                ConsoleUtils.PrepNewScreen("Header");
                ConsoleUtils.FormattedWrite("--Title--", new FormattedWriteSettings
                {
                    MaximumWidth = 33,
                    TextAlignment = Alignment.Centre,
                    Location = new Location(10, 10),
                    AreaBorderSettings = new Borders
                    {
                        BottomEnabled = false,
                        LeftStyle = "\\:|--|",
                        RightStyle = "|--|:/",
                        TopStyle = "_\\="
                    }
                });
                ConsoleUtils.FormattedWrite("This is a paragraph of text which will format itself accordingly to whatever I want it to do", new FormattedWriteSettings
                {
                    NewLine = false,
                    InnerPadding = new Padding(2, 4),
                    MaximumWidth = 33,
                    Justified = true,
                    SlowWrite = true,
                    AreaBorderSettings = new Borders
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
                    MaximumWidth = 37,
                    TextAlignment = Alignment.Centre,
                    Location = new Location(60, 5),
                    ResetCursorPosition = true,
                });
                ConsoleUtils.FormattedWrite("This is another paragraph of text which will also format itself accordingly", new FormattedWriteSettings()
                {
                    MaximumWidth = 33,
                    Justified = true,
                    Location = new Location(60, 7),
                    SlowWrite = true,
                    ThreadGap = 30,
                    ShowCursor = false,
                    ResetCursorPosition = true,
                    TextBorderSettings = new Borders
                    {
                        TopStyle = "-",
                        LeftStyle = "||",
                        RightStyle = "||",
                        BottomStyle = "-"
                    }
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
                ConsoleUtils.CreateBox(new Location(10, 4), new Location(50, 10), new Borders
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
            
            // Play Fur-Elise
            else if (test == 6)
            {
                Music.PlayFurElise(120, Instrument.ConsoleBeep);
            }
            Console.ReadKey(true);
        }

        /// <summary>
        /// Plays background music unless muted
        /// </summary>
        static void BackgroundMusic()
        {
            while (true)
            {
                // Choose song
                Random rand = new Random();
                string[] songs = SongNameToSong.Keys.ToArray();
                CurrentSong = songs[rand.Next(songs.Length)];

                // Play song
                Music.PlaySong(SongNameToSong[CurrentSong]);
                Thread.Sleep(5000);
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            // Starts the background music
            ExtraMusic.IsBackground = true;
            ExtraMusic.Start();

            // Starts the chosen program
            ActualProgram();
            //Tests();
            ExtraMusic.Abort();
        }
    }
}
