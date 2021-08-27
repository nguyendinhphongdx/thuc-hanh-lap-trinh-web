using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace uploadFile
{
    public class Item
    {
       
            string fileName;
            string filePath;

            public Item(string fileName, string filePath)
            {
                this.fileName = fileName;
                this.filePath = filePath;
            }

            public string FileName { get => fileName; set => fileName = value; }
            public string FilePath { get => filePath; set => filePath = value; }
       
    }
}