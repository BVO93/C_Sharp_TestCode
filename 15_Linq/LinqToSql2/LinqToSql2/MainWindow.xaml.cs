using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Configuration;
using LinqToSql2.BVODBDataSetTableAdapters;
using System.Xml.Serialization;

namespace LinqToSql2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinqToSqlDataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["LinqToSql2.Properties.Settings.BVODBConnectionString"].ConnectionString;
            dataContext = new LinqToSqlDataContext(connectionString);




            // InsertUniverities();
            //InsertStudents();

            // InsertLectures();

            //InsertStudentLecturesAssociation();

            //   GetUniversityOfToni();

            //GetLecturesOfToni();

            //  GetAllStudentsFromYale();


            //GetAllUniversitiesWithTransgenders();

            //GetAllLecturesFromBejingtech();

            //UpdateTony();

            DeleteJame();

        }

        public void InsertUniverities()
        {
            dataContext.ExecuteCommand("delete from University");

            University yale = new University();
            yale.Name = "Yale";
            dataContext.Universities.InsertOnSubmit(yale);

            University beijingTech = new University();
            beijingTech.Name = "Beijing Tech";
            dataContext.Universities.InsertOnSubmit(beijingTech);


            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Universities;

        }

        public void InsertStudents()
        {
            University yale = dataContext.Universities.First(un => un.Name.Equals("Yale"));

            University beijingTech = dataContext.Universities.First(un => un.Name.Equals("Beijing Tech"));

            List<Student> students = new List<Student>();
            students.Add(new Student { Name = "Carla", Gender = "female", UniversityId = yale.Id });
            students.Add(new Student { Name = "Tony", Gender = "Male", University = yale });
            students.Add(new Student { Name = "Layla", Gender = "female", University = beijingTech });
            students.Add(new Student { Name = "james", Gender = "trans-gender", University = beijingTech });

            dataContext.Students.InsertAllOnSubmit(students);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;


        }


        public void InsertLectures()
        {

           dataContext.Lectures.InsertOnSubmit(new Lecture { Name =  "Math"});
           dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "History"});


            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Lectures;


        }

        public void InsertStudentLecturesAssociation()
        {
            Student Carla = dataContext.Students.First(st => st.Name.Equals("Carla"));
            Student Tony = dataContext.Students.First(st => st.Name.Equals("Tony"));
            Student Layla = dataContext.Students.First(st => st.Name.Equals("Layla"));
            Student james = dataContext.Students.First(st => st.Name.Equals("james"));

            Lecture Math = dataContext.Lectures.First(lc => lc.Name.Equals("Math"));
            Lecture History = dataContext.Lectures.First(lc => lc.Name.Equals("History"));


            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Carla, Lecture = Math });
            // Connecting the object Carla and the object math

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Tony, Lecture = Math });

            // Could also do like this, but more old school
            StudentLecture slToni = new StudentLecture();
            slToni.LectureId = History.Id;
            slToni.StudentId = Tony.Id;
            dataContext.StudentLectures.InsertOnSubmit(slToni);


            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Layla, Lecture = History });


            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.StudentLectures;

        }


        // MAKE NOTE OF THIS 

        public void GetUniversityOfToni()
        {
            Student Toni = dataContext.Students.First(st => st.Name.Equals("Tony"));

            University uni = Toni.University;
            // In a numerator always make a list. Cant accept one single thing 

            List<University> universities = new List<University>();
            universities.Add(uni);

            MainDataGrid.ItemsSource = universities; 
        
        }



        public void GetLecturesOfToni()
        {
            // Because student lecture is already a list 
            Student Toni = dataContext.Students.First(st => st.Name.Equals("Tony"));            
            MainDataGrid.ItemsSource = Toni.StudentLectures;

        }


        public void GetAllStudentsFromYale()
        {

            var studentsFromYale = from student in dataContext.Students
                                   where student.University.Name == "Yale"
                                   select student;

            MainDataGrid.ItemsSource = studentsFromYale;

        }
        

        public void GetAllUniversitiesWithTransgenders()
        {
            var trangenderuniversities = from student in dataContext.Students
                                         join University in dataContext.Universities
                                         on student.University equals University
                                         where student.Gender == "trans-gender" 
                                         select University;

            MainDataGrid.ItemsSource = trangenderuniversities;

        }

        public void GetAllLecturesFromBejingtech()
        {
            // We loop and select students. And then we take each student if he is on beijing and take the lecturs 
            var beijingTechLec = from sl in dataContext.StudentLectures
                                 join student in dataContext.Students on sl.StudentId equals student.Id
                                 where student.University.Name == "Beijing Tech"
                                 select sl.Lecture;

            MainDataGrid.ItemsSource = beijingTechLec;


        }

     
        public void UpdateTony()
        {

            Student Toni = dataContext.Students.FirstOrDefault(st => st.Name == "Tony");

            Toni.Name = "Atonio";

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;



        }

        public void DeleteJame()
        {

            Student jame = dataContext.Students.FirstOrDefault(st => st.Name == "james");
            dataContext.Students.DeleteOnSubmit(jame);
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;


        }


    }
}
