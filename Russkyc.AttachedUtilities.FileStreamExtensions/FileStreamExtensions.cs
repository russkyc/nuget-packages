// MIT License
// 
// Copyright (c) 2022 Russell Camo
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
using System.IO;
using System.Linq;

namespace Russkyc.AttachedUtilities.FileStreamExtensions
{
    /// <summary>
    /// Handles FileStreamExtension Extension Methods.
    /// </summary>
    public static class FileStreamExtensions
    {
        
        /// <summary>
        /// An extension method to create files using FileStream StreamWriter.
        /// </summary>
        /// <example>
        /// <code>
        /// string path = @"C:/TestFile.txt";
        /// path.StreamCreate();
        /// </code>
        /// </example>
        /// <param name="path">Path to file.</param>
        /// <returns>Filepath value of type: string.</returns>
        public static string StreamCreate(this string path)
        {
            using FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
            using StreamWriter writer = new StreamWriter(stream);
            writer.Write("");
            return path;
        }
        
        /// <summary>
        /// An extension method to write content to files using FileStream StreamWriter.
        /// </summary>
        /// <example>
        /// <code>
        /// string path = @"C:/TestFile.txt";
        /// path.StreamWrite("This is written using C#!");
        /// </code>
        /// </example>
        /// <param name="path">Path to file.</param>
        /// <param name="content">Content to write to file.</param>
        /// <returns>Filepath value of type: string.</returns>
        public static string StreamWrite(this string path, string content)
        {
            using FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
            using StreamWriter writer = new StreamWriter(stream);
            writer.Write(content);
            return path;
        }
        
        /// <summary>
        /// An extension method to append content to files using FileStream StreamWriter.
        /// </summary>
        /// <example>
        /// <code>
        /// string path = @"C:/TestFile.txt";
        /// path.StreamAppendWrite("This is written using C#!");
        /// </code>
        /// </example>
        /// <param name="path">Path to file.</param>
        /// <param name="content">Content to write to file.</param>
        /// <returns>Filepath value of type: string.</returns>
        public static string StreamAppend(this string path, string content)
        {
            using FileStream stream = new FileStream(path, FileMode.Append, FileAccess.Write);
            using StreamWriter writer = new StreamWriter(stream);
            writer.Write(content);
            return path;
        }
        
        /// <summary>
        /// An extension method to write lines to file using FileStream StreamWriter.
        /// </summary>
        /// <example>
        /// <code>
        /// string path = @"C:/TestFile.txt";
        /// string[] lines = { "Line 1", "Line 2", "Line 3" };
        /// path.StreamWriteLines(lines);
        /// </code>
        /// </example>
        /// <param name="path">Path file.</param>
        /// <param name="content">Array of content to write to file</param>
        /// <returns>Filepath value of type: string.</returns>
        public static string StreamWriteLines(this string path, string[] content)
        {
            using FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
            using StreamWriter writer = new StreamWriter(stream);
            foreach (string line in content) writer.WriteLine(line);
            return path;
        }
        
        /// <summary>
        /// An extension method to write lines to file using FileStream StreamWriter.
        /// </summary>
        /// <example>
        /// <code>
        /// string path = @"C:/TestFile.txt";
        /// List<string> lines = new List<string>{ "Line 1", "Line 2", "Line 3" };
        /// path.StreamWriteLines(lines);
        /// </code>
        /// </example>
        /// <param name="path">Path file.</param>
        /// <param name="content">Array of content to write to file</param>
        /// <returns>Filepath value of type: string.</returns>
        public static string StreamWriteLines(this string path, List<string> content)
        {
            using FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
            using StreamWriter writer = new StreamWriter(stream);
            content.ForEach(writer.WriteLine);
            return path;
        }
        
        /// <summary>
        /// An extension method to append lines to files using FileStream Stream
        /// </summary>
        /// <example>
        /// <code>
        /// string path = @"C:/TestFile.txt";
        /// string[] lines = { "Line 1", "Line 2", "Line 3" };
        /// path.StreamAppendWriteLines(lines);
        /// </code>
        /// </example>
        /// <param name="path">Path file.</param>
        /// <param name="content">Array of content to write to file</param>
        /// <returns>Filepath value of type: string.</returns>
        public static string StreamAppendLines(this string path, string[] content)
        {
            using FileStream stream = new FileStream(path, FileMode.Append, FileAccess.Write);
            using StreamWriter writer = new StreamWriter(stream);
            foreach (string line in content) writer.WriteLine(line);
            return path;
        }
        
