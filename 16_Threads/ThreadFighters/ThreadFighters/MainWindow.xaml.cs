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
using System.Threading;
using System.Collections.Generic;


namespace ThreadFighters
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    /// 

    public partial class MainWindow : Window
    {
        int rowSize = 10;
        int columnSize = 10;

        int[,] grid;




        public MainWindow()
        {
            grid = new int[columnSize, rowSize];

            InitializeComponent();

            Console.WriteLine("Clearing the screen!");
            //Console.Clear();


            List<List<int>> lsts = new List<List<int>>();

            for (int row = 0; row < rowSize; row++)
            {
                lsts.Add(new List<int>());

                for (int col = 0; col < columnSize; col++)
                {
                    lsts[row].Add(row * 10 + col);
                }
            }

            InitializeComponent();

            lst.ItemsSource = lsts;

              var test = lsts[1][4];

            new Thread(() =>
            {
                
                Console.WriteLine("Thread 1 reporting ");

                while (true)
                {

                    int setTo = 1;

                    for (int row = 0; row < rowSize;)
                    {

                        for (int col = 0; col < columnSize;)
                        {
                            int val = grid[col, row];
                            if (val == 0 || val == 2)
                            {
                                grid[col, row] = setTo;

                                Thread.Sleep(1000);

                            }

                            col++;
                        }

                        row++;
                    }

                }

            }).Start();


            new Thread(() =>
            {

                Console.WriteLine("Thread 2 reporting ");

                while (true)
                {

                    int setTo = 2;

                    for (int row = rowSize -1; row >= 0;)
                    {

                        for (int col = columnSize-1; col >= 0;)
                        {
                            int val = grid[col, row];
                            if (val == 0 || val == 1)
                            {
                                grid[col, row] = setTo;
                                Thread.Sleep(1000);
                            }

                            col--;
                        }

                        row--;
                    }

          
                }


            }).Start();



            new Thread(() =>
            {
                Console.WriteLine("Thread 3 reporting ");

                while (true)
                {
            

                    for (int row = 0; row < rowSize;)
                    {

                        for (int col = 0; col < columnSize;)
                        {

                            int val = grid[col, row];
                            Console.Write(val + " ");

                            col++;
                        }

                        Console.WriteLine();
                        row++;
                    }
                    Thread.Sleep(25);
                   

                }


            }).Start();


        }

   

     //   Printthe grid
     void PrintGrid()
    {

            Console.Clear();
            for (int row = 0; row < rowSize;)
            {

                for (int col = 0; col < columnSize;) {

                    int val = grid[col, row];
                    Console.Write(val + " ");

                    col++;
                }

                Console.WriteLine();
                row++;
            }


    }



        // Fill thegrid to check
        void FillGrid()
        {

            int inp = 0;

            for (int row = 0; row < rowSize;)
            {

                for (int col = 0; col < columnSize;)
                {

                    grid[col, row] = inp;
                    inp++;
                    col++;
                }

                Console.WriteLine();
                row++;
            }
        }



    }

}
