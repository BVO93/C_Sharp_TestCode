using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Microsoft.Win32;

// PDF handling
using Syncfusion.DocIO;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Parsing;

// Theme
using Syncfusion.SfSkinManager;
using Syncfusion.Themes.FluentLight.WPF;

// To start processes
using System.Diagnostics;

// Images
using System.Drawing;


// Save and read files 
using System.IO;
using System.Windows;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocToPDFConverter;
using Syncfusion.Pdf;

namespace PDFConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // !!!!!!
        // Code not completely finished, basic concept works 

        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertButtonClick(object sender, RoutedEventArgs e)
        {
            if (pathTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please select file");
                return;
            }

            switch (conversionDropDown.SelectedIndex)
            {
                case 0: // Convert doc to PDF
                    ConvertDocToPDF(pathTextBox.Text);
                    break;
                default:
                    MessageBox.Show("Please select options");
                    return;
            }

            OpenFolder(pathTextBox.Text);
        }

        private void ButtonAdv_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ConvertDocToPDF(string docPath)
        {
            WordDocument wordDocument = new WordDocument(docPath, FormatType.Automatic);
            DocToPDFConverter converter = new DocToPDFConverter();
            PdfDocument pdfDocument = converter.ConvertToPDF(wordDocument);

            string newPDFPath = docPath.Split('.')[0] + ".pdf";
            pdfDocument.Save(newPDFPath);

            pdfDocument.Close(true);
            wordDocument.Close();

        }


        private void SelectFileClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            bool? result = openFileDialog.ShowDialog();

            if (result.HasValue && result.Value)
            {
                pathTextBox.Text = openFileDialog.FileName;
            }
        }
        
        private void OpenFolder(string folderPath)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                Arguments = folderPath.Substring(0, folderPath.LastIndexOf('\\')),
                FileName = "explorer.exe"
            };

            Process.Start(startInfo);
        }


    }
}