        /// <summary>
        /// An extension method to append lines to files using FileStream Stream
        /// </summary>
        /// <example>
        /// <code>
        /// string path = @"C:/TestFile.txt";
        /// List<string> lines = new List<string>{ "Line 1", "Line 2", "Line 3" };
        /// path.StreamAppendWriteLines(lines);
        /// </code>
        /// </example>
        /// <param name="path">Path file.</param>
        /// <param name="content">Array of content to write to file</param>
        /// <returns>Filepath value of type: string.</returns>
        public static string StreamAppendLines(this string path, List<string> content)
        {
            using FileStream stream = new FileStream(path, FileMode.Append, FileAccess.Write);
            using StreamWriter writer = new StreamWriter(stream);
            content.ForEach(writer.WriteLine);
            return path;
        }
        
        /// <summary>
        /// An extension method to read file content using FileStream StreamReader.
        /// </summary>
        /// <example>
        /// <code>
        /// string path = @"C:/TestFile.txt";
        /// string message = path.StreamRead();
        /// </code>
        /// </example>
        /// <param name="path">Path to file.</param>
        /// <returns>File Content value of type: string.</returns>
        public static string StreamRead(this string path)
        {
            using FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            using StreamReader reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }
        
        /// <summary>
        /// An extension method to read files and split content by lines.
        /// </summary>
        /// <example>
        /// <code>
        /// string path = @"C:/TestFile.txt";
        /// string[] records = path.StreamReadLines();
        /// </code>
        /// </example>
        /// <param name="path">Path to file.</param>
        /// <returns>File Content value of type: string[].</returns>
        public static string[] StreamReadLines(this string path)
        {
            using FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            using StreamReader reader = new StreamReader(stream);
            List<string> lines = new List<string>();
            while (reader.ReadLine() is { } line) lines.Add(line);
            return lines.ToArray();
        }
        
        /// <summary>
        /// An extension method to read files and split content by lines.
        /// </summary>
        /// <example>
        /// <code>
        /// string path = @"C:/TestFile.txt";
        /// List<string> records = path.StreamListLines();
        /// </code>
        /// </example>
        /// <param name="path">Path to file.</param>
        /// <returns>File Content value of type: List<string>.</returns>
        public static List<string> StreamListLines(this string path)
        {
            using FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            using StreamReader reader = new StreamReader(stream);
            List<string> lines = new List<string>();
            while (reader.ReadLine() is { } line) lines.Add(line);
            return lines;
        }
        
        /// <summary>
        /// An extension method to read files and split content to string array.
        /// </summary>
        /// <example>
        /// <code>
        /// string path = @"C:/TestFile.txt";
        /// string[] records = path.StreamReadSplit();
        /// </code>
        /// </example>
        /// <param name="path">Path to file.</param>
        /// <param name="separator">A character, or collection of characters that splits the string</param>
        /// <returns>File Content value of type: string[].</returns>
        public static string[] StreamReadSplit(this string path, params char[] separator)
        {
            using FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            using StreamReader reader = new StreamReader(stream);
            return separator.Equals(null) ? reader.ReadToEnd().Split() : reader.ReadToEnd().Split(separator);
        }
        
        /// <summary>
        /// An extension method to read files and split content to string list.
        /// </summary>
        /// <example>
        /// <code>
        /// string path = @"C:/TestFile.txt";
        /// List<string> records = path.StreamReadSplit();
        /// </code>
        /// </example>
        /// <param name="path">Path to file.</param>
        /// <param name="separator">A character, or collection of characters that splits the string</param>
        /// <returns>File Content value of type: List<string>.</returns>
        public static List<String> StreamListSplit(this string path, params char[] separator)
        {
            using FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            using StreamReader reader = new StreamReader(stream);
            return separator.Equals(null) ? reader.ReadToEnd().Split().ToList() : reader.ReadToEnd().Split(separator).ToList();
        }
    }
}