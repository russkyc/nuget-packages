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

using System.Collections.Generic;

namespace Russkyc.AttachedUtilities.ConsoleExtensions.Interfaces
{
    public interface IConsoleInput
    {
        char GetChar(IOutput message);
        List<char> GetCharCollection(IOutput message);
        string GetString(IOutput message);
        List<string> GetStringCollection(IOutput message);
        int GetInt(IOutput message);
        List<int> GetIntCollection(IOutput message);
        double GetDouble(IOutput message);
        List<double> GetDoubleCollection(IOutput message);
        float GetFloat(IOutput message);
        List<float> GetFloatCollection(IOutput message);
        bool GetBool(IOutput message);
        List<bool> GetBoolCollection(IOutput message);
    }
}