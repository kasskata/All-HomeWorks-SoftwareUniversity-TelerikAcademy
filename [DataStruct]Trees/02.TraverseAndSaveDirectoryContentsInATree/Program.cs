namespace _02.TraverseAndSaveDirectoryContentsInATree
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Program
    {
        private static Dictionary<string, List<Folder>> folders = new Dictionary<string, List<Folder>>();
        private static Dictionary<string, List<File>> files = new Dictionary<string, List<File>>();
        private static Folder rootFolder;
        private static bool firstInit = true;

        static void Main()
        {
            DirectoryInfo root = new DirectoryInfo("C:\\Windows");

            RecursivlyTakeFilesAndFoldersIn(root);

            rootFolder.Print();
        }

        private static void RecursivlyTakeFilesAndFoldersIn(DirectoryInfo root, Folder parentFolder = null)
        {
            if (parentFolder == null)
            {
                parentFolder = new Folder(root.Name);
                rootFolder = parentFolder;
            }
            var dirsInside = root.GetDirectories();
            if (!dirsInside.Any()) return;
                
            foreach (var dir in dirsInside)
               {
                    var newDir = new Folder(dir.Name);
                    try
                    {
                        DirectoryInfo directory = new DirectoryInfo(dir.FullName);
                        RecursivlyTakeFilesAndFoldersIn(directory, newDir);
                    }
                    catch
                    {
                    }

                    parentFolder.ChildFolders.Add(newDir);
                }
            var filesInside = root.GetFiles();
            
            if (!filesInside.Any()) return;

            foreach (var fileInfo in filesInside)
            {
                parentFolder.Files.Add(new File(fileInfo.Name, (ulong)fileInfo.Length));
            }
        }
    }

    public class File
    {
        public File(string name, ulong size)
        {
            this.Name = name;
            this.Size = size;
        }
        public string Name { get; set; }

        public ulong Size { get; set; }

        public Folder ParentFolder { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}", this.Name, this.Size);
        }
    }

    public class Folder
    {
        public Folder(string name)
        {
            this.ChildFolders = new List<Folder>();
            this.Files = new List<File>();
            this.Name = name;
        }
        public string Name { get; set; }

        public List<File> Files { get; set; }

        public List<Folder> ChildFolders { get; set; }

        public Folder ParentFolder { get; set; }

        public override string ToString()
        {
            return string.Format(this.Name);
        }

        public void Print(int depth = 0)
        {
            Console.Write(new string(' ', 2 * depth));
            Console.WriteLine(this.Name);
            
            foreach (var child in this.ChildFolders)
            {
                child.Print(depth + 1);
            }
            
            foreach (var file in this.Files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
