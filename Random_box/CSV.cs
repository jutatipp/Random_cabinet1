using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_box
{
    internal class CSV
    {
        public string content = "";
        public string path = @"D:\Random_cabinet1\Random_box\Data.csv";
        
        

        public bool FileCsv( string lists , int products , int total)
        {
            
            content = lists + "," + products + "," + total;

            try
            {
                File.WriteAllText(path, content);
                return true;
            }
            catch
            {
                return false;
            }

        }   
    }
}
