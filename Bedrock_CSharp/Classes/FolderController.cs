using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bedrock_CSharp
{
    class FolderController
    {   
        //Add a new folder to @param rootDirectoryPath and refresh the treeViewFiles tree to display the changes in the GUI.
        public static void CreateNewFolder(TreeNode selectedNode, String folderName)
        {
            String rootDirectoryPath = @"C:\Users\username\Desktop\";
            string directoryPath = Path.Combine(rootDirectoryPath, selectedNode.FullPath);

            if (checkForInvalidChars(folderName) == false)
            {
                if (directoryContainsKey(directoryPath, folderName) == false)
                {
                    String pathString = Path.Combine(directoryPath, folderName);
                    Directory.CreateDirectory(pathString);
                    MessageBox.Show("Folder created: " + folderName);
                }
                else
                {
                    MessageBox.Show("Folder already exists");
                }
                
            }
            else
            {
                MessageBox.Show("Invalid character in folder name");
            }
        }

        //TODO
        private void RemoveFolder(String path)
        {
            //remove the folder with @param path and then refresh the treeViewFiles tree to display the changes in the GUI.
        }

        public static void RenameFolder(TreeNode selectedNode, String folderName)
        {
            if (checkForInvalidChars(folderName) == false)
            {
                String rootDirectoryPath = @"C:\Users\username\Desktop\";
                string directoryPath = Path.Combine(rootDirectoryPath, selectedNode.Parent.FullPath);
                if (directoryContainsKey(directoryPath, folderName) == false)
                {
                    DirectoryInfo directory = new DirectoryInfo(directoryPath);
                    foreach (var dir in directory.GetDirectories())
                    {
                        if (dir.Name == selectedNode.Text)
                        {
                            MessageBox.Show(dir.FullName + ">>" + directoryPath + "\\" + folderName);
                            Directory.Move(dir.FullName, directoryPath + "\\" + folderName);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Folder with name \"" + folderName + "\" already exists");
                } 
            }
            else
            {
                MessageBox.Show("name contains invalid characters");
            }
        }

        //TODO
        //A getter method that returns a path string to a chosen folder.
        public String GetFolderPath()
        {
            return "";
        }

        public static bool checkForInvalidChars(String folderName)
        {
            string[] invalidChar = new string[9];
            invalidChar[0] = "/";
            invalidChar[1] = ":";
            invalidChar[2] = "*";
            invalidChar[3] = "?";
            invalidChar[4] = '"'.ToString();
            invalidChar[5] = "<";
            invalidChar[6] = ">";
            invalidChar[7] = "|";
            invalidChar[8] = "\\";

            for (int i = 0; i < invalidChar.Length; i++)
            {
                if (folderName.Contains(invalidChar[i]))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool directoryContainsKey(String path, String name)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            foreach (var dir in directory.GetDirectories())
            {
                if (dir.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
