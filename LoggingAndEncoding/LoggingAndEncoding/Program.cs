using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

namespace LoggingAndEncoding
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //var name = Console.ReadLine();
            //Console.WriteLine($"Hello, {name}, it is now {DateTime.Now}");


            //string text = "Hello out there";
            //File.WriteAllText("Hello.txt", text);
            //string readText = File.ReadAllText("Hello.txt");
            //Console.WriteLine(readText);
            //File.AppendAllText("Hello.txt", text);


            //string[] lines = { "Mary had a little lamb", "Its fleece was white as snow", "Everywhere that Mary went", "The lamb was sure to go" };
            //File.WriteAllLines("Mary.txt", lines);
            //string[] readLines = File.ReadAllLines("Mary.txt");
            //foreach (var line in readLines)
            //{
            //    Console.WriteLine(line);
            //}
            //Debug.WriteLine("Debug - this is a debug item");
            //Trace.WriteLine("Trace - this is a trace item");


            //Console.WriteLine($"This is being logged at time {DateTime.Now}");
            //TextWriterTraceListener twtl = new
            //TextWriterTraceListener(File.Create("TraceOutput.txt"));
            //Trace.Listeners.Add(twtl);
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(i);
            //    Debug.WriteLine($"Debug - the value of i is {i}");
            //    Trace.WriteLine($"Trace - the value of i is {i}");
            //    Debug.WriteLineIf(i == 2, $"\nReached maximum value of i: {i} at {DateTime.Now}");
            //    Trace.Assert(i > 0, $"is is not greater than zero: {i}");
            //}
            //Trace.Flush();

            //#if DEBUG
            //            Console.WriteLine("This is debug code");
            //#endif
            //#if TEST
            //            Console.WriteLine("This is a test");
            //#endif

            String path = @"LiveForever.txt";
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Live - Forever");
            }
            using (StreamReader sr = File.OpenText(path))
            {
                String s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
