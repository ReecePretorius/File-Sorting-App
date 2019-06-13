using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bedrock_CSharp.Classes
{
    class FileController
    {
        private static int low = 10000;
        private static int high = 99999;

        public static void RenameFile()
        {
            //TODO
        }

        public static void DeleteFile()
        {
            //TODO
        }

        public static void AddFile()
        {
            //TODO
        }

        public static string GenerateFileName(string currentDirectory)
        {
            //TODO: needs to check the directory to see if there is already a file with the returned/generated name.
            //Current method to do this is ineficient and can be improved using a proper search algorithm.
            String name = RandomNumGen().ToString();

            if (checkName(currentDirectory, name))
            {
                GenerateFileName(currentDirectory);
            }
            else
            {
                MessageBox.Show("genrated name is: " + name);
            }
            return name;
        }

        //Helper methods
        private static Boolean checkName(string currentDirectory, string name)
        {
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            FileInfo[] files = directory.GetFiles();

            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].Name.Contains(name))
                {
                    return true;
                }
            }
            return false;
        }

        private static int RandomNumGen()
        {
            int num;
            Random rand = new Random();
            num = rand.Next(low, high);
            return num;
        }
    }
}
