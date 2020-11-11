using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace tgwTask
{
    class Program
    {

        static void Main(string[] args)
        {
            Config config = new Config();
            Console.WriteLine("Write names of config files, to finish press 0");
            Console.Write("Name of file: ");
            string file = "";
            while (!((file = Console.ReadLine()).Equals("0")))//reads file names until 0 is pressed
            {
                string textFile = "..\\..\\..\\" + file;
                Read(textFile, config);
            }

            RequestInfo(config);
            

        }

        public static void Read(string inputFile, Config config)
        {
            using(StreamReader file = new StreamReader(inputFile))
            {
                string ln;
                //Config config = new Config();
                file.ReadLine();
                while ((ln = file.ReadLine()) != null){
                    //skip empty lines and lines that start with symbols
                    if(ln.Length == 0  || !Char.IsLetter(ln[0]))
                    {
                        continue;
                    }

                    ln = Regex.Replace(ln, "//.*", "");//delete comments
                    ln = Regex.Replace(ln, "\t", "");//delete tabs

                    string[] data = ln.Split(':');//cant split datetime
                    string tst = ln.Substring(ln.IndexOf(":") + 1);

                    config.AssignValue(data[0], tst);
                }
            }
        }

        public static void RequestInfo(Config config)
        {
            Console.WriteLine("Request config-id that you want to be loaded. Requesting \"All\" loads all config_ids. To finish press 0.");
            string request = "";
            while (!((request = Console.ReadLine()).Equals("0")))//reads config ids until 0 is pressed
            {
                config.WriteConfigInfo(request);
            }
        }
    }
}
