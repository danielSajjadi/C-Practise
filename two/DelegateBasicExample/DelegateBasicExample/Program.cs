using System;
using System.IO;

namespace DelegateBasicExample
{
    class Programm
    {
        delegate void LogDel(string text);
        static void Main(string[] args)
        {
            LogDel logDel = new LogDel(LogTextToFile);
            Console.WriteLine("Please enter your name: ");
            var name = Console.ReadLine();

            logDel(name);
            Console.ReadKey();
            
        }

        static void LogTextToScreen(string text)
        {
            Console.WriteLine($"{DateTime.Now} : {text}");
        }

        static void LogTextToFile(string text)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.text"), true))
            {
                sw.WriteLine($"{DateTime.Now} : {text}");
            }
        }
    }
}