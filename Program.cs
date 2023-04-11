using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqApp_lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listStudents = new List<Student>();

            #region Construire lista Studenti
            listStudents.Add(new Student("Popescu", "Maria", 21, Specializare.Informatica));
            listStudents.Add(new Student("Ionescu", "Ion", 19, Specializare.Litere));
            listStudents.Add(new Student("Popa", "Andrei", 20, Specializare.Constructii));
            listStudents.Add(new Student("Georgescu", "Ana", 22, Specializare.Informatica));
            listStudents.Add(new Student("Stancu", "Mihai", 23, Specializare.Constructii));
            listStudents.Add(new Student("Iacob", "Andreea", 21, Specializare.Litere));
            listStudents.Add(new Student("Pavel", "Cristian", 19, Specializare.Informatica));
            listStudents.Add(new Student("Dumitru", "Andrei", 20, Specializare.Constructii));
            listStudents.Add(new Student("Stan", "Mihaela", 22, Specializare.Informatica));
            listStudents.Add(new Student("Florea", "Alina", 23, Specializare.Litere));
            listStudents.Add(new Student("Gheorghe", "Gabriel", 21, Specializare.Constructii));
            listStudents.Add(new Student("Chiriac", "Bogdan", 19, Specializare.Informatica));
            listStudents.Add(new Student("Istrate", "Alexandra", 20, Specializare.Constructii));
            listStudents.Add(new Student("Dinu", "Elena", 22, Specializare.Litere));
            listStudents.Add(new Student("Mihai", "Andrei", 23, Specializare.Informatica));
            listStudents.Add(new Student("Radu", "Mihaela", 21, Specializare.Litere));
            listStudents.Add(new Student("Toma", "Marius", 19, Specializare.Constructii));
            listStudents.Add(new Student("Petrica", "Cristina", 20, Specializare.Informatica));
            listStudents.Add(new Student("Balan", "Andrei", 22, Specializare.Constructii));
            listStudents.Add(new Student("Pop", "Ioana", 23, Specializare.Litere));
            listStudents.Add(new Student("Anton", "Adrian", 21, Specializare.Informatica));
            listStudents.Add(new Student("Cristea", "Andreea", 19, Specializare.Litere));
            listStudents.Add(new Student("Marin", "Razvan", 20, Specializare.Constructii));
            listStudents.Add(new Student("Sava", "Maria", 22, Specializare.Informatica));
            listStudents.Add(new Student("Dragomir", "Cristina", 23, Specializare.Litere));
            listStudents.Add(new Student("Radulescu", "Andrei", 19, Specializare.Informatica));
            listStudents.Add(new Student("Munteanu", "Cristina", 21, Specializare.Constructii));
            listStudents.Add(new Student("Florescu", "Maria", 20, Specializare.Litere));
            listStudents.Add(new Student("Diaconu", "Alexandru", 22, Specializare.Informatica));
            listStudents.Add(new Student("Dumitrache", "Andreea", 23, Specializare.Litere));
            listStudents.Add(new Student("Lazar", "Gabriel", 21, Specializare.Constructii));
            listStudents.Add(new Student("Plesa", "Mihai", 19, Specializare.Informatica));
            listStudents.Add(new Student("Ciobanu", "Alina", 20, Specializare.Constructii));
            listStudents.Add(new Student("Stoica", "Ana", 22, Specializare.Litere));
            listStudents.Add(new Student("Nistor", "Bogdan", 23, Specializare.Informatica));
            listStudents.Add(new Student("Irimia", "Elena", 21, Specializare.Constructii));
            listStudents.Add(new Student("Cristescu", "Andrei", 19, Specializare.Informatica));
            listStudents.Add(new Student("Popovici", "Mihaela", 20, Specializare.Litere));
            listStudents.Add(new Student("Nicolae", "Cristina", 22, Specializare.Informatica));
            listStudents.Add(new Student("Popa", "Marius", 23, Specializare.Constructii));
            listStudents.Add(new Student("Chirita", "Andreea", 21, Specializare.Litere));
            listStudents.Add(new Student("Enache", "Razvan", 19, Specializare.Informatica));
            listStudents.Add(new Student("Gavrila", "Gabriela", 20, Specializare.Litere));
            listStudents.Add(new Student("Rosu", "Mihai", 22, Specializare.Constructii));
            listStudents.Add(new Student("Matei", "Ioana", 23, Specializare.Informatica));
            listStudents.Add(new Student("Constantinescu", "Alexandra", 21, Specializare.Constructii));
            listStudents.Add(new Student("Dobre", "Andrei", 19, Specializare.Litere));
            listStudents.Add(new Student("Stanciu", "Cristina", 20, Specializare.Informatica));
            listStudents.Add(new Student("Petrescu", "Adrian", 22, Specializare.Informatica));
            listStudents.Add(new Student("Serban", "Maria", 23, Specializare.Constructii));
            #endregion 


            // 1
            Student oldestStudent = GetOldestStudentBySpecialization(listStudents, Specializare.Informatica);
            Console.WriteLine($"Cel mai in varsta student de la Informatica: {oldestStudent.Nume} {oldestStudent.Prenume}, varsta {oldestStudent.Varsta}");

            // 2
            Student youngestStudent = GetYoungestStudent_V1(listStudents);
            Console.WriteLine($"Cel mai in tanar (V1) student: {youngestStudent.Nume} {youngestStudent.Prenume}, varsta {youngestStudent.Varsta}");

            Student youngestStudent2 = GetYoungestStudent_V2(listStudents);
            Console.WriteLine($"Cel mai in tanar (V2) student: {youngestStudent.Nume} {youngestStudent.Prenume}, varsta {youngestStudent.Varsta}");

            // 3
            List<Student> students = GetStudentBySpecializationOrderByAge(listStudents, Specializare.Litere);
            students.ForEach(x => Console.WriteLine($"{x.Nume} {x.Prenume} {x.Varsta}"));

            // 4
            Student student = GetFirstStudentBySpecializationOverAge(listStudents, Specializare.Constructii, 20);
            if(student != null) 
            { 
                Console.WriteLine($"Student: {student.Nume} {student.Prenume}, varsta {student.Varsta}, specializarea: {student.Specializarea} " ); 
            }
            else
            {
                Console.WriteLine("Nu exista niciun student care sa indeplineasca cerintele.");
            }

            //5 
            Console.WriteLine("--------------5-------------");
            List<Student> studentsList = GetStudentsWithAgeEqualWithTheirAverageAge(listStudents);
            if (studentsList.Count >= 1)
            {
                studentsList.ForEach(x => { Console.WriteLine($"Student: {x.Nume} {x.Prenume}, varsta {x.Varsta}, specializarea: {x.Specializarea}"); });
              
            }
            else
            {
                Console.WriteLine("Nu exista niciun student care sa indeplineasca cerintele.");
            }

            //6
            Console.WriteLine("--------------6-------------");
            List<Student> studentsOfStudents = GetStudentsSortByDescAgeAscName(listStudents, 18, 35);
            if (studentsOfStudents.Count >= 1)
            {
                studentsOfStudents.ForEach(x => { Console.WriteLine($"Student: {x.Nume} {x.Prenume}, varsta {x.Varsta}, specializarea: {x.Specializarea}"); });
            }
            else
            {
                Console.WriteLine("Nu exista niciun student care sa indeplineasca cerintele.");
            }

            // 7
            Console.WriteLine("--------------7-------------");
            Student lastStudent = GetLastStudent(listStudents);
            Console.WriteLine($"Ultimul student: {lastStudent.Nume} {lastStudent.Prenume}, varsta {lastStudent.Varsta}");

            // 8
            Console.WriteLine("--------------8-------------");

            if(GetStudentsUnderAge(listStudents, 18))
            {
                Console.WriteLine("Exista si minori");
            }
            else
            {
                Console.WriteLine("Nu exista minori");
            }


            // 9
            Console.WriteLine("--------------9-------------");

           var studentsGroupByAge = GetStudentsGroupByAge(listStudents);
            foreach (var group in studentsGroupByAge)
            {
                Console.WriteLine($"Studentii cu varsta de {group.Key} ani:");
                var studentNames = group.Select(student => $"{student.Nume} {student.Prenume} ({student.Specializarea})");
                Console.WriteLine(string.Join(Environment.NewLine, studentNames));

            }


        }

        #region 1. Afisati cel mai in varsta student de la Informatica
        public static Student GetOldestStudentBySpecialization(List<Student> list, Specializare specializare)
        {
            return list.Where(s => s.Specializarea == specializare).OrderByDescending(s => s.Varsta).FirstOrDefault();
        }
        #endregion

        #region 2. Afisati cel mai tanar student
        public static Student GetYoungestStudent_V1(List<Student> list)
        {
            return list.OrderBy(s => s.Varsta).FirstOrDefault();
        }

        public static Student GetYoungestStudent_V2(List<Student> list)
        {
            var minVarsta = list.Min(s => s.Varsta);
            return list.Where(x => x.Varsta == minVarsta).FirstOrDefault();
        }
        #endregion

        #region 3. Afisati in ordine crescatoare a varstei toti studentii de la litere.
        public static List<Student> GetStudentBySpecializationOrderByAge(List<Student> list, Specializare specializare)
        {
            return list.Where(s => s.Specializarea == specializare).OrderBy(s => s.Varsta).ToList();
        }
        #endregion

        #region 4. Afisati primul student de la constructii cu varsta de peste 20 de ani.
        public static Student GetFirstStudentBySpecializationOverAge(List<Student> list, Specializare specializare, int age)
        {
            return list.Where(s => s.Specializarea == specializare && s.Varsta > age).OrderBy(s => s.Varsta).FirstOrDefault();
        }

        #endregion

        #region 5. Afisati studentii avand varsta egala cu varsta medie a studentilor.
        public static List<Student> GetStudentsWithAgeEqualWithTheirAverageAge(List<Student> list)
        {
            var media = list.Average(x => x.Varsta);
            return list.FindAll(x => x.Varsta == media);
        }

        #endregion

        #region 6. Afisati, in ordinea descrescatoare a varstei,si in ordine alfabetica, dupa numele de familie si dupa numele mic, toti studentii cu varsta cuprinsa intre 18 si 35 de ani

        public static List<Student> GetStudentsSortByDescAgeAscName(List<Student> list, int minAge, int maxAge)
        {
            return list.OrderByDescending(x => x.Varsta).ThenBy(x => x.Nume).ThenBy(x => x.Prenume).Where(x => x.Varsta >= minAge && x.Varsta <= maxAge).ToList();         
        }

        #endregion

        # region 7. Afisati ultimul elev din lista folosind linq
        public static Student GetLastStudent(List<Student> list)
        {
            //var nrOfItems = list.Count();
            //return list[nrOfItems - 1];

            return list.Last();
        }
        #endregion
    
        #region 8. Afisati mesajul “Exista si minori” daca in lista creeata exista si persone cu varsta mai mica de 18 ani.In caz contar afesati “Nu exista minori”
        public static bool GetStudentsUnderAge(List<Student> list, int age)
        {
            return list.Any(x => x.Varsta < age);
        }
        #endregion

        #region 9. Folosind GroupBy, afisati toti studentii grupati in functie de varsta sub forma urmatoare

        public static IEnumerable<IGrouping<int,Student>> GetStudentsGroupByAge(List<Student> list)
        {
            return list.GroupBy(x => x.Varsta);
        }

        #endregion

    }
}
