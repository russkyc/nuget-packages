using System;
using System.IO;
using Russkyc.AttachedUtilities.FileStreamExtensions;
using Xunit;
namespace NETFrameworkTests
{
    public class Tests
    {

        // Test Create File
        [Theory]
        [InlineData(@"C:\Users\Russell\Desktop\NewFile.txt")]
        [InlineData(@"C:\Users\Russell\Desktop\TestFile2.rus")]
        [InlineData(@"C:\Users\Russell\Desktop\TestFile2")]
        public void TestCreateFile(string filePath)
        {
            filePath.StreamCreate();
            Assert.True(File.Exists(filePath));
        }

        // Test Write and Read File
        [Theory]
        [InlineData(@"C:\Users\Russell\Desktop\NewFile.txt","Content 1")]
        [InlineData(@"C:\Users\Russell\Desktop\TestFile2.rus", "Content 2")]
        [InlineData(@"C:\Users\Russell\Desktop\TestFile2", "Content 3")]
        public void TestWriteAndReadTextToFile(String filePath, string content)
        {
            filePath.StreamWrite(content);
            Assert.Equal(content,filePath.StreamRead());
        }
        
        // Test Append and Read File
        [Theory]
        [InlineData(@"C:\Users\Russell\Desktop\NewFile.txt","Content 1","New Content")]
        [InlineData(@"C:\Users\Russell\Desktop\TestFile2.rus", "Content 2","New Content")]
        [InlineData(@"C:\Users\Russell\Desktop\TestFile2", "Content 3","New Content")]
        public void TestAppendAndReadTextToFile(String filePath, string content, string appendedContent)
        {
            filePath.StreamWrite(content);
            filePath.StreamAppend(appendedContent);
            Assert.Equal(content+appendedContent,filePath.StreamRead());
        }
        
        // Test Write Lines to File and Read Lines
        [Theory]
        [InlineData(@"C:\Users\Russell\Desktop\NewFile.txt",new []{"a","b"},2)]
        [InlineData(@"C:\Users\Russell\Desktop\TestFile2.rus", new []{"a","b","c"},3)]
        [InlineData(@"C:\Users\Russell\Desktop\TestFile2", new []{"a","b","c","d"},4)]
        public void TestWriteToFileAndReadLinesAsStringArray(String filePath, string[] content, int count)
        {
            filePath.StreamWriteLines(content);
            Assert.Equal(count,filePath.StreamReadLines().Length);
        }
        
        // Test Append Lines to File and Read Lines
        [Theory]
        [InlineData(@"C:\Users\Russell\Desktop\NewFile.txt", new []{"a"}, new []{"a"},2)]
        [InlineData(@"C:\Users\Russell\Desktop\TestFile2.rus", new []{"a","b"}, new []{"a"},3)]
        [InlineData(@"C:\Users\Russell\Desktop\TestFile2", new []{"a","b"},new []{"a","a"},4)]
        public void TestAppendLinesToFileAndReadLines(String filePath, string[] content, string[] appendedContent, int count)
        {
            filePath.StreamWriteLines(content);
            filePath.StreamAppendLines(appendedContent);
            Assert.Equal(count,filePath.StreamReadLines().Length);
        }
        
        // Test Write Lines to File and Read Lines
        [Theory]
        [InlineData(@"C:\Users\Russell\Desktop\NewFile.txt", new []{"a","b"},2)]
        [InlineData(@"C:\Users\Russell\Desktop\TestFile2.rus", new []{"a","b","c"},3)]
        [InlineData(@"C:\Users\Russell\Desktop\TestFile2", new []{"a","b","c","d"},4)]
        public void TestWriteToFileAndReadLinesAsListOfString(String filePath, string[] content, int count)
        {
            filePath.StreamWriteLines(content);
            Assert.Equal(count,filePath.StreamListLines().Count);
        }
        
        // Test Write Lines to File, Read and Split Content to Array
        [Theory]
        [InlineData(@"C:\Users\Russell\Desktop\NewFile.txt","a b c",3, new char[]{})]
        [InlineData(@"C:\Users\Russell\Desktop\TestFile2.rus", "a,b,c,d",4,new []{','})]
        [InlineData(@"C:\Users\Russell\Desktop\TestFile2", "a?b,c:d!e",5,new []{':',',','?','!'})]
        public void TestWriteToFileAndReadSplitsAsStringArray(String filePath, string content, int count, params char[] separator)
        {
            filePath.StreamWrite(content);
            Assert.Equal(count,filePath.StreamReadSplit(separator).Length);
        }
        
        // Test Write Lines to File, Read and Split Content to List
        [Theory]
        [InlineData(@"C:\Users\Russell\Desktop\NewFile.txt","a b c",3, new char[]{})]
        [InlineData(@"C:\Users\Russell\Desktop\TestFile2.rus", "a,b,c,d",4,new []{','})]
        [InlineData(@"C:\Users\Russell\Desktop\TestFile2", "a?b,c:d!e",5,new []{':',',','?','!'})]
        public void TestWriteToFileAndReadSplitsAsListOfString(String filePath, string content, int count, params char[] separator)
        {
            filePath.StreamWrite(content);
            Assert.Equal(count,filePath.StreamListSplit(separator).Count);
        }
        
    }
}