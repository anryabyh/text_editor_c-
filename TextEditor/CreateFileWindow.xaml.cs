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
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;

namespace TextEditor
{
    /// <summary>
    /// Логика взаимодействия для CreateFileWindow.xaml
    /// </summary>
    public partial class CreateFileWindow : Window
    {

        public CreateFileWindow()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
           
            var path = $@"C:\Users\ryaby\Downloads\TextEditor\TextEditor\data\{fileNameBox.Text}.txt";

            using (FileStream fs = File.Create(path)) {
                byte[] data = Encoding.UTF8.GetBytes("");
                fs.Write(data, 0, data.Length);
            };
           
        }
        public string FileName
        {
            get { return fileNameBox.Text; }
        }

        


    }

}

