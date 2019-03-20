using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LearningLine.Practice
{
    class FolderBrowser
    {
        FolderInfo currentFolder = null;

        public FolderBrowser(FolderInfo folder)
        {
            currentFolder = folder;
        }

        public FolderInfo GetCurrentFolder()
        {
            return currentFolder;
        }

        public string[] GetSubFolders()
        {
            return Directory.GetDirectories(currentFolder.GetFolderPath());
        }

        public void MoveUpToParentFolder()
        {
            DirectoryInfo parent = Directory.GetParent(currentFolder.GetFolderPath());
            if (parent != null)
            {
                currentFolder = new FolderInfo(parent.FullName);
            }
        }
    }
}