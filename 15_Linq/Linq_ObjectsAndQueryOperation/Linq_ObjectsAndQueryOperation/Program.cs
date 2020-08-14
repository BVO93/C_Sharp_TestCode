using System;
using System.Collections.Generic;
using System.Linq;



namespace Linq_ObjectsAndQueryOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            UniversityManager um = new UniversityManager();
            um.MaleStudents();
            Console.WriteLine("");
            um.FemaleStudents();
            Console.WriteLine("");
            um.SortStudentsByage();
            Console.WriteLine("");
            um.AllStudentFromBeijing();
            Console.WriteLine("");

            /*
            Console.WriteLine("Give the uni you want the students of : " );

            try
            {
                string input = Console.ReadLine();
                int inputAsInt = Convert.ToInt32(input);
                um.AllStudentsFromThatUni(inputAsInt);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Wrong input ");

            }
            */
            Console.WriteLine("");

            int[] someInt = { 30, 12, 4, 3, 12 };
            IEnumerable<int> sortedInts = from i in someInt orderby i select i;
            IEnumerable<int> reversedInts = sortedInts.Reverse();

            foreach(int i in reversedInts)
            {
                Console.WriteLine(i);
            }

            IEnumerable<int> reversedSortedInts = from i in someInt orderby i descending select i;
            foreach(int i in reversedInts)
            {
                Console.WriteLine(i);
            }

            um.StudentAndUniversityNameCollection();





        }
    }


    // Normally alwasy create classes in seperate files 


    // UNIVERSITY
    class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("University {0} with id {1}", Name, Id);

        }

    }

    // STUDENT 
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        // Foreign Key ( Student has to be at university)
        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine("Student {0}, with Id {1} age {2} gender {3} and uneversity Id {4} ", Name, Id, Age, Gender, UniversityId );
        }

     }




    // UNIVERSITY HANDLER 
    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        // Constructor
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            universities.Add(new University { Id = 1, Name = "KUL" });
            universities.Add(new University { Id = 2, Name = "Beijing Tech" });

            students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudent = from student in students where student.Gender == "male" select student;
            Console.WriteLine("Male student");

            foreach(Student student in maleStudent)
            {
                student.Print();
            }

        }


        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudent = from student in students where student.Gender == "female" select student;
            Console.WriteLine("Female student");

            foreach (Student student in femaleStudent)
            {
                student.Print();
            }

        }


        public void SortStudentsByage()
        {
            var sortedStudents = from student in students orderby student.Age select student;

            Console.WriteLine("Students sorted by age : ");
            foreach( Student student in sortedStudents)
            {
                student.Print();
            }

        }


        // we have to join two tables becasue the name bejing is in other table
        public void AllStudentFromBeijing()
        {
            IEnumerable<Student> bjtStudents = from student in students
                                               join university in universities on student.UniversityId equals university.Id
                                               where university.Name == "Beijing Tech"
                                               select student;

            Console.WriteLine("Students from bejing :");

            foreach(Student student in bjtStudents)
            {
                student.Print();
            }


        }


        public void AllStudentsFromThatUni(int Id)
        {
            IEnumerable<Student> myStudents = from student in students
                                               join university in universities on student.UniversityId equals university.Id
                                               where university.Id == Id
                                               select student;

            Console.WriteLine("Students from this uni :");

            foreach (Student student in myStudents)
            {
                student.Print();
            }


        }

        public void StudentAndUniversityNameCollection()
        {
            var newCollecttion = from student in students
                                 join university in universities on student.UniversityId equals university.Id
                                 orderby student.Name
                                 select new { StudentName = student.Name, UniversityName = university.Name };

            Console.WriteLine("New Collections");
            foreach(var col in newCollecttion)
            {
                Console.WriteLine("Student {0} from university {1}", col.StudentName, col.UniversityName );

            }

        }



    }

}


