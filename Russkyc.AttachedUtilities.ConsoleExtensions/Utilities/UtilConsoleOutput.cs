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
using System.Globalization;
using System.Linq;
using Russkyc.AttachedUtilities.ConsoleExtensions.Interfaces;
using Russkyc.AttachedUtilities.ConsoleExtensions.Types;

namespace Russkyc.AttachedUtilities.ConsoleExtensions.Utilities
{
    public class UtilConsoleOutput : IConsoleOutput
    {
        public IOutput ToRichOutput(string message)
        {
            return new Output
            {
                Message = message,
                Mode = OutputMode.Console,
                Foreground = Console.ForegroundColor,
                Background = Console.BackgroundColor,
                DefaultForeground = Console.ForegroundColor,
                DefaultBackground = Console.BackgroundColor
            };
        }

        public List<IOutput> ToRichOutput(char[] message)
        {
            return message.ToList().ConvertAll(o => o.ToString()).ToRichOutput();
        }

        public List<IOutput> ToRichOutput(string[] message)
        {
            return message.ToList().ConvertAll(ToRichOutput);
        }

        public List<IOutput> ToRichOutput(int[] message)
        {
            return message.ToList().ConvertAll(o => o.ToString()).ToRichOutput();
        }

        public List<IOutput> ToRichOutput(double[] message)
        {
            return message.ToList().ConvertAll(o => o.ToString(CultureInfo.CurrentCulture)).ToRichOutput();
        }

        public List<IOutput> ToRichOutput(float[] message)
        {
            return message.ToList().ConvertAll(o => o.ToString(CultureInfo.InvariantCulture)).ToRichOutput();
        }

        public List<IOutput> ToRichOutput(bool[] message)
        {
            return message.ToList().ConvertAll(o => o.ToString()).ToRichOutput();
        }

        public List<IOutput> ToRichOutput(List<char> message)
        {
            return message.ToList().ConvertAll(o => o.ToString()).ToRichOutput();
        }

        public List<IOutput> ToRichOutput(List<string> message)
        {
            return message.ConvertAll(ToRichOutput);
        }

        public List<IOutput> ToRichOutput(List<int> message)
        {
            return message.ConvertAll(o => o.ToString()).ToRichOutput();
        }

        public List<IOutput> ToRichOutput(List<double> message)
        {
            return message.ConvertAll(o => o.ToString()).ToRichOutput();
        }

        public List<IOutput> ToRichOutput(List<float> message)
        {
            return message.ConvertAll(o => o.ToString()).ToRichOutput();
        }

        public List<IOutput> ToRichOutput(List<bool> message)
        {
            return message.ConvertAll(o => o.ToString()).ToRichOutput();
        }

        public IOutput SetForeground(IOutput output, ConsoleColor foreground)
        {
            output.Foreground = foreground;
            return output;
        }

        public List<IOutput> SetForeground(List<IOutput> output, ConsoleColor foreground)
        {
            output.ForEach(o => o.Foreground = foreground);
            return output;
        }

        public IOutput SetBackground(IOutput output, ConsoleColor background)
        {
            output.Background = background;
            return output;
        }

        public List<IOutput> SetBackground(List<IOutput> output, ConsoleColor background)
        {
            output.ForEach(o => o.Background = background);
            return output;
        }

        public IOutput SetMode(IOutput output, OutputMode mode)
        {
            output.Mode = mode;
            return output;
        }

        public List<IOutput> SetMode(List<IOutput> output, OutputMode mode)
        {
            output.ForEach(o => o.Mode = mode);
            return output;
        }

        public IOutput Write(IOutput output)
        {
            UtilOutput.Colorize(output.Foreground, output.Background);
            UtilOutput.Write(output);
            UtilOutput.Colorize(output.DefaultForeground, output.DefaultBackground);
            return output;
        }

        public IOutput WriteLine(IOutput output)
        {
            UtilOutput.Colorize(output.Foreground, output.Background);
            UtilOutput.WriteLine(output);
            UtilOutput.Colorize(output.DefaultForeground, output.DefaultBackground);
            return output;
        }

        public List<IOutput> WriteAll(List<IOutput> output, string delimiter)
        {
            output.ForEach(
                o =>
                {
                    UtilOutput.Colorize(o.Foreground,o.Background);
                    UtilOutput.Write(o);
                    UtilOutput.Write(
                        new Output
                        {
                            Message = delimiter,
                            Foreground = o.Foreground,
                            Background = o.Background,
                            DefaultForeground = o.DefaultForeground,
                            DefaultBackground = o.DefaultBackground,
                            Mode = o.Mode
                        });
                    UtilOutput.Colorize(o.DefaultForeground,o.DefaultBackground);
                });
            return output;
        }
    }
}