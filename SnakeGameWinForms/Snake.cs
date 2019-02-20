using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGameWinForms
{
    class Snake
    {
        public Snake()
        {

        }

        public Snake(PictureBox snake, Form gameBoard)
        {
            this.GameBoard = (SnakeGame)gameBoard;
            this.snake = snake;
        }

        private PictureBox snake;
        private SnakeGame GameBoard { get; set; }
        private Point PreviousLocation { get; set; }
        private const int pixel_Size = 25;
        public string ImageLoaction { get; set; }
        public PictureBox[] tail;

        public void StopAndReSet()
        {
            snake.Location = new Point(0, 0);
        }


        public void GoUp()
        {
            snake.Location = new Point(snake.Location.X, snake.Location.Y - pixel_Size);
            GameBoard.Refresh();
            Thread.Sleep(100);
        }

        public void GoDown()
        {
            snake.Location = new Point(snake.Location.X, snake.Location.Y + pixel_Size);
            GameBoard.Refresh();
            Thread.Sleep(100);
        }

        public void GoLeft()
        {

            snake.Location = new Point(snake.Location.X - pixel_Size, snake.Location.Y);
            GameBoard.Refresh();
            Thread.Sleep(100);

        }

        public void GoRight()
        {

            snake.Location = new Point(snake.Location.X + pixel_Size, snake.Location.Y);
            GameBoard.Refresh();
            Thread.Sleep(100);
        }

        public bool Die(int height, int width)
        {
            if (snake.Location.X > width || snake.Location.Y > height || snake.Location.X < 0 || snake.Location.Y < 0)
                return true;
            return false;
        }

        public void DrawSnake()
        {
            snake.Visible = true;
            snake.Enabled = true;
            snake.ImageLocation = ImageLoaction;
            GameBoard.Refresh();
        }

        //public bool Eat()
        //{
        //    if ()
        //    {

        //    }

        //        return true;
        //}
    }
}
