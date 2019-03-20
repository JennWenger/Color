using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LearningLine.Practice
{
    class FolderInfo
    {
        string folderPath;

        public FolderInfo(string path)
        {
            folderPath = path;
        }

        public string GetFolderPath()
        {
            return folderPath;
        }

        private int GetNumberOfFiles()
        {
            return Directory.GetFiles(folderPath).Length;
        }

        private int GetNumberOfSubfolders()
        {
            return Directory.GetDirectories(folderPath).Length;
        }

        private long GetSizeOfFiles()
        {
            long bytes = 0;
            foreach (string file in Directory.EnumerateFiles(folderPath))
            {
                bytes += new FileInfo(file).Length;
            }
            return bytes;
        }

        public string GetDescription()
        {
            return String.Format("{0}\n{1} files ({2:N0} bytes), {3} folders",
                this.folderPath,
                this.GetNumberOfFiles(),
                this.GetSizeOfFiles(),
                this.GetNumberOfSubfolders());
        }
    }
}