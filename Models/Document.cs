using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTextEditor.Models
{
    internal class Document
    {
        private static string filePath;
        public static string FilePath { get; set; } = null;

        private static string content;
        public static string Content { get; set; } = null;
        internal Document()
        {
            
        }

        
    }
}
