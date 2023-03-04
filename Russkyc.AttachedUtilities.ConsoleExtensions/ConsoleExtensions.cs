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

using System.Collections.Generic;
using Russkyc.AttachedUtilities.ConsoleExtensions.Interfaces;
using Russkyc.AttachedUtilities.ConsoleExtensions.Utilities;

namespace Russkyc.AttachedUtilities.ConsoleExtensions
{
    public static class ConsoleExtensions
    {
        private static IConsoleInput _consoleInputUtility => new UtilConsoleInput();
        public static char GetChar(this string message) => _consoleInputUtility.GetChar(message);
        public static List<char> GetCharCollection(this string message) => _consoleInputUtility.GetCharCollection(message);
        public static string GetString(this string message) => _consoleInputUtility.GetString(message);
        public static List<string> GetStringCollection(this string message) => _consoleInputUtility.GetStringCollection(message);
        public static int GetInt(this string message) => _consoleInputUtility.GetInt(message);
        public static List<int> GetIntCollection(this string message) => _consoleInputUtility.GetIntCollection(message);
        public static double GetDouble(this string message) => _consoleInputUtility.GetDouble(message);
        public static List<double> GetDoubleCollection(this string message) => _consoleInputUtility.GetDoubleCollection(message);
        public static float GetFloat(this string message) => _consoleInputUtility.GetFloat(message);
        public static List<float> GetFloatCollection(this string message) => _consoleInputUtility.GetFloatCollection(message);
        public static bool GetBool(this string message) => _consoleInputUtility.GetBool(message);
        public static List<bool> GetBoolCollection(this string message) => _consoleInputUtility.GetBoolCollection(message);
    }
}