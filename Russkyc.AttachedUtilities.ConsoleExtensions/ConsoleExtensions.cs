// MIT License
// 
// Copyright (c) 2023 Russell Camo
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Collections.Generic;
using Russkyc.AttachedUtilities.ConsoleExtensions.Interfaces;
using Russkyc.AttachedUtilities.ConsoleExtensions.Types;
using Russkyc.AttachedUtilities.ConsoleExtensions.Utilities;

namespace Russkyc.AttachedUtilities.ConsoleExtensions
{
    public static class ConsoleExtensions
    {
        private static IConsoleInput _consoleInputUtility => new UtilConsoleInput();
        private static IConsoleOutput _consoleOutputUtility => new UtilConsoleOutput();
        
        public static char GetChar(this IOutput message) => _consoleInputUtility.GetChar(message);
        public static List<char> GetCharCollection(this IOutput message) => _consoleInputUtility.GetCharCollection(message);
        public static string GetString(this IOutput message) => _consoleInputUtility.GetString(message);
        public static List<string> GetStringCollection(this IOutput message) => _consoleInputUtility.GetStringCollection(message);
        public static int GetInt(this IOutput message) => _consoleInputUtility.GetInt(message);
        public static List<int> GetIntCollection(this IOutput message) => _consoleInputUtility.GetIntCollection(message);
        public static double GetDouble(this IOutput message) => _consoleInputUtility.GetDouble(message);
        public static List<double> GetDoubleCollection(this IOutput message) => _consoleInputUtility.GetDoubleCollection(message);
        public static float GetFloat(this IOutput message) => _consoleInputUtility.GetFloat(message);
        public static List<float> GetFloatCollection(this IOutput message) => _consoleInputUtility.GetFloatCollection(message);
        public static bool GetBool(this IOutput message) => _consoleInputUtility.GetBool(message);
        public static List<bool> GetBoolCollection(this IOutput message) => _consoleInputUtility.GetBoolCollection(message);

        public static IOutput ToRichOutput(this string message) => _consoleOutputUtility.ToRichOutput(message);

        public static List<IOutput> ToRichOutput(this char[] messages) => _consoleOutputUtility.ToRichOutput(messages);
        public static List<IOutput> ToRichOutput(this string[] messages) => _consoleOutputUtility.ToRichOutput(messages);
        public static List<IOutput> ToRichOutput(this int[] messages) => _consoleOutputUtility.ToRichOutput(messages);
        public static List<IOutput> ToRichOutput(this double[] messages) => _consoleOutputUtility.ToRichOutput(messages);
        public static List<IOutput> ToRichOutput(this float[] messages) => _consoleOutputUtility.ToRichOutput(messages);
        public static List<IOutput> ToRichOutput(this bool[] messages) => _consoleOutputUtility.ToRichOutput(messages);
        public static List<IOutput> ToRichOutput(this List<char> messages) => _consoleOutputUtility.ToRichOutput(messages);
        public static List<IOutput> ToRichOutput(this List<string> messages) => _consoleOutputUtility.ToRichOutput(messages);
        public static List<IOutput> ToRichOutput(this List<int> messages) => _consoleOutputUtility.ToRichOutput(messages);
        public static List<IOutput> ToRichOutput(this List<double> messages) => _consoleOutputUtility.ToRichOutput(messages);
        public static List<IOutput> ToRichOutput(this List<float> messages) => _consoleOutputUtility.ToRichOutput(messages);
        public static List<IOutput> ToRichOutput(this List<bool> messages) => _consoleOutputUtility.ToRichOutput(messages);
        public static IOutput SetForeground(this IOutput output, Foreground foreground) => _consoleOutputUtility.SetForeground(output, (ConsoleColor)foreground);
        public static List<IOutput> SetForeground(this List<IOutput> output, Foreground foreground) => _consoleOutputUtility.SetForeground(output, (ConsoleColor)foreground);
        public static IOutput SetBackground(this IOutput output, Background background) => _consoleOutputUtility.SetBackground(output, (ConsoleColor)background);
        public static List<IOutput> SetBackground(this List<IOutput> output, Background background) => _consoleOutputUtility.SetBackground(output, (ConsoleColor)background);
        public static IOutput SetMode(this IOutput output, OutputMode mode) => _consoleOutputUtility.SetMode(output, mode);
        public static List<IOutput> SetMode(this List<IOutput> output, OutputMode mode) => _consoleOutputUtility.SetMode(output, mode);
        public static IOutput Write(this IOutput output) => _consoleOutputUtility.Write(output);
        public static IOutput WriteLine(this IOutput output) => _consoleOutputUtility.WriteLine(output);
        public static List<IOutput> WriteAll(this List<IOutput> output, string delimiter) => _consoleOutputUtility.WriteAll(output, delimiter);
    }
}