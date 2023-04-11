using System;
using System.Collections.Generic;
using System.Text;

namespace LinqApp_lab15
{

    public class Student
    {
        public Guid ID { get; private set; }

        public string Nume { get; set; }

        public string Prenume { get; set; }

        public int Varsta { get; set; }

        public Specializare Specializarea { get; set; }


        public Student(string nume, string prenume, int varsta, Specializare specializarea)
        {
            ID = Guid.NewGuid();
            Nume = nume;
            Prenume = prenume;
            Varsta = varsta;
            Specializarea = specializarea;
        }
    }
}
