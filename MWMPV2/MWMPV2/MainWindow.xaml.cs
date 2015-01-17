/// YILMAZ EMRAH EPITECH STRASBOURG

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Resources;
using System.Xml;
using TagLib;
using MWMPV2.Class;

namespace MWMPV2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool fullscreen = false;
        private int tmp_Mtimer = 0;
        private System.Windows.Threading.DispatcherTimer MTimer = new System.Windows.Threading.DispatcherTimer();
        private bool IsPlaying = false;
        private bool Repeat = false;
        private bool Playlist = false;
        private int CurrentIndex = -1;
        private bool LibEnabled = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string tmp = "";

            ofd.AddExtension = true;
            ofd.DefaultExt = "*.*";
            ofd.Filter = "Media Files (*.*)|*.*";
            ofd.ShowDialog();

            try
            {
                MElem.Source = new Uri(ofd.FileName);
                MainWindow1.Title = ofd.FileName;
            }
            catch
            {
                new NullReferenceException("Error");
            }

            System.Windows.Threading.DispatcherTimer DTimer = new System.Windows.Threading.DispatcherTimer();
            DTimer.Tick += new EventHandler(T_Tick);
            DTimer.Interval = new TimeSpan(0, 0, 1);
            DTimer.Start();
            try
            {
                TagLib.File tagFile = TagLib.File.Create(ofd.FileName);
                tmp = ofd.SafeFileName + " / Album : " + tagFile.Tag.Album + " / Artist : " + tagFile.Tag.Performers[0];
                Lbl_Title.Content = tmp;
            }
            catch
            {
                Lbl_Title.Content = ofd.SafeFileName;
            }
        }

        private void T_Tick(object sender, EventArgs e)
        {
            VSlide.Value = MElem.Position.TotalSeconds;
        }

        private void btn_Play_Click(object sender, RoutedEventArgs e)
        {
            MElem.Play();
            IsPlaying = true;
        }

        private void btn_Pause_Click(object sender, RoutedEventArgs e)
        {
            MElem.Pause();
            IsPlaying = false;
        }

        private void btn_Stop_Click(object sender, RoutedEventArgs e)
        {
            MElem.Stop();
            MElem.Close();
            IsPlaying = false;
        }

        private void VSlide_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TimeSpan TS = TimeSpan.FromSeconds(e.NewValue);
            MElem.Position = TS;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MElem.Volume = VolSlide.Value;
        }

        private void MElem_MediaOpened(object sender, RoutedEventArgs e)
        {
            if (MElem.NaturalDuration.HasTimeSpan)
            {
                TimeSpan TS = TimeSpan.FromMilliseconds(MElem.NaturalDuration.TimeSpan.TotalMilliseconds);
                VSlide.Maximum = TS.TotalSeconds;
            }
        }

        private void VSlide_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            MElem.Play();
            IsPlaying = true;
        }

        private void VSlide_DragStarted(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {
            MElem.Pause();
            IsPlaying = false;
        }

        private void MElem_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            MainCanvas.Visibility = Visibility.Visible;
            if (LibEnabled)
            {
                LibCanvas.Visibility = Visibility.Visible;
            }
            tmp_Mtimer = 0;
        }

        private void MainWindow1_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            MainCanvas.Visibility = Visibility.Visible;
            if (LibEnabled)
            {
                LibCanvas.Visibility = Visibility.Visible;
            }
            tmp_Mtimer = 0;
            Mouse.OverrideCursor = System.Windows.Input.Cursors.Arrow;
        }

        private void MTimer_Tick(object sender, EventArgs e)
        {
            if (tmp_Mtimer >= 4)
            {
                MainCanvas.Visibility = Visibility.Hidden;
                if (LibEnabled)
                {
                    LibCanvas.Visibility = Visibility.Hidden;
                }
                Mouse.OverrideCursor = System.Windows.Input.Cursors.None;
            }
            tmp_Mtimer++;
        }

        private void MainCanvas_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            MTimer.Stop();
        }

        private void MainCanvas_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            tmp_Mtimer = 0;
            MTimer.Interval = new TimeSpan(0, 0, 1);
            MTimer.Tick += MTimer_Tick;
            MTimer.Start();
        }

        private void Btn_FullScreen_Click(object sender, RoutedEventArgs e)
        {
            if (!fullscreen)
            {
                WindowState = System.Windows.WindowState.Maximized;
                WindowStyle = System.Windows.WindowStyle.None;
                fullscreen = true;
            }
            else
            {
                WindowState = System.Windows.WindowState.Normal;
                WindowStyle = System.Windows.WindowStyle.SingleBorderWindow;
                fullscreen = false;
            }
        }

        private void MainWindow1_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Escape && fullscreen == true)
            {
                WindowState = System.Windows.WindowState.Normal;
                WindowStyle = System.Windows.WindowStyle.SingleBorderWindow;
                fullscreen = false;
            }
            if (e.Key == Key.Space)
            {
                if (IsPlaying == false)
                {
                    MElem.Play();
                    IsPlaying = true;
                }
                else
                {
                    MElem.Pause();
                    IsPlaying = false;
                }
            }
            if (e.Key == Key.Left || e.Key == Key.B)
            {
                Btn_Prev.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Primitives.ButtonBase.ClickEvent));
            }
            if (e.Key == Key.Right || e.Key == Key.N)
            {
                Btn_Next.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Primitives.ButtonBase.ClickEvent));
            }
        }

        private void MElem_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (fullscreen == false)
                {
                    WindowState = System.Windows.WindowState.Maximized;
                    WindowStyle = System.Windows.WindowStyle.None;
                    fullscreen = true;
                }
                else
                {
                    WindowState = System.Windows.WindowState.Normal;
                    WindowStyle = System.Windows.WindowStyle.SingleBorderWindow;
                    fullscreen = false;
                }
            }
        }

        private void Btn_Repeat_Click(object sender, RoutedEventArgs e)
        {
            Uri resourceUri;

            if (!Repeat)
            {
                resourceUri = new Uri("Images/RepeatOnHD.png", UriKind.Relative);
                Repeat = true;
            }
            else
            {
                resourceUri = new Uri("Images/RepeatHD.png", UriKind.Relative);
                Repeat = false;
            }
            StreamResourceInfo streamInfo = System.Windows.Application.GetResourceStream(resourceUri);

            BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
            var brush = new ImageBrush();
            brush.ImageSource = temp;

            Btn_Repeat.Background = brush;
        }

        private void MElem_MediaEnded(object sender, RoutedEventArgs e)
        {
            if (Repeat)
            {
                MElem.Position = TimeSpan.Zero;
                MElem.Play();
                IsPlaying = true;
            }
            else if (Playlist)
            {
                if (CurrentIndex == -1)
                {
                    CurrentIndex = Library.SelectedIndex;
                }
                if (CurrentIndex < Library.Items.Count)
                {
                    CurrentIndex++;
                }
                if (CurrentIndex < Library.Items.Count && CurrentIndex >= 0)
                {
                    PlaylistItem tmp_itm = Library.Items[CurrentIndex] as PlaylistItem;
                    OpenFileDialog ofd = new OpenFileDialog();
                    string tmp = "";

                    try
                    {
                        MElem.Source = new Uri(tmp_itm.Title);
                        MainWindow1.Title = tmp_itm.Content.ToString();
                        ofd.FileName = tmp_itm.Title;
                    }
                    catch
                    {
                        new NullReferenceException("Error");
                    }

                    System.Windows.Threading.DispatcherTimer DTimer = new System.Windows.Threading.DispatcherTimer();
                    DTimer.Tick += new EventHandler(T_Tick);
                    DTimer.Interval = new TimeSpan(0, 0, 1);
                    DTimer.Start();
                    VSlide.Value = 0;
                    MElem.Play();
                    IsPlaying = true;
                    Playlist = true;

                    try
                    {
                        TagLib.File tagFile = TagLib.File.Create(ofd.FileName);
                        tmp = ofd.SafeFileName + " / Album : " + tagFile.Tag.Album + " / Artist : " + tagFile.Tag.Performers[0];
                        Lbl_Title.Content = tmp;
                    }
                    catch
                    {
                        Lbl_Title.Content = ofd.SafeFileName;
                    }
                }
                else
                {

                }
            }
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.AddExtension = true;
            ofd.DefaultExt = "*.*";
            ofd.Filter = "Media Files (*.*)|*.*";
            ofd.ShowDialog();

            try
            {
                PlaylistItem tmp_itm = new PlaylistItem();

                tmp_itm.Title = ofd.FileName;
                tmp_itm.Content = ofd.SafeFileName;
                tmp_itm.MouseDoubleClick += tmp_itm_MouseDoubleClick;
                tmp_itm.Foreground = new SolidColorBrush(Colors.Cyan);

                Library.Items.Add(tmp_itm);
            }
            catch
            {
                new NullReferenceException("Error");
            }
        }

        void tmp_itm_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            PlaylistItem tmp_itm = sender as PlaylistItem;
            OpenFileDialog ofd = new OpenFileDialog();
            string tmp = "";

            try
            {
                MElem.Source = new Uri(tmp_itm.Title);
                MainWindow1.Title = tmp_itm.Content.ToString();
                ofd.FileName = tmp_itm.Title;
            }
            catch
            {
                new NullReferenceException("Error");
            }

            System.Windows.Threading.DispatcherTimer DTimer = new System.Windows.Threading.DispatcherTimer();
            DTimer.Tick += new EventHandler(T_Tick);
            DTimer.Interval = new TimeSpan(0, 0, 1);
            DTimer.Start();
            MElem.Play();
            IsPlaying = true;
            Playlist = true;
            CurrentIndex = Library.SelectedIndex;

            try
            {
                TagLib.File tagFile = TagLib.File.Create(ofd.FileName);
                tmp = ofd.SafeFileName + " / Album : " + tagFile.Tag.Album + " / Artist : " + tagFile.Tag.Performers[0];
                Lbl_Title.Content = tmp;
            }
            catch
            {
                Lbl_Title.Content = ofd.SafeFileName;
            }
        }

        private void Btn_Lib_Click(object sender, RoutedEventArgs e)
        {
            if (LibCanvas.Visibility == Visibility.Visible)
            {
                LibCanvas.Visibility = Visibility.Hidden;
                LibEnabled = false;
            }
            else if (LibEnabled == false)
            {
                LibCanvas.Visibility = Visibility.Visible;
                LibEnabled = true;
            }
        }

        private void Btn_Prev_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentIndex == -1)
            {
                CurrentIndex = Library.SelectedIndex;
            }
            if (CurrentIndex > 0)
            {
                CurrentIndex--;
            }
            if (CurrentIndex < Library.Items.Count && CurrentIndex >= 0)
            {
                PlaylistItem tmp_itm = Library.Items[CurrentIndex] as PlaylistItem;
                OpenFileDialog ofd = new OpenFileDialog();
                string tmp = "";

                try
                {
                    MElem.Source = new Uri(tmp_itm.Title);
                    MainWindow1.Title = tmp_itm.Content.ToString();
                    ofd.FileName = tmp_itm.Title;
                }
                catch
                {
                    new NullReferenceException("Error");
                }

                System.Windows.Threading.DispatcherTimer DTimer = new System.Windows.Threading.DispatcherTimer();
                DTimer.Tick += new EventHandler(T_Tick);
                DTimer.Interval = new TimeSpan(0, 0, 1);
                DTimer.Start();
                MElem.Play();
                IsPlaying = true;
                Playlist = true;

                try
                {
                    TagLib.File tagFile = TagLib.File.Create(ofd.FileName);
                    tmp = ofd.SafeFileName + " / Album : " + tagFile.Tag.Album + " / Artist : " + tagFile.Tag.Performers[0];
                    Lbl_Title.Content = tmp;
                }
                catch
                {
                    Lbl_Title.Content = ofd.SafeFileName;
                }
            }
            else
            {

            }
        }

        private void Btn_Next_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentIndex == -1)
            {
                CurrentIndex = Library.SelectedIndex;
            }
            if (CurrentIndex < Library.Items.Count)
            {
                CurrentIndex++;
            }
            if (CurrentIndex < Library.Items.Count && CurrentIndex >= 0)
            {
                PlaylistItem tmp_itm = Library.Items[CurrentIndex] as PlaylistItem;
                OpenFileDialog ofd = new OpenFileDialog();
                string tmp = "";

                try
                {
                    MElem.Source = new Uri(tmp_itm.Title);
                    MainWindow1.Title = tmp_itm.Content.ToString();
                    ofd.FileName = tmp_itm.Title;
                }
                catch
                {
                    new NullReferenceException("Error");
                }

                System.Windows.Threading.DispatcherTimer DTimer = new System.Windows.Threading.DispatcherTimer();
                DTimer.Tick += new EventHandler(T_Tick);
                DTimer.Interval = new TimeSpan(0, 0, 1);
                DTimer.Start();
                MElem.Play();
                IsPlaying = true;
                Playlist = true;

                try
                {
                    TagLib.File tagFile = TagLib.File.Create(ofd.FileName);
                    tmp = ofd.SafeFileName + " / Album : " + tagFile.Tag.Album + " / Artist : " + tagFile.Tag.Performers[0];
                    Lbl_Title.Content = tmp;
                }
                catch
                {
                    Lbl_Title.Content = ofd.SafeFileName;
                }
            }
            else
            {

            }
        }

        private void Btn_Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "Playlist.xml";
            sfd.ShowDialog();
            string savePath = sfd.FileName;

            try
            {
                using (XmlWriter writer = XmlWriter.Create(sfd.FileName))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Playlist");

                    for (int i = 0; i < Library.Items.Count; i++)
                    {
                        PlaylistItem tmp_itm = Library.Items[i] as PlaylistItem;

                        writer.WriteElementString("Path", tmp_itm.Content.ToString(), tmp_itm.Title);
                    }
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Load_Playlist_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.AddExtension = true;
            ofd.DefaultExt = "*.*";
            ofd.Filter = "Media Files (*.*)|*.*";
            ofd.ShowDialog();

            try
            {
                using (XmlReader reader = XmlReader.Create(ofd.FileName))
                {
                    while (reader.Read())
                    {
                        if (reader.IsStartElement())
                        {
                            switch (reader.Name)
                            {
                                case "Playlist":
                                    Library.Items.Clear();
                                    break;
                                case "Path":
                                    string attribute = reader["xmlns"];
                                    PlaylistItem tmp_itm = new PlaylistItem();

                                    tmp_itm.MouseDoubleClick += tmp_itm_MouseDoubleClick;
                                    tmp_itm.Foreground = new SolidColorBrush(Colors.Cyan);
                                    if (attribute != null)
                                    {
                                        tmp_itm.Content = attribute;
                                    }
                                    if (reader.Read())
                                    {
                                        tmp_itm.Title = reader.Value.Trim();
                                        Library.Items.Add(tmp_itm);
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }
    }

}
