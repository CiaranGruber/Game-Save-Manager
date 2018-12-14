using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCodes
{
    /// <summary>
    /// A set of all in instruments provided
    /// </summary>
    public enum Instrument { Piano, ConsoleBeep };

    /// <summary>
    /// Provides code for all instruments
    /// </summary>
    public static class BaseInstrument
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
            { "HDSQ", 0.0625 },
        };

        /// <summary>
        /// Rests for a certain note period
        /// </summary>
        /// <param name="notePeriod">The type of note to play (duration-wise)</param>
        /// <param name="bpm">Beats per minute</param>
        /// <returns>The requested time</returns>
        public static int GetPeriod(string notePeriod, int bpm)
        {
            return (int)(LengthToInterval[notePeriod] * 60000 / bpm);
        }
    }

    /// <summary>
    /// Contains piano notes and code
    /// </summary>
    public static class Piano
    {
        /// <summary>
        /// Contains note to frequencies
        /// </summary>
        public static Dictionary<string, string> NoteToActualNote = new Dictionary<string, string>()
        {
            { "A0", "A0" }, { "A#0", "Bb0" },
            { "Bb0", "Bb0" }, { "B0", "B0" },
            { "C1", "C1" }, { "C#1", "Db1" },
            { "Db1", "Db1" }, { "D1", "D1" }, { "D#1", "Eb1" },
            { "Eb1", "Eb1" }, { "E1", "E1" },
            { "F1", "F1" }, { "F#1", "Gb1" },
            { "Gb1", "Gb1" }, { "G1", "G1" }, { "G#1", "Ab1" },
            { "Ab1", "Ab1" }, { "A1", "A1" }, { "A#1", "Bb1" },
            { "Bb1", "Bb1" }, { "B1", "B1" },
            { "C2", "C2" }, { "C#2", "Db2" },
            { "Db2", "Db2" }, { "D2", "D2" }, { "D#2", "Eb2" },
            { "Eb2", "Eb2" }, { "E2", "E2" },
            { "F2", "F2" }, { "F#2", "Gb2" },
            { "Gb2", "Gb2" }, { "G2", "G2" }, { "G#2", "Ab2" },
            { "Ab2", "Ab2" }, { "A2", "A2" }, { "A#2", "Bb2" },
            { "Bb2", "Bb2" }, { "B2", "B2" },
            { "C3", "C3" }, { "C#3", "Db3" },
            { "Db3", "Db3" }, { "D3", "D3" }, { "D#3", "Eb3" },
            { "Eb3", "Eb3" }, { "E3", "E3" },
            { "F3", "F3" }, { "F#3", "Gb3" },
            { "Gb3", "Gb3" }, { "G3", "G3" }, { "G#3", "Ab3" },
            { "Ab3", "Ab3" }, { "A3", "A3" }, { "A#3", "Bb3" },
            { "Bb3", "Eb1" }, { "B3", "B3" },
            { "C4", "C4" }, { "C#4", "Db4" },
            { "Db4", "Db4" }, { "D4", "D4" }, { "D#4", "Eb4" },
            { "Eb4", "Eb4" }, { "E4", "E4" },
            { "F4", "F4" }, { "F#4", "Gb4" },
            { "Gb4", "Gb4" }, { "G4", "G4" }, { "G#4", "Ab4" },
            { "Ab4", "Ab4" }, { "A4", "A4" }, { "A#4", "Bb4" },
            { "Bb4", "Bb4" }, { "B4", "B4" },
            { "C5", "C5" }, { "C#5", "Db5" },
            { "Db5", "Db5" }, { "D5", "D5" }, { "D#5", "Eb5" },
            { "Eb5", "Eb5" }, { "E5", "E5" },
            { "F5", "F5" }, { "F#5", "Gb5" },
            { "Gb5", "Gb5" }, { "G5", "G5" }, { "G#5", "Ab5" },
            { "Ab5", "Ab5" }, { "A5", "A5" }, { "A#5", "Bb5" },
            { "Bb5", "Bb5" }, { "B5", "B5" },
            { "C6", "C6" }, { "C#6", "Db6" },
            { "Db6", "Db6" }, { "D6", "D6" }, { "D#6", "Eb6" },
            { "Eb6", "Eb6" }, { "E6", "E6" },
            { "F6", "F6" }, { "F#6", "Gb6" },
            { "Gb6", "Gb6" }, { "G6", "G6" }, { "G#6", "Ab6" },
            { "Ab6", "Ab6" }, { "A6", "A6" }, { "A#6", "Bb6" },
            { "Bb6", "Bb6" }, { "B6", "B6" },
            { "C7", "C7" }, { "C#7", "Db7" },
            { "Db7", "Db7" }, { "D7", "D7" }, { "D#7", "Eb7" },
            { "Eb7", "Eb7" }, { "E7", "E7" },
            { "F7", "F7" }, { "F#7", "Gb7" },
            { "Gb7", "Gb7" }, { "G7", "G7" }, { "G#7", "Ab7" },
            { "Ab7", "Ab7" }, { "A7", "A7" }, { "A#7", "Bb7" },
            { "Bb7", "Bb7" }, { "B7", "B7" },
            { "C8", "C8" }
        };

        /// <summary>
        /// Plays a note
        /// </summary>
        /// <param name="note">The note to play</param>
        /// <param name="noteType">The type of note to play (duration-wise)</param>
        /// <param name="bpm">Beats per minute to play at</param>
        public static async void PlayNote(string note, string noteType, int bpm)
        {
            SoundPlayer sound = new SoundPlayer("./Piano/" + NoteToActualNote[note] + ".wav");
            sound.Play();
            await Task.Delay(BaseInstrument.GetPeriod(noteType, bpm));
            Console.WriteLine("Should Stop");
            sound.Stop();
        }
    }

    public static class ConsoleBeep
    {
        /// <summary>
        /// Contains note to frequencies
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
            Console.Beep(NoteToFrequency[note], BaseInstrument.GetPeriod(noteType, bpm));
        }
    }

    public static class Music
    {
        /// <summary>
        /// Plays a note depending on the instrument chosen
        /// </summary>
        /// <param name="note">The note to be played</param>
        /// <param name="notePeriod">The type of note (depending on length)</param>
        /// <param name="bpm">The beats per minute that the music is played at</param>
        /// <param name="instrument">The instrument being chosen</param>
        public static void PlayNote(string note, string notePeriod, int bpm, Instrument instrument)
        {
            if (instrument == Instrument.ConsoleBeep)
            {
                ConsoleBeep.PlayNote(note, notePeriod, bpm);
            }
            else if (instrument == Instrument.Piano)
            {
                Piano.PlayNote(note, notePeriod, bpm);
            }
        }

        /// <summary>
        /// Plays fur-elise
        /// </summary>
        /// <param name="bpm">Beats per minute to play at</param>
        public static async void PlayFurElise(int bpm, Instrument instrument)
        {
            // Bar 1
            PlayNote("E5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("D#5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 2
            PlayNote("E5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("D#5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("B4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("D5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("C5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 3
            PlayNote("A4", "C", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("C", bpm));
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("C4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("A4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 4
            PlayNote("B4", "C", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("C", bpm));
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("G#4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("B4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 5
            PlayNote("C5", "C", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("C", bpm));
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("D#5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 6
            PlayNote("E5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("D#5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("B4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("D5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("C5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 7
            PlayNote("A4", "C", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("C", bpm));
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("C4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("A4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 8
            PlayNote("B4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("C5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("B4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 9
            PlayNote("A4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            await Task.Delay(BaseInstrument.GetPeriod("C", bpm));
            PlayNote("E5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("D#5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 10
            PlayNote("E5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("D#5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("B4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("D5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("C5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 11
            PlayNote("A4", "C", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("C", bpm));
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("C4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("A4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 12
            PlayNote("B4", "C", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("C", bpm));
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("G#4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("B4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 13
            PlayNote("C5", "C", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("C", bpm));
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("D#5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 14
            PlayNote("E5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("D#5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("B4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("D5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("C5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 15
            PlayNote("A4", "C", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("C", bpm));
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("C4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("A4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 16
            PlayNote("B4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("C5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("B4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 17
            PlayNote("A4", "C", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("C", bpm));
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("B4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("C5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("D5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 18
            PlayNote("E5", "C", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("C", bpm));
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("G4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("F5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 19
            PlayNote("D5", "C", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("C", bpm));
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("F4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("D5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 20
            PlayNote("C5", "C", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("C", bpm));
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("D5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("C5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 21
            PlayNote("B4", "C", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("C", bpm));
            PlayNote("E4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 22
            PlayNote("E5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E6", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("D#5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("D#5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 23
            PlayNote("E5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("D#5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("B4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("D5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("C5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 24
            PlayNote("A4", "C", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("C", bpm));
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("C4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("A4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 25
            PlayNote("B4", "C", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("C", bpm));
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("G#4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("B4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 26
            PlayNote("C5", "C", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("C", bpm));
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("D#5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 27
            PlayNote("E5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("D#5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("B4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("D5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("C5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 28
            PlayNote("A4", "C", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("C", bpm));
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("C4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("A4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 29
            PlayNote("B4", "C", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("C", bpm));
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("E4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("C5", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));
            PlayNote("B4", "Q", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("Q", bpm));

            // Bar 30
            PlayNote("A4", "C", bpm, instrument);
            await Task.Delay(BaseInstrument.GetPeriod("C", bpm));
            await Task.Delay(BaseInstrument.GetPeriod("C", bpm));
        }
    }
}
