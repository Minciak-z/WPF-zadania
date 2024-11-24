using System;
using System.Windows;
using Microsoft.Win32;
using System.Windows.Media;
using System.Windows.Controls;

namespace MediaPlayerApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PrzyciskOtworz_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki multimedialne (*.mp3; *.mp4)|*.mp3;*.mp4";

            if (openFileDialog.ShowDialog() == true)
            {
                mediaElement.Source = new Uri(openFileDialog.FileName);
                if (openFileDialog.FileName.EndsWith(".mp3"))
                {
                    mediaElement.LoadedBehavior = MediaState.Manual;  
                }
                else
                {
                    mediaElement.LoadedBehavior = MediaState.Manual;  
                }
                mediaElement.Play();
                przyciskPlayPause.Content = "Pauza";
            }
        }

        private void PrzyciskPlayPause_Click(object sender, RoutedEventArgs e)
        {
            if (mediaElement.LoadedBehavior == MediaState.Play)
            {
                mediaElement.Pause();
                przyciskPlayPause.Content = "Start";
            }
            else
            {
                mediaElement.Play();
                przyciskPlayPause.Content = "Pauza";
            }
        }

        private void PrzyciskStop_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Stop();
            przyciskPlayPause.Content = "Start";
        }

        private void SliderPostep_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (mediaElement.NaturalDuration.HasTimeSpan)
            {
                mediaElement.Position = TimeSpan.FromSeconds(sliderPostep.Value * mediaElement.NaturalDuration.TimeSpan.TotalSeconds / 100);
            }
        }

        private void SliderGlosnosc_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaElement.Volume = sliderGlosnosc.Value;
        }

        private void MediaElement_MediaOpened(object sender, RoutedEventArgs e)
        {
            sliderPostep.Maximum = mediaElement.NaturalDuration.TimeSpan.TotalSeconds;
        }

        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            mediaElement.Stop();
            przyciskPlayPause.Content = "Start";
            sliderPostep.Value = 0; 
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (mediaElement.NaturalDuration.HasTimeSpan)
            {
                sliderPostep.Value = mediaElement.Position.TotalSeconds / mediaElement.NaturalDuration.TimeSpan.TotalSeconds * 100;
            }
        }
    }
}
