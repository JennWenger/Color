/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LearningLine.Practice
{
    static class Program
    {

        static void Main(string[] args)
        {
            FolderInfo folder = new FolderInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            FolderBrowser browser = new FolderBrowser(folder);

            while (true)
            {
                Console.Clear();
                ColorConsole.WriteLine(folder.GetDescription());

                string[] subFolders = browser.GetSubFolders();
                for (int i = 0; i < subFolders.Length; i++)
                {
                    string dirName = new DirectoryInfo(subFolders[i]).Name;
                    ColorConsole.WriteLine(String.Format("{0}\t{1}", i, dirName));
                }

                ColorConsole.WriteLine("Type a subfolder number or press Enter to move to the parent folder.", ConsoleColor.DarkGray);
                ColorConsole.Write("> ");
                string input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                {
                    browser.MoveUpToParentFolder();
                    folder = browser.GetCurrentFolder();
                }
                else
                {
                    int selection = Int32.Parse(input);
                    folder = new FolderInfo(subFolders[selection]);
                    browser = new FolderBrowser(folder);
                }
            }
        }

        public class Person
        {
            public string FirstName;
            public string LastName;
            public int Age;
            public int Weight;

            public string FullName()
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
            public void ShowPerson()
            {
                Console.WriteLine("Person \"{0} {1}\" is {2} years old and {3}lbs.", FirstName, LastName, Age, Weight);
                Console.WriteLine("{0} is {1}", FullName(), Age);
            }
        }

    static void Main(string[] args)
        {
            FolderInfo folder = new FolderInfo(Environment.GetFolderPath(
                  Environment.SpecialFolder.MyDocuments));

            FolderBrowser browser = new FolderBrowser(folder);

            while (true)
            {
                Console.Clear();
                ColorConsole.WriteLine(folder.GetDescription());

                string[] subFolders = browser.GetSubFolders();
                for (int i = 0; i < subFolders.Length; i++)
                {
                    string dirName = new DirectoryInfo(subFolders[i]).Name;
                    ColorConsole.WriteLine(String.Format("{0}\t{1}", i, dirName));
                }

                ColorConsole.WriteLine(
                   "Type a subfolder number or press Enter to move to the parent folder.",
                    ConsoleColor.DarkGray);
                ColorConsole.Write("> ");
                string input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                {
                    browser.MoveUpToParentFolder();
                    folder = browser.GetCurrentFolder();
                }
                else
                {
                    int selection = Int32.Parse(input);
                    folder = new FolderInfo(subFolders[selection]);
                    browser = new FolderBrowser(folder);
                }
            }
        }*/

        //static void Main(string[] args)
        //{
        //    Person p = new Person();
        //    p.FirstName = "Jennifer";
        //    p.LastName = "Wenger";
        //    p.Age = 28;
        //    p.Weight = 150;
        //    p.ShowPerson();
        //}
        /* public class Person
         {
             public string Name;
             public int Age;
         }
         static void Main()
         {
             Person p = new Person();
             p.Name = "Somebody";
             p.Age = 18;
             Console.WriteLine("Person's name is {0} and they are {1} years old.", p.Name, p.Age);
         }*/
        /* static void Main(string[] args)
         {
             ColorConsole.Write("Hello, ", ConsoleColor.Cyan);
             ColorConsole.WriteLine("world.", ConsoleColor.Red);
             ColorConsole.WriteLine("Jello, whirled.", ConsoleColor.Yellow);
             ColorConsole.RainbowLine("Lots of different colors.");
         }*/
    }
/*    class DirectoryFileCount
    {

        static long files = 0;
        static long directories = 0;


        static void Main()
        {
            try
            {
                Console.WriteLine("Enter the path to a directory:");

                string directory = Console.ReadLine();

                // Create a new DirectoryInfo object.
                DirectoryInfo dir = new DirectoryInfo(directory);

                if (!dir.Exists)
                {
                    throw new DirectoryNotFoundException("The directory does not exist.");
                }

                // Call the GetFileSystemInfos method.
                FileSystemInfo[] infos = dir.GetFileSystemInfos();

                Console.WriteLine("Working...");

                // Pass the result to the ListDirectoriesAndFiles
                // method defined below.
                ListDirectoriesAndFiles(infos);

                // Display the results to the console. 
                Console.WriteLine("Directories: {0}", directories);
                Console.WriteLine("Files: {0}", files);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

                Console.ReadLine();
            }
        }

        static void ListDirectoriesAndFiles(FileSystemInfo[] FSInfo)
        {
            // Check the FSInfo parameter.
            if (FSInfo == null)
            {
                throw new ArgumentNullException("FSInfo");
            }

            // Iterate through each item.
            foreach (FileSystemInfo i in FSInfo)
            {
                // Check to see if this is a DirectoryInfo object.
                if (i is DirectoryInfo)
                {
                    // Add one to the directory count.
                    directories++;

                    // Cast the object to a DirectoryInfo object.
                    DirectoryInfo dInfo = (DirectoryInfo)i;

                    // Iterate through all sub-directories.
                    ListDirectoriesAndFiles(dInfo.GetFileSystemInfos());
                }
                // Check to see if this is a FileInfo object.
                else if (i is FileInfo)
                {
                    // Add one to the file count.
                    files++;

                }

            }
        }

    }*/

    //Code from Class
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LearningLine.Practice
    {
        class Program
        {
            static void Main(string[] args)
            {
                FolderInfo folder = new FolderInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
                FolderBrowser browser = new FolderBrowser(folder);

                while (true)
                {
                    Console.Clear();
                    ColorConsole.WriteLine(folder.GetDescription());

                    string[] subFolders = browser.GetSubFolders();
                    for (int i = 0; i < subFolders.Length; i++)
                    {
                        string dirName = new DirectoryInfo(subFolders[i]).Name;
                        ColorConsole.WriteLine(String.Format("{0}\t{1}", i, dirName));
                    }

                    ColorConsole.WriteLine("Type a subfolder number or press Enter to move to the parent folder.", ConsoleColor.DarkGray);
                    ColorConsole.Write("> ");
                    string input = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(input))
                    {
                        browser.MoveUpToParentFolder();
                        folder = browser.GetCurrentFolder();
                    }
                    else
                    {
                        int selection = Int32.Parse(input);
                        folder = new FolderInfo(subFolders[selection]);
                        browser = new FolderBrowser(folder);
                    }
                }
            }

            // writing a class with static methods
            static void Part1()
            {
                ColorConsole.Write("Hello, ", ConsoleColor.Cyan);
                ColorConsole.WriteLine("world.");
                ColorConsole.WriteLine("Jello, whirled.", ConsoleColor.Yellow);
                ColorConsole.RainbowLine("Lots of different colors.");
            }

            // using an instance of a class
            static void Part2()
            {
                string[] files = Directory.GetFiles(@"c:\windows");

                File.Delete("dir.txt");

                foreach (var file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    string content = String.Format("{0},{1}\n", fileInfo.FullName, fileInfo.Length);
                    ColorConsole.Write(content);
                    File.AppendAllText("dir.txt", content);
                }
            }

            // creating a class using native types
            static void Part3()
            {
                FolderInfo folderInfo = new FolderInfo(@"c:\windows");
                string description = folderInfo.GetDescription();
                ColorConsole.WriteLine(description);
            }

            // creating a class using other classes
            static void Part4()
            {
                FolderInfo folder = new FolderInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
                FolderBrowser b = new FolderBrowser(folder);

                while (true)
                {
                    Console.Clear();
                    ColorConsole.WriteLine(folder.GetDescription());

                    string[] subFolders = b.GetSubFolders();
                    for (int i = 0; i < subFolders.Length; i++)
                    {
                        string dirName = new DirectoryInfo(subFolders[i]).Name;
                        ColorConsole.WriteLine(String.Format("{0}\t{1}", i, dirName));
                    }

                    ColorConsole.Write("> ");
                    string input = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(input))
                    {
                        b.MoveUpToParentFolder();
                    }
                    else
                    {
                        int selection = Int32.Parse(input);
                        folder = new FolderInfo(subFolders[selection]);
                        b = new FolderBrowser(folder);
                    }
                }
            }
        }
    }

}
