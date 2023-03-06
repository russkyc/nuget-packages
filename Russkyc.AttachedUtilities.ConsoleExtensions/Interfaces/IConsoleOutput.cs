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
using Russkyc.AttachedUtilities.ConsoleExtensions.Types;

namespace Russkyc.AttachedUtilities.ConsoleExtensions.Interfaces
{
    public interface IConsoleOutput
    {
        IOutput ToRichOutput(string message);
        List<IOutput> ToRichOutput(char[] message);
        List<IOutput> ToRichOutput(string[] message);
        List<IOutput> ToRichOutput(int[] message);
        List<IOutput> ToRichOutput(double[] message);
        List<IOutput> ToRichOutput(float[] message);
        List<IOutput> ToRichOutput(bool[] message);
        List<IOutput> ToRichOutput(List<char> message);
        List<IOutput> ToRichOutput(List<string> message);
        List<IOutput> ToRichOutput(List<int> message);
        List<IOutput> ToRichOutput(List<double> message);
        List<IOutput> ToRichOutput(List<float> message);
        List<IOutput> ToRichOutput(List<bool> message);
        IOutput SetForeground(IOutput output, ConsoleColor foreground);
        List<IOutput> SetForeground(List<IOutput> output, ConsoleColor foreground);
        IOutput SetBackground(IOutput output, ConsoleColor background);
        List<IOutput> SetBackground(List<IOutput> output, ConsoleColor background);
        IOutput SetMode(IOutput output, OutputMode mode);
        List<IOutput> SetMode(List<IOutput> output, OutputMode mode);
        IOutput Write(IOutput output);
        IOutput WriteLine(IOutput output);
        List<IOutput> WriteAll(List<IOutput> output, string delimiter);
    }
}