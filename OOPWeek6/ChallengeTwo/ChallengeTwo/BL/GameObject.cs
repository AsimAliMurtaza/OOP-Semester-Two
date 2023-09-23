using ChallengeTwo.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo.BL
{
    internal class GameObject
    {
        public char[,] Shape;
        public Point StartingPoint;
        public Boundary Premises;
        public string Direction;

        public GameObject()
        {
            char[,] temp = { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };
            this.Shape = temp;
            this.StartingPoint = new Point();
            this.Premises = new Boundary();
            this.Direction = "LeftToRight";
        }

        public GameObject(char[,] Shape, Point StartingPoint)
        {
            this.Shape = Shape;
            this.StartingPoint = StartingPoint;
            this.Premises = new Boundary();
            this.Direction = "LeftToRight";
        }

        public GameObject(char[,] Shape, Point StartingPoint, Boundary Premisis, string direction)
        {
            this.Shape = Shape;
            this.StartingPoint = StartingPoint;
            this.Premises = Premisis;
            this.Direction = direction;
        }
        public void Erase()
        {
            DriverUI.Erase(Shape, StartingPoint.getX(), StartingPoint.getY());
        }
        public void Draw()
        {
            DriverUI.Draw(Shape, StartingPoint.getX(), StartingPoint.getY());
        }

        public void move()
        {
            if (Direction == "LeftToRight")
            {
                if (StartingPoint.getX() < Premises.TopRight.getX())
                {
                    StartingPoint.setX(StartingPoint.getX() + 1);
                }
            }
            else if (Direction == "RightToLeft")
            {
                if (StartingPoint.getX() > Premises.TopLeft.getX())
                {
                    StartingPoint.setX(StartingPoint.getX() - 1);
                }
            }
            else if (Direction == "Patrol")
            {
                if (StartingPoint.getX() > Premises.TopRight.getX())
                {
                    StartingPoint.setX(StartingPoint.getX() - 1);
                }
                else
                {
                    Direction = "Patrol";
                }
            }
            else if (Direction == "Patrol")
            {
                if (StartingPoint.getX() < Premises.TopLeft.getX())
                {
                    StartingPoint.setX(StartingPoint.getX() + 1);
                }
                else
                {
                    Direction = "Patrol";
                }
            }
            else if (Direction == "Projectile")
            {
                StartingPoint.setX(StartingPoint.getX() + 2);
                StartingPoint.setY(StartingPoint.getY() + 1);
            }
            else if (Direction == "Diagonal")
            {
                if (StartingPoint.getX() < Premises.BottomRight.getX())
                {
                    StartingPoint.setX(StartingPoint.getX() + 1);
                }
                if (StartingPoint.getY() < Premises.BottomRight.getY())
                {
                    StartingPoint.setY(StartingPoint.getY() + 1);
                }
            }
        }
    }
}
