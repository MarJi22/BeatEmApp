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
using System.Windows.Threading;

namespace BeatEmApp
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    
    public partial class Game : Window
    {
        private ImageBrush PlayerSkin = new ImageBrush(); 
        private bool moveLeft, moveRight, moveUp, moveDown, moveLeft2, moveRight2, moveUp2, moveDown2;
        private DispatcherTimer GameTimer = new DispatcherTimer();
        public Game()
        {
            InitializeComponent();

            GameTimer.Interval = TimeSpan.FromMilliseconds(20);
            GameTimer.Tick += GameEngine;
            GameTimer.Start();

            PlayerCanvas.Focus();
        }

        public void OnClick1(object sender, RoutedEventArgs e)
        {
            Window Menu = new Menu();
            this.Visibility = Visibility.Hidden;
            Menu.Show();
        }

        private void GameEngine(object sender, EventArgs e)
        {
            if (moveLeft)
                Canvas.SetLeft(Player1, Canvas.GetLeft(Player1) - 10);
            if (moveRight)
                Canvas.SetLeft(Player1, Canvas.GetLeft(Player1) + 10);
            if (moveUp)
                Canvas.SetTop(Player1, Canvas.GetTop(Player1) - 10);
            if (moveDown)
                Canvas.SetTop(Player1, Canvas.GetTop(Player1) + 10);
            if (moveLeft2)
                Canvas.SetLeft(Player2, Canvas.GetLeft(Player2) - 10);
            if (moveRight2)
                Canvas.SetLeft(Player2, Canvas.GetLeft(Player2) + 10);
            if (moveUp2)
                Canvas.SetTop(Player2, Canvas.GetTop(Player2) - 10);
            if (moveDown2)
                Canvas.SetTop(Player2, Canvas.GetTop(Player2) + 10);

        }

        public void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.A)
            {
                moveLeft2 = true;
            }

            if (e.Key == Key.D)
            {
                moveRight2 = true;
            }

            if (e.Key == Key.W)
            {
                moveUp2 = true;
            }

            if (e.Key == Key.S)
            {
                moveDown2 = true;
            }

            if (e.Key == Key.Left)
            {
                moveLeft = true;
            }

            if (e.Key == Key.Right)
            {
                moveRight = true;
            }

            if (e.Key == Key.Up)
            {
                moveUp = true;
            }

            if (e.Key == Key.Down)
            {
                moveDown = true;
            }

            if (e.Key == Key.L)
            {
                Window GameOver = new GameOver();
                this.Visibility = Visibility.Hidden;
                GameOver.Show();
            }
        }

        public void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.A)
            {
                moveLeft2 = false;
            }

            if (e.Key == Key.D)
            {
                moveRight2 = false;
            }

            if (e.Key == Key.W)
            {
                moveUp2 = false;
            }

            if (e.Key == Key.S)
            {
                moveDown2 = false;
            }

            if (e.Key == Key.Left)
            {
                moveLeft = false;
            }

            if (e.Key == Key.Right)
            {
                moveRight= false;
            }

            if (e.Key == Key.Up)
            {
                moveUp= false;
            }

            if (e.Key == Key.Down)
            {
                moveDown= false;
            }
        }
    }
}
