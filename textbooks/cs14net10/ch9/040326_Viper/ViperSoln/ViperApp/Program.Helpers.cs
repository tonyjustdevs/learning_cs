using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

using TPNS.SharedLibrary;

partial class Program
{
    static void GetFileInfo(string file_path)
    {

        // add using (stream)
        WriteLine($"Name: {GetFileName(file_path)}");
        WriteLine($"Dir: {GetDirectoryName(file_path)}");
        WriteLine($"Size: {new FileInfo(file_path).Length:N0}");
        WriteLine($"-----------------------------------------------");
        string file_str = File.ReadAllText(file_path);
        WriteLine($"{file_str}");
        WriteLine($"-----------------------------------------------");
        WriteLine($"Length: {file_str.Length}");
        WriteLine($"Count: {file_str.Count()}");

    }

    //static void ReadFirst8Bytes(string file_path)
    //{
    //    // create stream to file
    //    FileStream file_stream = File.OpenRead(file_path);
    //    // read bytes from stream
    //    Span<byte> span_buffer = new byte[8];
    //    file_stream.ReadExactly(span_buffer);

    //    WriteLine($"span_buffer: ");
    //    foreach (var buf in span_buffer)
    //    {
    //        WriteLine($"{buf:X}");
    //    }
    //}

    static void ReadFirst8Bytes(string filePath)
    {
        using FileStream fileStream = File.OpenRead(filePath);

        Span<byte> buffer = stackalloc byte[8];
        fileStream.ReadExactly(buffer);

        PrintBytes(buffer);
    }

    static void PrintBytes(ReadOnlySpan<byte> bytes)
    {
        foreach (byte b in bytes)
        {
            Console.WriteLine($"{b:X2}");
        }
    }
}
//
//byte[] firstThree = bytes[0..3];  // first 3 bytes
//byte[] withoutBom = bytes[3..];   // start at index 3 to go to end
//byte[] withoutBom = bytes[3..];
//byte[] allExceptLastThree = bytes[..^3]; start at 0 to stop 3 from the end
//Span<byte> span = bytes;
//Span<byte> firstThree = span[0..3]; // That creates a view, not a copy.

//struct MyStruct
//{
//    public IntPtr somePtr;
//    public int someLength;
//}