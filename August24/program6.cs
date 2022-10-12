using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReusableCodeLibrary
{
    public class program6
    {
        public static void MakeFile()
        {

            string path = @"D:\C#\MyApp\ReusableCodeLibrary\firstfile.txt";
            File.Create(path);
        }
       
    }
}
