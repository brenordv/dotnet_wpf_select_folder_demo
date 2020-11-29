using System.Windows;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace WpfSelectDirDemo
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

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            using var dialog = new CommonOpenFileDialog {IsFolderPicker = true};

            if (dialog.ShowDialog() != CommonFileDialogResult.Ok)
            {
                TxtLabel.Content = "User Canceled";
                return;
            }

            TxtLabel.Content = dialog.FileName;
        }
    }
}