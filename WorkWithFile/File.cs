using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkWithFile
{
    class File
    {
        public void WorkFile()
        {   string path = @"C:\Users\Lenovo\Desktop\CSV.txt";
            string pathEx = @"C:\Users\Lenovo\Desktop\CSV.csv";
            using (StreamReader reader = new StreamReader(pathEx, Encoding.Default))
            {
                string Call;
                Call = reader.ReadToEnd();
                Console.WriteLine("Запись завершена");
                using (FileStream file = new FileStream(path, FileMode.Append))
            {
                using (StreamWriter stream = new StreamWriter(file))
                    
                    stream.WriteLine(Call);
            }
                
            } 


            
        }

    }
}
