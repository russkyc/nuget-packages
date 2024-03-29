﻿// MIT License
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
using System.Linq;
using Russkyc.AttachedUtilities.ConsoleExtensions.Interfaces;

namespace Russkyc.AttachedUtilities.ConsoleExtensions.Utilities
{
    public class UtilConsoleInput : IConsoleInput
    {
        public char GetChar(IOutput message)
        {
            message.Write();
            return Console.ReadLine()![0];
        }

        public List<char> GetCharCollection(IOutput message)
        {
            message.Write();
            return Console.ReadLine()!.ToList();
        }

        public string GetString(IOutput message)
        {
            message.Write();
            return Console.ReadLine();
        }

        public List<string> GetStringCollection(IOutput message)
        {
            message.Write();
            return Console.ReadLine()!.Split(new [] {' ' , ',' },StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        public int GetInt(IOutput message)
        {
            message.Write();
            return int.Parse(Console.ReadLine()!);
        }

        public List<int> GetIntCollection(IOutput message)
        {
            message.Write();
            return Console.ReadLine()!.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList()
                .Select(int.Parse).ToList();
        }

        public double GetDouble(IOutput message)
        {
            message.Write();
            return double.Parse(Console.ReadLine()!);
        }

        public List<double> GetDoubleCollection(IOutput message)
        {
            message.Write();
            return Console.ReadLine()!.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList()
                .Select(double.Parse).ToList();
        }

        public float GetFloat(IOutput message)
        {
            message.Write();
            return float.Parse(Console.ReadLine()!);
        }

        public List<float> GetFloatCollection(IOutput message)
        {
            message.Write();
            return Console.ReadLine()!.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList()
                .Select(float.Parse).ToList();
        }

        public bool GetBool(IOutput message)
        {
            message.Write();
            string answer = Console.ReadLine()!;
            return string.Equals(answer, "y", StringComparison.OrdinalIgnoreCase) || string.Equals(answer, "t", StringComparison.OrdinalIgnoreCase) || string.Equals(answer, "yes", StringComparison.OrdinalIgnoreCase) || string.Equals(answer, "true", StringComparison.OrdinalIgnoreCase) || string.Equals(answer, "1", StringComparison.OrdinalIgnoreCase);
        }

        public List<bool> GetBoolCollection(IOutput message)
        {
            message.Write();
            return Console.ReadLine()!.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList()
                .Select( s => string.Equals(s, "y", StringComparison.OrdinalIgnoreCase) || string.Equals(s, "t", StringComparison.OrdinalIgnoreCase) || string.Equals(s, "yes", StringComparison.OrdinalIgnoreCase) || string.Equals(s, "true", StringComparison.OrdinalIgnoreCase) || string.Equals(s, "1", StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}