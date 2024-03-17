using System;
using System.IO;

namespace DelegateBasicExample
{
    class Programm
    {
        delegate void LogDel(string text);
        static void Main(string[] args)
        {
            Log log = new Log();
            LogDel logDel = new LogDel(log.LogTextToFile);
            Console.WriteLine("Please enter your name: ");
            var name = Console.ReadLine();

            logDel(name);
            Console.ReadKey();
            
        }

    }

    public class Log
    {

        public void LogTextToScreen(string text)
        {
            Console.WriteLine($"{DateTime.Now} : {text}");
        }

        public void LogTextToFile(string text)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.text"), true))
            {
                sw.WriteLine($"{DateTime.Now} : {text}");
            }
        }
    }
}