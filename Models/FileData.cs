using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTextEditor.Models
{
    internal class FileData
    {
        internal static string path;
        internal static string fileName;

        public static string Path { get => path; set => path = value; }
        public static string FileName { get => fileName; set => fileName = value; }

        public string getFullPath()
        {
            return path + fileName;
        }
    }
}
