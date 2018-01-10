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
            String [] versionSwitch = {"-v", "--v", "/v", "--version"};
            String [] sizeSwitch = { "-s", "--s", "/s", "--size" };

            FileDetails fileDets = new FileDetails();

            if (args.Length != 2)
            {
                Console.WriteLine("Incorrect number of arguments");
                return;
            }

            if (versionSwitch.Contains(args[0].ToString()))
            {
                Console.WriteLine(fileDets.Version(args[1].ToString()));
                return;
            }

            if (sizeSwitch.Contains(args[0].ToString()))
            {
                Console.WriteLine(fileDets.Size(args[1].ToString()));
                return;
            }
        }
    }
}
