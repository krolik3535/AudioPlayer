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
using Microsoft.Win32;

namespace WpfApp2
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

        MediaPlayer mediaPlayer = new MediaPlayer();
        string filename;


        private void OF_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Multiselect = false,
                DefaultExt = ".mp3"
            };
            bool? dialogOk = openFileDialog.ShowDialog();
            if (dialogOk == true)
            {
                filename = openFileDialog.FileName;
                TBFileName.Text = openFileDialog.SafeFileName;
                mediaPlayer.Open(new Uri(filename));
            }
              
        }
        private void button_click(object sender, RoutedEventArgs e)
        {
            Close();
        }
                    

        private void Play_button(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
        }

        private void Pause_button(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
        }
       
    }
    
}

