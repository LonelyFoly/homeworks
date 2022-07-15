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
using System.IO;
using System.Windows.Threading;

namespace Для_отчёт_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Song> songs = new List<Song>();
        int currSongIndex;
        bool Playing = false;


        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var dir = new DirectoryInfo("songs");
            foreach (FileInfo file in dir.GetFiles())
            {
                TagLib.File fd = TagLib.File.Create(file.FullName);
                songs.Add(new Song(file.FullName, file.Name, fd.Tag.FirstPerformer, fd.Tag.Title));
                

            }
            myPlayList.ItemsSource = songs;
            currSongIndex = 0;
            myMedia.Source = new Uri(songs[0].Path);

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if ((myMedia.Source != null) && (myMedia.NaturalDuration.HasTimeSpan) &&(!Dragging))
            {
                slProgress.Minimum = 0;
                slProgress.Maximum = myMedia.NaturalDuration.TimeSpan.TotalSeconds;
                slProgress.Value = myMedia.Position.TotalSeconds;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Border_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void myPlayList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (myPlayList.Items.Count>0)
            {
                currSongIndex = myPlayList.SelectedIndex;
                myMedia.Source = new Uri(songs[currSongIndex].Path);
                myMedia.Play();
                Playing = true;

                tbTMP.Text = currSongIndex.ToString() + " - " +
                    songs[currSongIndex].Singer + " - " +
                    songs[currSongIndex].Track;
            }
        }

        private void bPrev_Click(object sender, RoutedEventArgs e)
        {
            currSongIndex--;
            if (currSongIndex == -1) currSongIndex = songs.Count - 1;
            myMedia.Source = new Uri(songs[currSongIndex].Path);
            myMedia.Play();
            tbTMP.Text = currSongIndex.ToString() + " - " +
                    songs[currSongIndex].Singer + " - " +
                    songs[currSongIndex].Track;
        }

        private void bPlay_Click(object sender, RoutedEventArgs e)
        {
            if (Playing)
            {
                myMedia.Pause();
                (bPlay.Content as Image).Source = new BitmapImage(new Uri("play.png", UriKind.Relative));
            }
            else
            {

                myMedia.Play();
                (bPlay.Content as Image).Source = new BitmapImage(new Uri("pause.png", UriKind.Relative));
            }
            Playing = !Playing;
            tbTMP.Text = currSongIndex.ToString() + " - " +
                songs[currSongIndex].Singer + " - " +
                songs[currSongIndex].Track;
        }

        private void bStop_Click(object sender, RoutedEventArgs e)
        {
            myMedia.Stop();
        }

        private void bNext_Click(object sender, RoutedEventArgs e)
        {
            currSongIndex++;
            if (currSongIndex == songs.Count) currSongIndex = 0;
            myMedia.Source = new Uri(songs[currSongIndex].Path);
            myMedia.Play();
            tbTMP.Text = currSongIndex.ToString() + " - " +
                    songs[currSongIndex].Singer + " - " +
                    songs[currSongIndex].Track;
        }

        private void slProgress_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            tbStatus.Text = TimeSpan.FromSeconds(slProgress.Value).ToString(@"hh\:mm\:ss");
        }

        bool Dragging = false;
        private void slProgress_DragStarted(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {
            Dragging = true;
        }

        private void slProgress_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            Dragging = false;
            if (Playing) myMedia.Position = TimeSpan.FromSeconds(slProgress.Value);
        }

        private void pbVolume_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            myMedia.Volume += (e.Delta > 0) ? 0.1 : -0.1;
        }
    }
}
