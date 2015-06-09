using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5U4
{
    class Program
    {
        /***
         * Erstellen Sie eine Konsolenanwendung. Benützen Sie die Methode, welche in der Vorlesung
            L5M3 gezeigt wurde, um FileInfo Objekte aus dem Filesystem zu laden. Erstellen Sie eine
            LINQ Abfrage, in welcher sie den UNION Operator benützen um Files aus zwei
            verschiedenen Verzeichnissen in der Resultatmenge zusammenzuführen.
            Sortieren sie das Ergebnis nach LastAccessTime und geben Sie FullName auf der Konsole
            aus.
         * 
         */

        static void Main(string[] args)
        {
            DirectoryInfo di1 = new DirectoryInfo(@"C:\Users\des\Documents\git\csharpExercises");
            DirectoryInfo di2 = new DirectoryInfo(@"C:\Users\des\Documents\git\Code");
            
            var selectedFiles = from FileInfo f1 in di1.GetFiles("*.*", SearchOption.AllDirectories)
                                //where f1.Name.StartsWith("A")
                                select new { MyName = f1.Name, MyLastAccessTime = f1.LastAccessTime, MyLength = f1.Length };
            var selectedFiles2 = from FileInfo f2 in di2.GetFiles("*.*", SearchOption.AllDirectories)
                               //where f2.Name.StartsWith("A")
                                select new { MyName = f2.Name, MyLastAccessTime = f2.LastAccessTime, MyLength = f2.Length };

            var union = selectedFiles.Union(selectedFiles2);
            var sortedUnion = from d in union orderby  d.MyLastAccessTime select d;

            foreach (var fileInfo in sortedUnion)
            {
                Console.WriteLine("LastAccessTime: {0}, FullName: {1}", fileInfo.MyLastAccessTime, fileInfo.MyName);

            }
            Console.ReadLine();
        }
    }
}
