using System;
using System.Collections.Generic;
namespace Qix_Game
{
    public class Ball
    {
        public int ballPositionX { get; set; }
        public int ballPositionY { get; set; }
        private ConsoleColor ballColor { get; set; }
        private static char ballChar { get; set; }
        public bool up { get; set; }
        public bool right { get; set; }
        public CellStatus currentPosition = CellStatus.Ball;

        public Ball(int x, int y, bool up, bool right, ConsoleColor color = ConsoleColor.White, char character = '@')
        {
            ballPositionX = x;
            ballPositionY = y;
            ballChar = character;
            this.up = up;
            this.right = right;
        }

        public void MoveBall(GameField field)
        {

            DrawEngine.PrintStringOnPosition(ballPositionY, ballPositionX, " ");
            List<int> collisionPoint = Collision(field);
            if (up)
            {
                ballPositionY--;
            }
            else
            {
                ballPositionY++;
            }
            if (right)
            {
                ballPositionX++;
            }
            else
            {
                ballPositionX--;
            }
            if (!CheckKill(field))
            {
                //Console.SetCursorPosition(ballPositionX, ballPositionY);
                //Console.Write(ballChar);
                DrawEngine.PrintStringOnPosition(ballPositionY, ballPositionX, ballChar.ToString());
            }
            else
            {
                Game.Kill();
            }

            //Redraw the collision point
            if (collisionPoint.Count > 0)
            {
                for (int i = 0; i < collisionPoint.Count; i += 2)
                {
                    DrawEngine.PrintOnPosition(collisionPoint[i + 1], collisionPoint[i], DrawEngine.CellColor(CellStatus.Filled));
                }
            }
        }

        private bool CheckKill(GameField field)
        {
            if (field.gameField[ballPositionY, ballPositionX] == CellStatus.Trail)
            {
                return true;
            }
            return false;
        }

        public List<int> Collision(GameField field)
        {
            List<int> collisionPoint = new List<int>();
            bool isRightTopFull = (field.gameField[ballPositionY - 1, ballPositionX + 1] == CellStatus.Filled);
            bool isLeftTopFull = (field.gameField[ballPositionY - 1, ballPositionX - 1] == CellStatus.Filled);
            bool isBottomLeftFull = (field.gameField[ballPositionY + 1, ballPositionX - 1] == CellStatus.Filled);
            bool isBottomRightFull = (field.gameField[ballPositionY + 1, ballPositionX + 1] == CellStatus.Filled);
            bool isLeftFull = (field.gameField[ballPositionY, ballPositionX - 1] == CellStatus.Filled);
            bool isRightFull = (field.gameField[ballPositionY, ballPositionX + 1] == CellStatus.Filled);
            bool isTopFull = (field.gameField[ballPositionY - 1, ballPositionX] == CellStatus.Filled);
            bool isBottomFull = (field.gameField[ballPositionY + 1, ballPositionX] == CellStatus.Filled);

            //Top left
            if (up && !right && isLeftTopFull && !isLeftFull && !isTopFull)
            {
                up = !up;
                right = !right;
            }
            //Top right
            else if (up && right && isRightTopFull && !isRightFull && !isTopFull)
            {
                up = !up;
                right = !right;
            }
            //Bottom left
            else if (!up && !right && isBottomLeftFull && !isLeftFull  && !isBottomFull)
            {
                up = !up;
                right = !right;
            }
            //Bottom right
            else if (!up && right && isBottomRightFull && !isRightFull && !isBottomFull)
            {
                up = !up;
                right = !right;
            }
            else
            {
                if (isTopFull)
                {
                    up = !up;
                    collisionPoint.Add(ballPositionX);
                    collisionPoint.Add(ballPositionY - 1);
                }
                if (isRightFull)
                {
                    right = !right;
                    collisionPoint.Add(ballPositionX + 1);
                    collisionPoint.Add(ballPositionY);
                }
                if (isBottomFull)
                {
                    up = !up;
                    collisionPoint.Add(ballPositionX);
                    collisionPoint.Add(ballPositionY + 1);
                }
                if (isLeftFull)
                {
                    right = !right;
                    collisionPoint.Add(ballPositionX - 1);
                    collisionPoint.Add(ballPositionY);
                }
            }

            return collisionPoint;
        }
    }
}