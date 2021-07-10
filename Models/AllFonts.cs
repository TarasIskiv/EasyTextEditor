using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTextEditor.Models
{
    internal class AllFonts
    {
        public string[] Fonts = {
             "Arial",
             "Arial Black",
             "Courier New",
             "Franklin Gothic",
             "Georgia",
             "Impact",
             "Tahoma",
             "Times New Roman",
        };

        public int[] Size;

        public AllFonts() 
        {
            Size = new int[35];
            for(int i = 0, j = 8; i < Size.Length; ++i)
            {
                Size[i] = j;
                j += 2;
            }
        }
    }
}
