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
            InsertStudents();
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

    }
}
