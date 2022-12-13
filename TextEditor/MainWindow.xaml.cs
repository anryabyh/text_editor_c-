using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace TextEditor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void StartApplication()
        {
            ResetInterface();
        }

        private readonly string TitleBar = "Текстовый редактор";

        private string _fileName;

        private void ResetInterface()
        {
            txtMain.Text = "";
            winMain.Title = TitleBar;
            _fileName = "";
            FileSave.IsEnabled = false;
        }

        private void LoadFile()
        {
            txtMain.Text = "";

            // Select a file from disk
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == true)
            {
                _fileName = openFileDialog.FileName;

                // Read file
                var streamReader = new StreamReader(_fileName);
                var textFromFile = streamReader.ReadToEnd();
                txtMain.Text = textFromFile;

                winMain.Title = _fileName + "  - " + TitleBar;
                FileSave.IsEnabled = true;
            }
            else
            {
                // No file chosen
            }

        }

        public void SaveFile()
        {
            // TODO Should we allow this if there is no text entered
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Сохранить файл как";
            saveFileDialog.ShowDialog();
            var saveFileAsName = saveFileDialog.FileName + ".txt";

            // Above save dialog deals with file overwriting
            if (File.Exists(saveFileAsName))
            {

            }

            File.WriteAllText(saveFileAsName, txtMain.Text);

            FileSave.IsEnabled = true;
            MenuClose.IsEnabled = true;
            _fileName = saveFileAsName;
            winMain.Title = saveFileAsName + " - " + TitleBar;
        }


        private void FileOpen_Click(object sender, RoutedEventArgs e)
        {
            LoadFile();
        }

        private void FileNew_Click(object sender, RoutedEventArgs e)
        {
            ResetInterface();
        }

        private void FileSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFile();
        }

        private void btnBold_Checked(object sender, RoutedEventArgs e)
        {
            txtMain.FontWeight = FontWeights.Bold;
        }

        private void btnBold_Unchecked(object sender, RoutedEventArgs e)
        {
            txtMain.FontWeight = FontWeights.Normal;
        }

        private void btnItalic_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btnItalic_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void btnUnderline_Checked(object sender, RoutedEventArgs e)
        {
            txtMain.TextDecorations = TextDecorations.Underline;
        }

        private void btnUnderline_Unchecked(object sender, RoutedEventArgs e)
        {
            txtMain.FontWeight = FontWeights.Normal;
        }

        private void MenuClose_Click(object sender, RoutedEventArgs e)
        {
            CreateFileWindow createFileWindow = new CreateFileWindow();
            if (createFileWindow.ShowDialog() == true)
                _fileName = createFileWindow.FileName;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void winMain_Loaded(object sender, RoutedEventArgs e)
        {
            DirectoryInfo dinfo = new DirectoryInfo(@"C:\Users\ryaby\Downloads\TextEditor\TextEditor\data\");
            FileInfo[] files = dinfo.GetFiles("*.txt");
            foreach (FileInfo filename in files)
            {
                string a = System.IO.Path.GetFileNameWithoutExtension(filename.Name);
                listBox.Items.Add(a);
            }
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedsr = listBox.SelectedItem.ToString();
            MessageBox.Show(selectedsr);
             txtMain.Text = File.ReadAllText(selectedsr);
        
    }

        private void txtMain_KeyDown(object sender, KeyEventArgs e)
        {
            UpdateCursorPosition();
        }

        private void txtMain_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateCursorPosition();
        }

        private void txtMain_SelectionChanged(object sender, RoutedEventArgs e)
        {
            UpdateCursorPosition();
        }
        private void UpdateCursorPosition()
        {
            int row = txtMain.GetLineIndexFromCharacterIndex(txtMain.CaretIndex);
            int col = txtMain.CaretIndex - txtMain.GetLineIndexFromCharacterIndex(row);
            cursorPosition.Text = $"строка: {row + 1} столбец: {col + 1}";
        }
    }
}
