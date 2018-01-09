using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            FileDetails fileDets = new FileDetails();

            if (args.Length != 2)
            {
                Console.WriteLine("Incorrect number of arguments");
                return;
            }

            if (args[0].ToString() == "-v")
            {
                Console.WriteLine(fileDets.Version(args[1].ToString()));
                return;
            }
        }
    }
}
