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
using System.Data.SqlClient;
using System.Data;

namespace WpZooManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;

        public MainWindow()
        {
            InitializeComponent();

            // set up the SQL connection
            string connectionString = ConfigurationManager.ConnectionStrings["WpZooManager.Properties.Settings.BVODBConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);

            ShowZoos();
            ShowAllAnimals();

        }

        private void ShowZoos()
        {
            try
            {
                string query = "select * from Zoo";
                // Adapter makes the SQL database usable as C# objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)
                {
                    DataTable zooTable = new DataTable();
                    sqlDataAdapter.Fill(zooTable);

                    // Data to show in field 
                    listZoos.DisplayMemberPath = "Location";
                    // Value used on selection
                    listZoos.SelectedValuePath = "Id";
                    // eference to the data 
                    listZoos.ItemsSource = zooTable.DefaultView;

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }



        private void ShowAssociatedAnimals()
        {
            try
            {
                string query =   "select * from Animal a inner join ZooAnimal " +
                                 "za on a.Id = za.AnimalId where za.ZooId = @ZooId";

             
                // A command takes a query and a connection , use it in the adapter. A query cant go straight into an adapter
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // Adapter makes the SQL database usable as C# objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);


                    DataTable animalTable = new DataTable();
                    sqlDataAdapter.Fill(animalTable);

                    // Data to show in field 
                    listAssociatedAnimals.DisplayMemberPath = "Name";
                    // Value used on selection
                    listAssociatedAnimals.SelectedValuePath = "Id";
                    // eference to the data 
                    listAssociatedAnimals.ItemsSource = animalTable.DefaultView;

                }

            }
            catch (Exception e)
            {
              //  MessageBox.Show(e.ToString());
            }
        }

        private void ShowAllAnimals()
        {
            try
            {
                string query = "select * from Animal";

                // Adapter makes the SQL database usable as C# objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)
                {
  
                    DataTable AllAnimalTable = new DataTable();
                    sqlDataAdapter.Fill(AllAnimalTable);

                    // Data to show in field 
                    listAllAnimals.DisplayMemberPath = "Name";
                    // Value used on selection
                    listAllAnimals.SelectedValuePath = "Id";
                    // eference to the data 
                    listAllAnimals.ItemsSource = AllAnimalTable.DefaultView;

                }

            }
            catch (Exception e)
            {
              MessageBox.Show(e.ToString());
            }
        }


        private void listAssociatedAnimals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         
        }

        private void listZoos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // MessageBox.Show(listZoos.SelectedValue.ToString());

            ShowAssociatedAnimals();
            ShowSelectedZooInTextBox();
        }

        private void listAllAmimalsChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowSelectedAnimalInTextBox();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WpZooManager.BVODBDataSet bVODBDataSet = ((WpZooManager.BVODBDataSet)(this.FindResource("bVODBDataSet")));
            // Load data into the table ZooAnimal. You can modify this code as needed.
            WpZooManager.BVODBDataSetTableAdapters.ZooAnimalTableAdapter bVODBDataSetZooAnimalTableAdapter = new WpZooManager.BVODBDataSetTableAdapters.ZooAnimalTableAdapter();
            bVODBDataSetZooAnimalTableAdapter.Fill(bVODBDataSet.ZooAnimal);
            System.Windows.Data.CollectionViewSource zooAnimalViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("zooAnimalViewSource")));
            zooAnimalViewSource.View.MoveCurrentToFirst();
        }

        private void zooAnimalDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        // Add delete ZOO 

        private void DeleteZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from Zoo where id = @ZooId";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                sqlConnection.Close();
                ShowZoos();

            }

        }

        private void AddZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into Zoo values (@Location)";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Location", MyTextbox.Text);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                sqlConnection.Close();
                ShowZoos();

            }
        }

        // Animals to from zoo 

        private void AddAnimalToZoo_CLick(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into ZooAnimal values (@ZooId, @AnimalId)";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@AnimalId", listAllAnimals.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                sqlConnection.Close();
              
                ShowAssociatedAnimals();
                ShowZoos();

            }

        }

        private void RemoveAnimalFromZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from ZooAnimal values (@ZooId, @AnimalId)";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@AnimalId", listAssociatedAnimals.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                sqlConnection.Close();

                ShowAssociatedAnimals();
                ShowZoos();

            }
        }




        // Animals 

        private void RemoveAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from Animal where id = @AnimalId";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@AnimalId", listAllAnimals.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                sqlConnection.Close();
                ShowAllAnimals();

            }


        }

        private void AddAnimal_click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into Animal values (@Name)";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Name", MyTextbox.Text);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                sqlConnection.Close();
                ShowAllAnimals();
                ShowZoos();

            }
        }


        // Showing in textbox

        private void ShowSelectedZooInTextBox()
        {
            try
            {
               string query = "select location from Zoo where Id = @ZooId";


                // A command takes a query and a connection , use it in the adapter. A query cant go straight into an adapter
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // Adapter makes the SQL database usable as C# objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);


                    DataTable zooDataTable = new DataTable();
                    sqlDataAdapter.Fill(zooDataTable);
                    MyTextbox.Text = zooDataTable.Rows[0]["Location"].ToString();
                   
                }

            }
            catch (Exception ex)
            {
                //  MessageBox.Show(e.ToString());
            }

        }




        private void ShowSelectedAnimalInTextBox()
        {
            try
            {
                string query = "select Name from Animal where Id = @AnimalId";


                // A command takes a query and a connection , use it in the adapter. A query cant go straight into an adapter
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // Adapter makes the SQL database usable as C# objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@AnimalId", listAllAnimals.SelectedValue);


                    DataTable animalDataTable = new DataTable();
                    sqlDataAdapter.Fill(animalDataTable);
                    MyTextbox.Text = animalDataTable.Rows[0]["Name"].ToString();

                }

            }
            catch (Exception ex)
            {
                //  MessageBox.Show(e.ToString());
            }


        }

        // Update zoo 
        private void UpdateZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "update Zoo Set Location = @Location where Id = @ZooId";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@Location", MyTextbox.Text);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                sqlConnection.Close();

                ShowAssociatedAnimals();
                ShowZoos();

            }
        }

        private void UpdateAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "update Animal Set Name = @Name where Id = @AnimalId";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@AnimalId", listAllAnimals.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@Name", MyTextbox.Text);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                sqlConnection.Close();

                ShowAssociatedAnimals();
                ShowAllAnimals();

            }
        }


        // Update animal 


    }
}
