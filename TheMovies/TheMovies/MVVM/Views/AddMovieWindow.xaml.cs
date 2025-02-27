﻿using System;
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
using TheMovies.MVVM.Model;
using TheMovies.MVVM.ViewModel;

namespace TheMovies.MVVM.Views
{
    /// <summary>
    /// Interaction logic for AddMovieWindow.xaml
    /// </summary>
    /// 

    public partial class AddMovieWindow : Window
    {
        public AddMovieWindow()
        {
            InitializeComponent();

            DataContext = new CreateFilmViewModel();
        }

        private void new_Clicked(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
