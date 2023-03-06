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
using System.Diagnostics;
using Russkyc.AttachedUtilities.ConsoleExtensions.Interfaces;
using Russkyc.AttachedUtilities.ConsoleExtensions.Types;

namespace Russkyc.AttachedUtilities.ConsoleExtensions.Utilities
{
    public static class UtilOutput
    {
        public static void Colorize(ConsoleColor foreground, ConsoleColor background)
        {
            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
        }

        public static void Write(IOutput output)
        {
            if (output.Mode == OutputMode.Console) Console.Write(output.Message);
            if (output.Mode == OutputMode.Debug) Debug.Write(output.Message);
        }
        
        public static void WriteLine(IOutput output)
        {
            if (output.Mode == OutputMode.Console) Console.WriteLine(output.Message);
            if (output.Mode == OutputMode.Debug) Debug.WriteLine(output.Message);
        }
    }
}