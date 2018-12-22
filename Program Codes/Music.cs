using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgramCodes
{
    /// <summary>
    /// All the songs that are available
    /// </summary>
    public enum Songs { FurElise, MaryHadALittleLamb };

    /// <summary>
    /// A set of all in instruments provided
    /// </summary>
    public enum Instrument { Piano, ConsoleBeep };

    /// <summary>
    /// Contains piano notes and code
    /// </summary>
    public static class Piano
    {
        /// <summary>
        /// Contains the notes and their relative resources
        /// </summary>
        public static Dictionary<string, System.IO.UnmanagedMemoryStream> NoteToResource = new Dictionary<string, System.IO.UnmanagedMemoryStream>()
        {
            { "A0", Properties.Resources.Piano_A0 }, { "A#0", Properties.Resources.Piano_Bb0 },
            { "Bb0", Properties.Resources.Piano_Bb0 }, { "B0", Properties.Resources.Piano_B0 },
            { "C1", Properties.Resources.Piano_C1 }, { "C#1", Properties.Resources.Piano_Db1 },
            { "Db1", Properties.Resources.Piano_Db1 }, { "D1", Properties.Resources.Piano_D1 }, { "D#1", Properties.Resources.Piano_Eb1 },
            { "Eb1", Properties.Resources.Piano_Eb1 }, { "E1", Properties.Resources.Piano_E1 },
            { "F1", Properties.Resources.Piano_F1 }, { "F#1", Properties.Resources.Piano_Gb1 },
            { "Gb1", Properties.Resources.Piano_Gb1 }, { "G1", Properties.Resources.Piano_G1 }, { "G#1", Properties.Resources.Piano_Ab1 },
            { "Ab1", Properties.Resources.Piano_Ab1 }, { "A1", Properties.Resources.Piano_A1 }, { "A#1", Properties.Resources.Piano_Bb1 },
            { "Bb1", Properties.Resources.Piano_Bb1 }, { "B1", Properties.Resources.Piano_B1 },
            { "C2", Properties.Resources.Piano_C2 }, { "C#2", Properties.Resources.Piano_Db2 },
            { "Db2", Properties.Resources.Piano_Db2 }, { "D2", Properties.Resources.Piano_D2 }, { "D#2", Properties.Resources.Piano_Eb2 },
            { "Eb2", Properties.Resources.Piano_Eb2 }, { "E2", Properties.Resources.Piano_E2 },
            { "F2", Properties.Resources.Piano_F2 }, { "F#2", Properties.Resources.Piano_Gb2 },
            { "Gb2", Properties.Resources.Piano_Gb2 }, { "G2", Properties.Resources.Piano_G2 }, { "G#2", Properties.Resources.Piano_Ab2 },
            { "Ab2", Properties.Resources.Piano_Ab2 }, { "A2", Properties.Resources.Piano_A2 }, { "A#2", Properties.Resources.Piano_Bb2 },
            { "Bb2", Properties.Resources.Piano_Bb2 }, { "B2", Properties.Resources.Piano_B2 },
            { "C3", Properties.Resources.Piano_C3 }, { "C#3", Properties.Resources.Piano_Db3 },
            { "Db3", Properties.Resources.Piano_Db3 }, { "D3", Properties.Resources.Piano_D3 }, { "D#3", Properties.Resources.Piano_Eb3 },
            { "Eb3", Properties.Resources.Piano_Eb3 }, { "E3", Properties.Resources.Piano_E3 },
            { "F3", Properties.Resources.Piano_F3 }, { "F#3", Properties.Resources.Piano_Gb3 },
            { "Gb3", Properties.Resources.Piano_Gb3 }, { "G3", Properties.Resources.Piano_G3 }, { "G#3", Properties.Resources.Piano_Ab3 },
            { "Ab3", Properties.Resources.Piano_Ab3 }, { "A3", Properties.Resources.Piano_A3 }, { "A#3", Properties.Resources.Piano_Bb3 },
            { "Bb3", Properties.Resources.Piano_Bb3 }, { "B3", Properties.Resources.Piano_B3 },
            { "C4", Properties.Resources.Piano_C4 }, { "C#4", Properties.Resources.Piano_Db4 },
            { "Db4", Properties.Resources.Piano_Db4 }, { "D4", Properties.Resources.Piano_D4 }, { "D#4", Properties.Resources.Piano_Eb4 },
            { "Eb4", Properties.Resources.Piano_Eb4 }, { "E4", Properties.Resources.Piano_E4 },
            { "F4", Properties.Resources.Piano_F4 }, { "F#4", Properties.Resources.Piano_Gb4 },
            { "Gb4", Properties.Resources.Piano_Gb4 }, { "G4", Properties.Resources.Piano_G4 }, { "G#4", Properties.Resources.Piano_Ab4 },
            { "Ab4", Properties.Resources.Piano_Ab4 }, { "A4", Properties.Resources.Piano_A4 }, { "A#4", Properties.Resources.Piano_Bb4 },
            { "Bb4", Properties.Resources.Piano_Bb4 }, { "B4", Properties.Resources.Piano_B4 },
            { "C5", Properties.Resources.Piano_C5 }, { "C#5", Properties.Resources.Piano_Db5 },
            { "Db5", Properties.Resources.Piano_Db5 }, { "D5", Properties.Resources.Piano_D5 }, { "D#5", Properties.Resources.Piano_Eb5 },
            { "Eb5", Properties.Resources.Piano_Eb5 }, { "E5", Properties.Resources.Piano_E5 },
            { "F5", Properties.Resources.Piano_F5 }, { "F#5", Properties.Resources.Piano_Gb5 },
            { "Gb5", Properties.Resources.Piano_Gb5 }, { "G5", Properties.Resources.Piano_G5 }, { "G#5", Properties.Resources.Piano_Ab5 },
            { "Ab5", Properties.Resources.Piano_Ab5 }, { "A5", Properties.Resources.Piano_A5 }, { "A#5", Properties.Resources.Piano_Bb5 },
            { "Bb5", Properties.Resources.Piano_Bb5 }, { "B5", Properties.Resources.Piano_B5 },
            { "C6", Properties.Resources.Piano_C6 }, { "C#6", Properties.Resources.Piano_Db6 },
            { "Db6", Properties.Resources.Piano_Db6 }, { "D6", Properties.Resources.Piano_D6 }, { "D#6", Properties.Resources.Piano_Eb6 },
            { "Eb6", Properties.Resources.Piano_Eb6 }, { "E6", Properties.Resources.Piano_E6 },
            { "F6", Properties.Resources.Piano_F6 }, { "F#6", Properties.Resources.Piano_Gb6 },
            { "Gb6", Properties.Resources.Piano_Gb6 }, { "G6", Properties.Resources.Piano_G6 }, { "G#6", Properties.Resources.Piano_Ab6 },
            { "Ab6", Properties.Resources.Piano_Ab6 }, { "A6", Properties.Resources.Piano_A6 }, { "A#6", Properties.Resources.Piano_Bb6 },
            { "Bb6", Properties.Resources.Piano_Bb6 }, { "B6", Properties.Resources.Piano_B6 },
            { "C7", Properties.Resources.Piano_C7 }, { "C#7", Properties.Resources.Piano_Db7 },
            { "Db7", Properties.Resources.Piano_Db7 }, { "D7", Properties.Resources.Piano_D7 }, { "D#7", Properties.Resources.Piano_Eb7 },
            { "Eb7", Properties.Resources.Piano_Eb7 }, { "E7", Properties.Resources.Piano_E7 },
            { "F7", Properties.Resources.Piano_F7 }, { "F#7", Properties.Resources.Piano_Gb7 },
            { "Gb7", Properties.Resources.Piano_Gb7 }, { "G7", Properties.Resources.Piano_G7 }, { "G#7", Properties.Resources.Piano_Ab7 },
            { "Ab7", Properties.Resources.Piano_Ab7 }, { "A7", Properties.Resources.Piano_A7 }, { "A#7", Properties.Resources.Piano_Bb7 },
            { "Bb7", Properties.Resources.Piano_Bb7 }, { "B7", Properties.Resources.Piano_B7 },
            { "C8", Properties.Resources.Piano_C8 }
        };

        /// <summary>
        /// Plays a note
        /// </summary>
        /// <param name="note">The note to play</param>
        /// <param name="noteType">The type of note to play (duration-wise)</param>
        /// <param name="bpm">Beats per minute to play at</param>
        public static async void PlayNote(string note, string noteType, int bpm)
        {
            System.IO.Stream noteToPlay = NoteToResource[note];
            noteToPlay.Position = 0;
            SoundPlayer sound = new SoundPlayer(noteToPlay);
            sound.Play();
            await Task.Delay(Music.GetPeriod(noteType, bpm));
            sound.Stop();
        }
    }

    public static class ConsoleBeep
    {
        /// <summary>
        /// Contains notes and their frequencies
        /// </summary>
        public static Dictionary<string, int> NoteToFrequency = new Dictionary<string, int>()
        {
            { "D1", 37 }, { "D#1", 39 },
            { "Eb1", 39 }, { "E1", 41 },
            { "F1", 44 }, { "F#1", 46 },
            { "Gb1", 46 }, { "G1", 49 }, { "G#1", 52 },
            { "Ab1", 52 }, { "A1", 55 }, { "A#1", 58 },
            { "Bb1", 58 }, { "B1", 62 },
            { "C2", 65 }, { "C#2", 69 },
            { "Db2", 69 }, { "D2", 73 }, { "D#2", 78 },
            { "Eb2", 78 }, { "E2", 82 },
            { "F2", 87 }, { "F#2", 92 },
            { "Gb2", 92 }, { "G2", 98 }, { "G#2", 104 },
            { "Ab2", 104 }, { "A2", 110 }, { "A#2", 117 },
            { "Bb2", 117 }, { "B2", 123 },
            { "C3", 131 }, { "C#3", 139 },
            { "Db3", 139 }, { "D3", 147 }, { "D#3", 156 },
            { "Eb3", 156 }, { "E3", 165 },
            { "F3", 175 }, { "F#3", 185 },
            { "Gb3", 185 }, { "G3", 196 }, { "G#3", 208 },
            { "Ab3", 208 }, { "A3", 220 }, { "A#3", 233 },
            { "Bb3", 233 }, { "B3", 247 },
            { "C4", 262 }, { "C#4", 277 },
            { "Db4", 277 }, { "D4", 294 }, { "D#4", 311 },
            { "Eb4", 311 }, { "E4", 330 },
            { "F4", 349 }, { "F#4", 370 },
            { "Gb4", 370 }, { "G4", 392 }, { "G#4", 415 },
            { "Ab4", 415 }, { "A4", 440 }, { "A#4", 466 },
            { "Bb4", 466 }, { "B4", 493 },
            { "C5", 523 }, { "C#5", 554 },
            { "Db5", 554 }, { "D5", 587 }, { "D#5", 622 },
            { "Eb5", 622 }, { "E5", 659 },
            { "F5", 698 }, { "F#5", 740 },
            { "Gb5", 740 }, { "G5", 784 }, { "G#5", 831 },
            { "Ab5", 831 }, { "A5", 880 }, { "A#5", 932 },
            { "Bb5", 932 }, { "B5", 988 },
            { "C6", 1046 }, { "C#6", 1109 },
            { "Db6", 1109 }, { "D6", 1175 }, { "D#6", 1245 },
            { "Eb6", 1245 }, { "E6", 1319 },
            { "F6", 1397 }, { "F#6", 1480 },
            { "Gb6", 1480 }, { "G6", 1568 }, { "G#6", 1661 },
            { "Ab6", 1661 }, { "A6", 1760 }, { "A#6", 1865 },
            { "Bb6", 1865 }, { "B6", 1976 },
            { "C7", 2093 }, { "C#7", 2218 },
            { "Db7", 2218 }, { "D7", 2349 }, { "D#7", 2489 },
            { "Eb7", 2489 }, { "E7", 2637 },
            { "F7", 2793 }, { "F#7", 2960 },
            { "Gb7", 2960 }, { "G7", 3136 }, { "G#7", 3322 },
            { "Ab7", 3322 }, { "A7", 3520 }, { "A#7", 3729 },
            { "Bb7", 3729 }, { "B7", 2951 },
            { "C8", 4186 }
        };

        /// <summary>
        /// Plays a note
        /// </summary>
        /// <param name="note">The note to play</param>
        /// <param name="noteType">The type of note to play (duration-wise)</param>
        /// <param name="bpm">Beats per minute to play at</param>
        public static void PlayNote(string note, string noteType, int bpm)
        {
            Console.Beep(NoteToFrequency[note], Music.GetPeriod(noteType, bpm) * 2);
        }
    }

    /// <summary>
    /// Contains all the code for general music playing
    /// </summary>
    public static class Music
    {
        /// <summary>
        /// Contains the note length as the key and the interval as the length of the note
        /// </summary>
        public static Dictionary<string, double> LengthToInterval = new Dictionary<string, double>()
        {
            { "B", 8 },
            { "SB", 4 },
            { "M", 2 },
            { "C", 1 },
            { "Q", 0.5 },
            { "SQ", 0.25 },
            { "DSQ", 0.125 },
            { "HDSQ", 0.0625 }
        };

        /// <summary>
        /// Plays any song of choice with the default instrument and the default bpm
        /// </summary>
        /// <param name="song">The song to be played</param>
        public static void PlaySong(Songs song)
        {
            if (song == Songs.FurElise)
            {
                PlayFurElise(120, Instrument.ConsoleBeep);
            }
            else if (song == Songs.MaryHadALittleLamb)
            {
                PlayMaryHadALittleLamb(120, Instrument.Piano);
            }
        }

        /// <summary>
        /// Plays any song of choice with a specific instrument and the default bpm
        /// </summary>
        /// <param name="song">The song to be played</param>
        /// <param name="instrument">The instrument to be used</param>
        public static void PlaySong(Songs song, Instrument instrument)
        {
            if (song == Songs.FurElise)
            {
                PlayFurElise(120, instrument);
            }
            else if (song == Songs.MaryHadALittleLamb)
            {
                PlayMaryHadALittleLamb(120, instrument);
            }
        }

        /// <summary>
        /// Plays any song of choice with any specific instrument and bpm
        /// </summary>
        /// <param name="song">The song to be played</param>
        /// <param name="instrument">The instrument to be used</param>
        /// <param name="bpm">The bpm of the song</param>
        public static void PlaySong(Songs song, Instrument instrument, int bpm)
        {
            if (song == Songs.FurElise)
            {
                PlayFurElise(bpm, instrument);
            }
            else if (song == Songs.MaryHadALittleLamb)
            {
                PlayMaryHadALittleLamb(bpm, instrument);
            }
        }

        /// <summary>
        /// Plays a selection of notes depending on the instrument chosen
        /// </summary>
        /// <param name="note">The note/s to be played (separate multiple with, '/')</param>
        /// <param name="notePeriod">The type of note (depending on length). Separate multiple periods with, '/'</param>
        /// <param name="bpm">The beats per minute that the music is played at</param>
        /// <param name="instrument">The instrument being chosen</param>
        public static void PlayNotes(string note, string notePeriod, int bpm, Instrument instrument)
        {
            int notePeriodIndex = 0;
            string[] notes = note.Split('/');
            string[] notePeriods = notePeriod.Split('/');

            // If the instrument is the console beep, only play the first one
            if (instrument == Instrument.ConsoleBeep)
            {
                ConsoleBeep.PlayNote(notes[0], notePeriods[0], bpm);
            }
            else
            {
                // Starts each note in the given notes
                for (int i = 0; i < notes.Length; i++)
                {
                    if (instrument == Instrument.Piano)
                    {
                        Piano.PlayNote(notes[i], notePeriods[notePeriodIndex], bpm);
                    }
                    // Only adds the notePeriod index if there is enough to choose from (the last will be used if there are too many notes)
                    if (notePeriodIndex < notePeriods.Length)
                    {
                        notePeriodIndex++;
                    }
                }
            }
        }

        /// <summary>
        /// Rests for a certain note period
        /// </summary>
        /// <param name="notePeriod">The type of note to play (duration-wise)</param>
        /// <param name="bpm">Beats per minute</param>
        /// <returns>The requested time</returns>
        public static int GetPeriod(string notePeriod, int bpm)
        {
            // If there the notePeriod is not contained, there may be multiple note periods included
            if (LengthToInterval.ContainsKey(notePeriod))
            {
                return (int)(LengthToInterval[notePeriod] * 60000 / bpm);
            }

            string[] notePeriods = notePeriod.Split('+');
            double totalLength = 0;

            // Adds the length of each peiod to the total
            foreach (string period in notePeriods)
            {
                totalLength += LengthToInterval[period] * 60000 / bpm;
            }

            return (int)totalLength;
        }

        /// <summary>
        /// Sleeps the thread only if the instrument can be played over multiple threads
        /// </summary>
        /// <param name="notePeriod">The period of time to rest for</param>
        /// <param name="bpm">Beats per minute to play at</param>
        /// <param name="instrument">The instrument that is used</param>
        public static void MoveForward(string notePeriod, int bpm, Instrument instrument)
        {
            if (instrument != Instrument.ConsoleBeep)
            {
                Thread.Sleep(GetPeriod(notePeriod, bpm));
            }
        }

        /// <summary>
        /// Works as a rest for the thread. Doubles the rest for certain instruments
        /// </summary>
        /// <param name="notePeriod">The period of time to rest for</param>
        /// <param name="bpm">Beats per minute to play at</param>
        /// <param name="instrument">The instrument that is used</param>
        public static void Rest(string notePeriod, int bpm, Instrument instrument)
        {
            // Although this could be replaced with the below code, if any changes are required, this allows for changes
            Thread.Sleep(GetPeriod(notePeriod, bpm));
        }

        /// <summary>
        /// Plays Für Elise with the right hand
        /// </summary>
        /// <param name="bpm">Beats per minute to play at</param>
        /// <param name="instrument">The instrument to be used</param>
        public static void PlayFurEliseRightHand(int bpm, Instrument instrument)
        {
            for (int i = 0; i < 2; i++)
            {
                // Bar 1
                PlayNotes("E5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("D#5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);

                // Bar 2
                PlayNotes("E5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("D#5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("B4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("D5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("C5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);

                // Bar 3
                PlayNotes("A4", "Q", bpm, instrument);
                MoveForward("Q", bpm, instrument);
                Rest("SQ", bpm, instrument);

                PlayNotes("C4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("A4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);

                // Bar 4
                PlayNotes("B4", "Q", bpm, instrument);
                MoveForward("Q", bpm, instrument);
                Rest("SQ", bpm, instrument);

                PlayNotes("E4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("G#4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("B4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);

                // Bar 5
                PlayNotes("C5", "Q", bpm, instrument);
                MoveForward("Q", bpm, instrument);
                Rest("SQ", bpm, instrument);

                PlayNotes("E4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("D#5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);

                // Bar 6
                PlayNotes("E5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("D#5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("B4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("D5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("C5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);

                // Bar 7
                PlayNotes("A4", "Q", bpm, instrument);
                MoveForward("Q", bpm, instrument);
                Rest("SQ", bpm, instrument);

                PlayNotes("C4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("A4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);

                // Bar 8
                PlayNotes("B4", "Q", bpm, instrument);
                MoveForward("Q", bpm, instrument);
                Rest("SQ", bpm, instrument);

                PlayNotes("E4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("C5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("B4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);

                // Bar 9
                if (i == 0)
                {
                    PlayNotes("A4", "C", bpm, instrument);
                    MoveForward("C", bpm, instrument);
                }

                // Bar 10
                else
                {
                    PlayNotes("A4", "Q", bpm, instrument);
                    MoveForward("Q", bpm, instrument);
                    Rest("SQ", bpm, instrument);

                    PlayNotes("B4", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                    PlayNotes("C5", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                    PlayNotes("D5", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                }
            }
            for (int i = 0; i < 2; i++)
            {
                // Bar 11
                PlayNotes("E5", "Q+SQ", bpm, instrument);
                MoveForward("Q+SQ", bpm, instrument);

                PlayNotes("G4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("F5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);

                // Bar 12
                PlayNotes("D5", "Q+SQ", bpm, instrument);
                MoveForward("Q+SQ", bpm, instrument);

                PlayNotes("F4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("D5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);

                // Bar 13
                PlayNotes("C5", "Q+SQ", bpm, instrument);
                MoveForward("Q+SQ", bpm, instrument);

                PlayNotes("E4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("D5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("C5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);

                // Bar 14
                PlayNotes("B4", "Q", bpm, instrument);
                MoveForward("Q", bpm, instrument);
                Rest("SQ", bpm, instrument);

                PlayNotes("E4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                Rest("SQ", bpm, instrument);

                // Bar 15
                Rest("SQ", bpm, instrument);
                PlayNotes("E5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E6", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                Rest("Q", bpm, instrument);

                PlayNotes("D#5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);

                // Bar 16
                PlayNotes("E5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                Rest("Q", bpm, instrument);

                PlayNotes("D#5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("D#5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);

                // Bar 17
                PlayNotes("E5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("D#5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("B4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("D5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("C5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);

                // Bar 18
                PlayNotes("A4", "Q", bpm, instrument);
                MoveForward("Q", bpm, instrument);
                Rest("SQ", bpm, instrument);

                PlayNotes("C4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("A4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);

                // Bar 19
                PlayNotes("B4", "Q", bpm, instrument);
                MoveForward("Q", bpm, instrument);
                Rest("SQ", bpm, instrument);

                PlayNotes("E4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("G#4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("B4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);

                // Bar 20
                PlayNotes("C5", "Q", bpm, instrument);
                MoveForward("Q", bpm, instrument);
                Rest("SQ", bpm, instrument);

                PlayNotes("E4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("D#5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);

                // Bar 21
                PlayNotes("E5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("D#5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("B4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("D5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("C5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);

                // Bar 22
                PlayNotes("A4", "Q", bpm, instrument);
                MoveForward("Q", bpm, instrument);
                Rest("SQ", bpm, instrument);

                PlayNotes("C4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("A4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);

                // Bar 23
                PlayNotes("B4", "Q", bpm, instrument);
                MoveForward("Q", bpm, instrument);
                Rest("SQ", bpm, instrument);

                PlayNotes("E4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("C5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("B4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);

                // Bar 24
                if (i == 0)
                {
                    PlayNotes("A4", "Q", bpm, instrument);
                    MoveForward("Q", bpm, instrument);
                    Rest("SQ", bpm, instrument);

                    PlayNotes("B4", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                    PlayNotes("C5", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                    PlayNotes("D5", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                }
                // Bar 25
                else
                {
                    PlayNotes("A4", "Q", bpm, instrument);
                    MoveForward("Q", bpm, instrument);
                    Rest("SQ", bpm, instrument);

                    PlayNotes("C5/E4", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                    PlayNotes("C5/F4", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                    PlayNotes("C5/G4/E4", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                }
            }

            // Bar 26
            PlayNotes("F4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("A4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C5", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);

            PlayNotes("F5", "SQ+DSQ", bpm, instrument);
            MoveForward("SQ+DSQ", bpm, instrument);
            PlayNotes("E5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);

            // Bar 27
            PlayNotes("E5", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);

            PlayNotes("D5", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);

            PlayNotes("Bb5", "SQ+DSQ", bpm, instrument);
            MoveForward("SQ+DSQ", bpm, instrument);
            PlayNotes("A5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);

            // Bar 28
            PlayNotes("A5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("G5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("F5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 29
            PlayNotes("Bb4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);

            PlayNotes("A4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);

            PlayNotes("A4", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("G4", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("A4", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("Bb4", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);

            // Bar 30
            PlayNotes("C5", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);

            PlayNotes("D5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 31
            PlayNotes("E5", "Q+SQ", bpm, instrument);
            MoveForward("Q+SQ", bpm, instrument);

            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("F5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("A4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 32
            PlayNotes("C5", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);

            PlayNotes("D5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("B4", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);

            // Bar 33
            PlayNotes("E5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("G5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("G4", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("G5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);

            PlayNotes("A4", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("G5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("B4", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("G5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);

            PlayNotes("C5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("G5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("D5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("G5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);

            // Bar 34
            PlayNotes("E5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("G5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("C6", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("B5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);

            PlayNotes("A5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("G5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("F5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("E5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);

            PlayNotes("D5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("G5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("F5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("D5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);

            // Bar 35
            PlayNotes("E5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("G5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("G4", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("G5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);

            PlayNotes("A4", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("G5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("B4", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("G5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);

            PlayNotes("C5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("G5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("D5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("G5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);

            // Bar 36
            PlayNotes("E5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("G5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("C6", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("B5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);

            PlayNotes("A5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("G5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("F5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("E5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);

            PlayNotes("D5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("G5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("F5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("D5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);

            // Bar 37
            PlayNotes("E5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("F5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("E5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("D#5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);

            PlayNotes("E5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("B4", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("E5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("D#5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);

            PlayNotes("E5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("B4", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("E5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);
            PlayNotes("D#5", "DSQ", bpm, instrument);
            MoveForward("DSQ", bpm, instrument);

            // Bar 38
            PlayNotes("E5", "Q+SQ", bpm, instrument);
            MoveForward("Q+SQ", bpm, instrument);

            PlayNotes("B4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 39
            PlayNotes("E5", "Q+SQ", bpm, instrument);
            MoveForward("Q+SQ", bpm, instrument);

            PlayNotes("B4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            Rest("SQ", bpm, instrument);

            // Bar 40
            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            Rest("Q", bpm, instrument);

            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 41
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("B4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 42
            PlayNotes("A4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("SQ", bpm, instrument);

            PlayNotes("C4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("A4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 43
            PlayNotes("B4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("SQ", bpm, instrument);

            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("G#4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("B4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 44
            PlayNotes("C5", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("SQ", bpm, instrument);

            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 45
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("B4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 46
            PlayNotes("A4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("SQ", bpm, instrument);

            PlayNotes("C4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("A4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 47
            PlayNotes("B4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("SQ", bpm, instrument);

            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("B4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 48
            PlayNotes("A4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("SQ", bpm, instrument);

            PlayNotes("B4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 49
            PlayNotes("E5", "Q+SQ", bpm, instrument);
            MoveForward("Q+SQ", bpm, instrument);

            PlayNotes("G4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("F5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 50
            PlayNotes("D5", "Q+SQ", bpm, instrument);
            MoveForward("Q+SQ", bpm, instrument);

            PlayNotes("F4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 51
            PlayNotes("C5", "Q+SQ", bpm, instrument);
            MoveForward("Q+SQ", bpm, instrument);

            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 52
            PlayNotes("B4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("SQ", bpm, instrument);

            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            Rest("SQ", bpm, instrument);

            // Bar 53
            Rest("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E6", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            Rest("Q", bpm, instrument);

            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 54
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            Rest("Q", bpm, instrument);

            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 55
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("B4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 56
            PlayNotes("A4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("SQ", bpm, instrument);

            PlayNotes("C4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("A4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 57
            PlayNotes("B4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("SQ", bpm, instrument);

            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("G#4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("B4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 58
            PlayNotes("C5", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("SQ", bpm, instrument);

            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 59
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("B4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 60
            PlayNotes("A4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("SQ", bpm, instrument);

            PlayNotes("C4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("A4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 61
            PlayNotes("B4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("SQ", bpm, instrument);

            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("B4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 62
            PlayNotes("A4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("C", bpm, instrument);

            // Bar 63
            PlayNotes("C#5/Bb4/G4/E4", "C+Q", bpm, instrument);
            MoveForward("C+Q", bpm, instrument);

            // Bar 64
            PlayNotes("D5/A4/F4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);

            PlayNotes("E5/C#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            PlayNotes("F5/D5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 65
            PlayNotes("D5/A4/F4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);

            PlayNotes("D5/A4/F4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);

            // Bar 66
            PlayNotes("E5/C5/A4", "C+Q", bpm, instrument);
            MoveForward("C+Q", bpm, instrument);

            // Bar 67
            PlayNotes("D5/F4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);

            PlayNotes("C5/E4", "SQ", bpm, instrument);
            MoveForward("Q", bpm, instrument);

            PlayNotes("B4/D4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 68
            PlayNotes("A4/F#4/C4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);

            PlayNotes("A4/C4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);

            // Bar 69
            PlayNotes("A4/C4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);

            PlayNotes("C5/E4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);

            PlayNotes("B4/D4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);

            // Bar 70
            PlayNotes("A4/C4", "C+Q", bpm, instrument);
            MoveForward("C+Q", bpm, instrument);

            // Bar 71
            PlayNotes("C#5/Bb4/G4/E4", "C+Q", bpm, instrument);
            MoveForward("C+Q", bpm, instrument);

            // Bar 72
            PlayNotes("D5/A4/F4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);

            PlayNotes("E5/C#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            PlayNotes("F5/D5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 73
            PlayNotes("F5/D5", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);

            PlayNotes("F5/D5", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);

            // Bar 74
            PlayNotes("F5/D5", "Q", bpm, instrument);
            MoveForward("C+Q", bpm, instrument);

            // Bar 75
            PlayNotes("Eb5/G4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);

            PlayNotes("D5/F4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            PlayNotes("C5/Eb4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 76
            PlayNotes("Bb4/D4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);

            PlayNotes("A4/F4/D4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);

            // Bar 77
            PlayNotes("G4/F#4/D4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);

            PlayNotes("G4/F#4/D4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);

            // Bar 78
            PlayNotes("A4/E4/C4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);

            Rest("Q", bpm, instrument);

            // Bar 79
            PlayNotes("B4/E4", "SQ", bpm, instrument);
            MoveForward("Q", bpm, instrument);

            Rest("C", bpm, instrument);

            // Bar 80
            PlayNotes("A3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            PlayNotes("A4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            PlayNotes("D5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("B4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 81
            PlayNotes("A4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            PlayNotes("A5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C6", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E6", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            PlayNotes("D6", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C6", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("B5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 82
            PlayNotes("A5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C6", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E6", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            PlayNotes("A6", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C7", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E7", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            PlayNotes("D7", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C7", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("B6", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 83
            PlayNotes("Bb6", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("A6", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("G#6", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            PlayNotes("G6", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("F#6", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("F6", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            PlayNotes("E6", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("Eb6", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D6", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 84
            PlayNotes("C#6", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C6", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("B5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            PlayNotes("Bb5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("A5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("G#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            PlayNotes("G5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("F#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("F5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 85
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("B4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 86
            PlayNotes("A4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("SQ", bpm, instrument);

            PlayNotes("C4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("A4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 87
            PlayNotes("B4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("SQ", bpm, instrument);

            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("G#4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("B4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 88
            PlayNotes("C5", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("SQ", bpm, instrument);

            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 89
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("B4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 90
            PlayNotes("A4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("SQ", bpm, instrument);

            PlayNotes("C4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("A4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 91
            PlayNotes("B4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("SQ", bpm, instrument);

            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("B4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 92
            PlayNotes("A4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("SQ", bpm, instrument);

            PlayNotes("B4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 93
            PlayNotes("E5", "Q+SQ", bpm, instrument);
            MoveForward("Q+SQ", bpm, instrument);
            PlayNotes("G4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("F5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 94
            PlayNotes("D5", "Q+SQ", bpm, instrument);
            MoveForward("Q+SQ", bpm, instrument);

            PlayNotes("F4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 95
            PlayNotes("C5", "Q+SQ", bpm, instrument);
            MoveForward("Q+SQ", bpm, instrument);

            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 96
            PlayNotes("B4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("SQ", bpm, instrument);

            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            Rest("SQ", bpm, instrument);

            // Bar 97
            Rest("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E6", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            Rest("Q", bpm, instrument);

            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 98
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            Rest("Q", bpm, instrument);

            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 99
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("B4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 100
            PlayNotes("A4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("SQ", bpm, instrument);

            PlayNotes("C4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("A4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 101
            PlayNotes("B4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("SQ", bpm, instrument);

            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("G#4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("B4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 102
            PlayNotes("C5", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("SQ", bpm, instrument);

            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 103
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("B4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 104
            PlayNotes("A4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("SQ", bpm, instrument);

            PlayNotes("C4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("A4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 105
            PlayNotes("B4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("SQ", bpm, instrument);

            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("B4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 106
            PlayNotes("A4/C4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);
        }

        /// <summary>
        /// Plays Für Elise with the left hand
        /// </summary>
        /// <param name="bpm">Beats per minute to play at</param>
        /// <param name="instrument">The instrument to be used</param>
        public static void PlayFurEliseLeftHand(int bpm, Instrument instrument)
        {
            for (int i = 0; i < 2; i++)
            {
                // Bar 1
                Rest("Q", bpm, instrument);

                for (int x = 0; x < 2; x++)
                {
                    // Bars 2/6
                    Rest("C+Q", bpm, instrument);

                    // Bars 3/7
                    PlayNotes("A2", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                    PlayNotes("E3", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                    PlayNotes("A3", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                    Rest("Q+SQ", bpm, instrument);

                    // Bars 4/8
                    PlayNotes("E2", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                    PlayNotes("E3", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                    PlayNotes("G#3", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                    Rest("Q+SQ", bpm, instrument);

                    // Bars 5/9/10
                    PlayNotes("A2", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                    PlayNotes("E3", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                    PlayNotes("A3", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                    Rest("SQ", bpm, instrument);

                    // Bars 5/10 - Linked to above
                    if (i == 1 || x == 0)
                    {
                        Rest("Q", bpm, instrument);
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                // Bar 11
                PlayNotes("C3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("G3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("C4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                Rest("Q+SQ", bpm, instrument);

                // Bar 12
                PlayNotes("G2", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("G3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("B3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                Rest("Q+SQ", bpm, instrument);

                // Bar 13
                PlayNotes("A2", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("A3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                Rest("Q+SQ", bpm, instrument);

                // Bar 14
                PlayNotes("E2", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("A3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                Rest("Q", bpm, instrument);

                PlayNotes("E4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);

                // Bar 15
                PlayNotes("E5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                Rest("Q", bpm, instrument);

                PlayNotes("D#5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                Rest("SQ", bpm, instrument);

                // Bar 16
                Rest("SQ", bpm, instrument);
                PlayNotes("D#5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E5", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                Rest("Q+SQ", bpm, instrument);

                for (int x = 0; x < 2; x++)
                {
                    // Bars 17/21
                    Rest("C+Q", bpm, instrument);

                    // Bars 18/22
                    PlayNotes("A2", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                    PlayNotes("E3", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                    PlayNotes("A3", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                    Rest("Q+SQ", bpm, instrument);

                    // Bars 19/23
                    PlayNotes("E2", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                    PlayNotes("E3", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                    PlayNotes("G#3", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                    Rest("Q+SQ", bpm, instrument);

                    // Bars 20/24
                    if (i == 0)
                    {
                        PlayNotes("A2", "SQ", bpm, instrument);
                        MoveForward("SQ", bpm, instrument);
                        PlayNotes("E3", "SQ", bpm, instrument);
                        MoveForward("SQ", bpm, instrument);
                        PlayNotes("A3", "SQ", bpm, instrument);
                        MoveForward("SQ", bpm, instrument);
                        Rest("Q+SQ", bpm, instrument);
                    }

                    // Bar 25
                    else
                    {
                        PlayNotes("A2", "SQ", bpm, instrument);
                        MoveForward("SQ", bpm, instrument);
                        PlayNotes("E3", "SQ", bpm, instrument);
                        MoveForward("SQ", bpm, instrument);
                        PlayNotes("A3", "SQ", bpm, instrument);
                        MoveForward("SQ", bpm, instrument);
                        PlayNotes("C4/Bb3", "SQ", bpm, instrument);
                        MoveForward("SQ", bpm, instrument);
                        PlayNotes("C4/A3", "SQ", bpm, instrument);
                        MoveForward("SQ", bpm, instrument);
                        PlayNotes("C4/Bb3/G3", "SQ", bpm, instrument);
                        MoveForward("SQ", bpm, instrument);
                    }
                }
            }

            // Bar 26
            Rest("Q", bpm, instrument);
            PlayNotes("F3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("A3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("A3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("A3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 27
            PlayNotes("F3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("Bb3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("Bb3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("Bb3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 28
            PlayNotes("F3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("Bb3/G3/F3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("Bb3/G3/F3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bars 29/30
            for (int i = 0; i < 2; i++)
            {
                PlayNotes("F3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("A3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("C4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("A3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("C4", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("A3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
            }

            // Bar 31
            PlayNotes("E3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("A3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("A3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("D4/D3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("F3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 32
            PlayNotes("A3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("A3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("A3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("F4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 33
            PlayNotes("E4/C4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("SQ", bpm, instrument);

            PlayNotes("G4/F4", "DSQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("G4/E4", "DSQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("G4/F4/D4", "DSQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 34
            PlayNotes("G4/E4/C4", "DSQ", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            PlayNotes("A4/F4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            PlayNotes("B4/G4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);

            // Bar 35
            PlayNotes("C5", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("SQ", bpm, instrument);

            PlayNotes("G4/F4", "DSQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("G4/E4", "DSQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("G4/F4/D4", "DSQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 36
            PlayNotes("G4/E4/C4", "DSQ", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            PlayNotes("A4/F4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            PlayNotes("B4/G4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);

            // Bar 37
            PlayNotes("B4/G#4", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("C", bpm, instrument);

            // Bar 38
            Rest("C+Q", bpm, instrument);

            // Bar 39
            Rest("C+SQ", bpm, instrument);
            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 40
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            Rest("Q", bpm, instrument);

            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            Rest("SQ", bpm, instrument);
            
            for (int x = 0; x < 2; x++)
            {
                // Bars 41/45
                Rest("C+Q", bpm, instrument);

                // Bars 42/46
                PlayNotes("A2", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("A3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                Rest("Q+SQ", bpm, instrument);

                // Bars 43/47
                PlayNotes("E2", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("G#3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                Rest("Q+SQ", bpm, instrument);

                // Bars 44/48
                PlayNotes("A2", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("A3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                Rest("Q+SQ", bpm, instrument);
            }

            // Bar 49
            PlayNotes("C3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("G3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            Rest("Q+SQ", bpm, instrument);

            // Bar 50
            PlayNotes("G2", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("G3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("B3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            Rest("Q+SQ", bpm, instrument);

            // Bar 51
            PlayNotes("A2", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("A3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            Rest("Q+SQ", bpm, instrument);

            // Bar 52
            PlayNotes("E2", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("A3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            Rest("Q", bpm, instrument);

            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 53
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            Rest("Q", bpm, instrument);

            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            Rest("SQ", bpm, instrument);

            // Bar 54
            Rest("SQ", bpm, instrument);
            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            Rest("Q+SQ", bpm, instrument);

            for (int x = 0; x < 2; x++)
            {
                // Bars 55/59
                Rest("C+Q", bpm, instrument);

                // Bars 56/60
                PlayNotes("A2", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("A3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                Rest("Q+SQ", bpm, instrument);

                // Bars 57/61
                PlayNotes("E2", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("G#3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                Rest("Q+SQ", bpm, instrument);

                // Bar 58
                if (x == 0)
                {
                    PlayNotes("A2", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                    PlayNotes("E3", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                    PlayNotes("A3", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                    Rest("Q+SQ", bpm, instrument);
                }
            }

            // Bars 62-66
            for (int i = 0; i < 5; i++)
            {
                for (int x = 0; x < 6; x++)
                {
                    PlayNotes("A2", "DSQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                }
            }

            // Bar 67
            for (int i = 0; i < 6; i++)
            {
                PlayNotes("A2/D2", "DSQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
            }

            // Bar 68
            for (int i = 0; i < 6; i++)
            {
                PlayNotes("A2/Eb2", "DSQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
            }

            // Bar 69
            for (int i = 0; i < 4; i++)
            {
                PlayNotes("A2/E2", "DSQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
            }
            for (int i = 0; i < 2; i++)
            {
                PlayNotes("G#2/E2", "DSQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
            }

            // Bar 70
            PlayNotes("A2/A1", "DSQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            for (int x = 0; x < 5; x++)
            {
                PlayNotes("A2", "DSQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
            }

            // Bars 71-73
            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < 6; x++)
                {
                    PlayNotes("A2", "DSQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                }
            }

            // Bars 74-76
            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < 6; x++)
                {
                    PlayNotes("Bb2", "DSQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                }
            }

            // Bar 77
            for (int x = 0; x < 6; x++)
            {
                PlayNotes("B2", "DSQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
            }

            // Bar 78
            PlayNotes("B2", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);
            Rest("Q", bpm, instrument);

            // Bar 79
            PlayNotes("G#3/E3", "DSQ", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("C", bpm, instrument);

            // Bar 80
            PlayNotes("A1", "Q", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("Q", bpm, instrument);

            PlayNotes("E4/C4/A3", "DSQ", bpm, instrument);
            MoveForward("Q", bpm, instrument);

            // Bars 81/82
            for (int i = 0; i < 2; i++)
            {
                PlayNotes("E4/C4/A3", "DSQ", bpm, instrument);
                MoveForward("Q", bpm, instrument);
                Rest("Q", bpm, instrument);

                PlayNotes("E4/C4/A3", "DSQ", bpm, instrument);
                MoveForward("Q", bpm, instrument);
            }

            // Bar 83
            PlayNotes("E4/C4/A3", "DSQ", bpm, instrument);
            MoveForward("Q", bpm, instrument);
            Rest("C", bpm, instrument);

            // Bar 84
            Rest("C+Q", bpm, instrument);

            for (int x = 0; x < 2; x++)
            {
                // Bars 85/89
                Rest("C+Q", bpm, instrument);

                // Bars 86/90
                PlayNotes("A2", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("A3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                Rest("Q+SQ", bpm, instrument);

                // Bars 87/91
                PlayNotes("E2", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("G#3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                Rest("Q+SQ", bpm, instrument);

                // Bars 88/92
                PlayNotes("A2", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("A3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                Rest("Q+SQ", bpm, instrument);
            }

            // Bar 93
            PlayNotes("C3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("G3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("C4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            Rest("Q+SQ", bpm, instrument);

            // Bar 94
            PlayNotes("G2", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("G3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("B3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            Rest("Q+SQ", bpm, instrument);

            // Bar 95
            PlayNotes("A2", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("A3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            Rest("Q+SQ", bpm, instrument);

            // Bar 96
            PlayNotes("E2", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("A3", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            Rest("Q", bpm, instrument);

            PlayNotes("E4", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);

            // Bar 97
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            Rest("Q", bpm, instrument);

            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            Rest("SQ", bpm, instrument);

            // Bar 98
            Rest("SQ", bpm, instrument);
            PlayNotes("D#5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            PlayNotes("E5", "SQ", bpm, instrument);
            MoveForward("SQ", bpm, instrument);
            Rest("Q+SQ", bpm, instrument);

            for (int x = 0; x < 2; x++)
            {
                // Bars 99/103
                Rest("C+Q", bpm, instrument);

                // Bars 100/104
                PlayNotes("A2", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("A3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                Rest("Q+SQ", bpm, instrument);

                // Bars 101/105
                PlayNotes("E2", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("E3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                PlayNotes("G#3", "SQ", bpm, instrument);
                MoveForward("SQ", bpm, instrument);
                Rest("Q+SQ", bpm, instrument);

                // Bar 102
                if (x == 0)
                {
                    PlayNotes("A2", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                    PlayNotes("E3", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                    PlayNotes("A3", "SQ", bpm, instrument);
                    MoveForward("SQ", bpm, instrument);
                    Rest("Q+SQ", bpm, instrument);
                }
            }

            // Bar 106
            PlayNotes("A2/A1", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);
        }

        /// <summary>
        /// Plays Für Elise with both hands if available
        /// </summary>
        /// <param name="bpm">Beats per minute to play at</param>
        /// <param name="instrument">The instrument to be used</param>
        public static void PlayFurElise(int bpm, Instrument instrument)
        {
            Thread leftHand = new Thread(() => PlayFurEliseLeftHand(bpm, instrument));
            Thread rightHand = new Thread(() => PlayFurEliseRightHand(bpm, instrument));
            try
            {
                if (instrument != Instrument.ConsoleBeep)
                {
                    leftHand.Start();
                }
                else
                {
                    leftHand.Abort();
                }
                rightHand.Start();
                rightHand.Join();
                try
                {
                    leftHand.Join();
                }
                catch { }
            }
            catch (Exception ex) when (ex is ThreadAbortException || ex is ThreadInterruptedException)
            {
                leftHand.Abort();
                rightHand.Abort();
            }
        }

        /// <summary>
        /// Plays Mary had a little lamb with the right hand
        /// </summary>
        /// <param name="bpm">Beats per minute to play at</param>
        /// <param name="instrument">The instrument to be used</param>
        public static void PlayMaryHadALittleLambRightHand(int bpm, Instrument instrument)
        {
            // Bar 1
            PlayNotes("E4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);
            PlayNotes("D4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);
            PlayNotes("C4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);
            PlayNotes("D4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);

            // Bar 2
            PlayNotes("E4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);
            PlayNotes("E4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);
            PlayNotes("E4", "M", bpm, instrument);
            MoveForward("M", bpm, instrument);

            // Bar 3
            PlayNotes("D4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);
            PlayNotes("D4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);
            PlayNotes("D4", "M", bpm, instrument);
            MoveForward("M", bpm, instrument);

            // Bar 4
            PlayNotes("E4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);
            PlayNotes("G4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);
            PlayNotes("G4", "M", bpm, instrument);
            MoveForward("M", bpm, instrument);

            // Bar 5
            PlayNotes("E4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);
            PlayNotes("D4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);
            PlayNotes("C4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);
            PlayNotes("D4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);

            // Bar 6
            PlayNotes("E4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);
            PlayNotes("E4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);
            PlayNotes("E4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);
            PlayNotes("E4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);

            // Bar 7
            PlayNotes("D4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);
            PlayNotes("D4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);
            PlayNotes("E4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);
            PlayNotes("D4", "C", bpm, instrument);
            MoveForward("C", bpm, instrument);

            // Bar 8
            PlayNotes("C4", "B", bpm, instrument);
            MoveForward("B", bpm, instrument);
        }

        /// <summary>
        /// Plays Mary had a little lamb with both hands if available
        /// </summary>
        /// <param name="bpm">Beats per minute to play at</param>
        /// <param name="instrument">The instrument to be used</param>
        public static void PlayMaryHadALittleLamb(int bpm, Instrument instrument)
        {
            //Thread leftHand = new Thread(() => PlayFurEliseLeftHand(bpm, instrument));
            Thread rightHand = new Thread(() => PlayMaryHadALittleLambRightHand(bpm, instrument));
            try
            {
                if (instrument != Instrument.ConsoleBeep)
                {
                    //leftHand.Start();
                }
                else
                {
                    //leftHand.Abort();
                }
                rightHand.Start();
                rightHand.Join();
                try
                {
                    //leftHand.Join();
                }
                catch { }
            }
            catch (Exception ex) when (ex is ThreadAbortException || ex is ThreadInterruptedException)
            {
                //leftHand.Abort();
                rightHand.Abort();
            }
        }
    }
}
