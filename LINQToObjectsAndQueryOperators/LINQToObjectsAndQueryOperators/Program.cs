using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToObjectsAndQueryOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();
            um.MaleStudents();
            um.FemaleStudents();
            um.SortStudentsByAge();
            um.AllStudentsFromCSULB();

            um.StudentAndUniversityNameCollection();

            /*
            // one way of reversing ints
            int[] someInts = { 30, 12, 4, 3, 12 };
            IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            IEnumerable<int> reversedInts = sortedInts.Reverse();

            foreach (int i in reversedInts)
            {
                Console.WriteLine(i);
            }

            
            //another way of reversing ints
            IEnumerable<int> reversedInts2 = from i in someInts orderby i descending select i;

            foreach (int i in reversedInts2)
            {
                Console.WriteLine(i);
            }

            */

            // This will print out all students with a chosen Id
            /*
            string input = Console.ReadLine();
            try
            {
                int intInput = Convert.ToInt32(input);
                um.AllStudentsWithSpecificUniId(intInput);
            }
            catch (Exception)
            {

                Console.WriteLine("Please enter a valid number.");
            }

            */

            Console.ReadKey();
        }
    }

    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            // Add some Universities
            universities.Add(new University { Id = 1, Name = "CSULB" });
            universities.Add(new University { Id = 2, Name = "USC" });

            // Add some students
            students.Add(new Student { Id = 1, Name = "Alex", Age = 26, Gender = "Male", UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Anna", Age = 21, Gender = "Female", UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "Tyler", Age = 22, Gender = "Male", UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "Samantha", Age = 18, Gender = "Female", UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "Christine", Age = 20, Gender = "Female", UniversityId = 2 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "Male" select student;
            Console.WriteLine("Male - Students: ");

            foreach (Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "Female" select student;

            Console.WriteLine("Female students: ");

            foreach (Student student in femaleStudents)
            {
                student.Print();
            }
        }

        public void SortStudentsByAge()
        {
            // var is generic type that can be used as IEnumerable at a cost of speed
            var sortedStudents = from student in students orderby student.Age select student;

            Console.WriteLine("Students sorted by Age: ");

            foreach (Student student in sortedStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromCSULB()
        {
            // This also works 
            //var csulbStudents = from student in students
            //                    join university in universities
            //on student.UniversityId equals university.Id
            //                    where university.Name == "CSULB"
            //                    select student;

            IEnumerable<Student> csulbStudents = from student in students
                                                 join university in universities
                                                 on student.UniversityId equals university.Id
                                                 where university.Name == "CSULB"
                                                 select student;

            Console.WriteLine("CSULB students: ");

            foreach (Student student in csulbStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsWithSpecificUniId(int uId)
        {
            IEnumerable<Student> chosenStudents = from student in students
                                                  join university in universities
                                                  on student.UniversityId equals university.Id
                                                  where university.Id == uId
                                                  select student;

            Console.WriteLine("Students with chosen ID: ");

            foreach (Student student in chosenStudents)
            {
                student.Print();
            }
        }

        public void StudentAndUniversityNameCollection()
        {
            var newCollection = from student in students
                                join university in universities on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };

            Console.WriteLine("New Collection: ");

            foreach (var col in newCollection)
            {
                Console.WriteLine("Student {0} from University {1}", col.StudentName, col.UniversityName);
            }
        }
    }

    class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("University {0} with id {1}", Name, Id);
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        // Foreign Key
        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine("Student {0} with Id {1}, Gender {2} and Age {3} from University with the Id {4}", Name, Id, Gender, Age, UniversityId);
        }

    }
}
