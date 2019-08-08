using System;
using System.Windows;

using WinForm = System.Windows.Forms;
using System.IO;


namespace GlobalLogic_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WinForm.FolderBrowserDialog folderDialog = new WinForm.FolderBrowserDialog();
            folderDialog.ShowNewFolderButton = false;
            folderDialog.SelectedPath = System.AppDomain.CurrentDomain.BaseDirectory;
            WinForm.DialogResult result = folderDialog.ShowDialog();

            if (result == WinForm.DialogResult.OK)
            {
                String sPath = folderDialog.SelectedPath;
                DirectoryItems di = new DirectoryItems(new DirectoryInfo(sPath));
                string results = "Inpyt example: " + sPath + "\n \nOutput example: \n \n" + di.JsonToDynatree();
                textBox.Text = results; 
            }
        }
    }
}
