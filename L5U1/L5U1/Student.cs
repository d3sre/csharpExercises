using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace L5U1
{
    class Student
    {

        /**
         *  Machen sie dasselbe mit der Klasse List<T> und benutzen Sie dafür den Collection Initializer. Nehmen
            Sie für die Erzeugung der Objekte den Object Initializer. Erstellen Sie die Klasse Student welcher
            Name und Vorname als Property hat. Initialisieren Sie diese Liste mit dem Typ Student.
         */

        public string Name { get; set; }
        public string Vorname { get; set; }

        public Student()
        {
            
        }
    }
}
