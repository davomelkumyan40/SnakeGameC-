using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SnakeGameWinForms
{
    public partial class SnakeGame : Form
    {
        public SnakeGame()
        {
            InitializeComponent();
            _Height = game_panel.Height;
            _Width = game_panel.Width;
            InitializeFruitPositions();
        }

        private int _Height;
        private int _Width;
        private Snake s;
        private Snake_Action s_Action = Snake_Action.Stop;
        private int Score { get; set; }
        Random rnd = new Random();
        private Dictionary<Point, PictureBox> fruits;


        private void InitializeFruitPositions()
        {
            fruits = new Dictionary<Point, PictureBox>(5);
            var t = DevideArr((int[])GiveRandomDivToFiveNotEqual(0, 600));
            for (int i = 0; i < 5; i++)
            {
                fruits.Add(new Point(t.Item1[i], t.Item2[i]), new PictureBox { BackColor = Color.Red, Size = new Size(25, 25) });
            }
        }


        private Tuple<int[], int[]> DevideArr(int[] arr)
        {
            int count = 0;
            int[] arr1 = new int[arr.Length / 2];
            int[] arr2 = new int[arr.Length / 2];
            for (int i = 0; i < arr.Length; i++)
            {
                if (count > 4)
                    arr2[i - 5] = arr[i];
                else
                {
                    arr1[i] = arr[i];
                    count++;
                }
            }
            return Tuple.Create(arr1, arr2);
        }

        private IEnumerable<int> GiveRandomDivToFiveNotEqual(int num1, int num2)
        {
            int numCount = 0;
            int num = 0;
            List<int> lst = new List<int>(10);
            do
            {
                num = rnd.Next(num1, num2);
                if ((num % 25) == 0 && NotEqual(lst, num) && num != 0)
                {
                    lst.Add(num);
                    numCount++;
                }
            } while (numCount != 10);
            return lst.ToArray();
        }

        private bool NotEqual(IEnumerable<int> coll, int num)
        {
            if (((List<int>)coll).Count != 0)
                foreach (var item in coll)
                {
                    if (num == item)
                        return false;
                }
            return true;
        }

        private void DrawFruits(Dictionary<Point, PictureBox> fruits)
        {
            foreach (var item in fruits)
            {
                game_panel.Controls.Add(item.Value);
                item.Value.Location = item.Key;
                item.Value.Visible = true;
                item.Value.Enabled = true;
                this.Refresh();
            }
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (s != null)
            {
                switch (e.KeyValue)
                {
                    case (int)Keys.W:
                        {
                            s_Action = Snake_Action.Up;
                        }
                        break;
                    case (int)Keys.S:
                        {
                            s_Action = Snake_Action.Down;
                        }
                        break;
                    case (int)Keys.D:
                        {
                            s_Action = Snake_Action.Right;
                        }
                        break;
                    case (int)Keys.A:
                        {
                            s_Action = Snake_Action.Left;
                        }
                        break;
                }
            }
        }

        private void DeleteFruits()
        {
            foreach (var item in fruits.Values)
            {
                item.Visible = false;
                item.Enabled = false;
            }
        }


        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (s != null)
            {
                s_Action = Snake_Action.Lose;
                s.StopAndReSet();
                DeleteFruits();
                InitializeFruitPositions();
            }
            else
            {
                s = new Snake(snake, this);
                key_Checker.Enabled = true;
            }
            s.DrawSnake();
            DrawFruits(fruits);
            Refresh();
        }

        private void key_Checker_Tick(object sender, EventArgs e)
        {
            switch (s_Action)
            {
                case Snake_Action.Up:
                    {
                        s.GoUp();
                        if (s.Die(_Height, _Width))
                            lose_label.Text = "You Lose";
                        Refresh();
                    }
                    break;
                case Snake_Action.Down:
                    {
                        s.GoDown();
                        if (s.Die(_Height, _Width))
                            lose_label.Text = "You Lose";
                        Refresh();
                    }
                    break;
                case Snake_Action.Right:
                    {
                        s.GoRight();
                        if (s.Die(_Height, _Width))
                            lose_label.Text = "You Lose";
                        Refresh();
                    }
                    break;
                case Snake_Action.Left:
                    {
                        s.GoLeft();
                        if (s.Die(_Height, _Width))
                            lose_label.Text = "You Lose";
                        Refresh();
                    }
                    break;
                case Snake_Action.Lose:
                    {
                        s.StopAndReSet();
                        Refresh();
                    }
                    break;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
