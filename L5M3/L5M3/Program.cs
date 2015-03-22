using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5M3
{
    class Program
    {
        static void Main(string[] args)
        {

            DirectoryInfo di = new DirectoryInfo(@"C:\Users\des\Documents\git\csharpExercises");
            var selectedFiles = from FileInfo f in di.GetFiles("*.*",SearchOption.AllDirectories)
                                where f.Name.StartsWith("A")
                                select new {MyName=f.Name, MyCreationTime = f.CreationTime,MyLength=f.Length};

            foreach (var fileInfo in selectedFiles)
            {
                Console.WriteLine("Creation Time: {0}, Name: {1}, Length: {2}",fileInfo.MyCreationTime, fileInfo.MyName, fileInfo.MyLength );
                
            }
            Console.ReadLine();

        }
    }
}
