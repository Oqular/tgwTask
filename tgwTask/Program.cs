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

            //take multiple file, until 0 is pressed
            Console.Write("Name of file: ");
            string file = Console.ReadLine();

            string textFile = "..\\..\\..\\" + file;
            Read(textFile, config);

            Console.WriteLine("Request config-id that you want to be loaded. Requesting \"All\" loads all config_ids. To finish press 0.");
            string request = "";
            while (!((request = Console.ReadLine()).Equals("0")))//reads config ids until 0 is pressed
            {
                config.writeConfigInfo(request);
            }

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
                    config.assignValue(data[0], tst);
                    //Console.WriteLine("{0}: {1}", data[0], tst);
                }
            }
        }
    }
}
