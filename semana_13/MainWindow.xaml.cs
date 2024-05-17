using Microsoft.Win32;
using System.Text;
using System.Windows;
using System;
using System.Windows;
using GuessTheNumber;

namespace GuessTheNumber
{
    public partial class MainWindow : Window
    {
        private Game _game;

        public MainWindow()
        {
            InitializeComponent();
            _game = new Game();
        }

        private void ButtonPlay_Click(object sender, RoutedEventArgs e)
        {
            _game.Play();
        }
    }
}