using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.BL;
using task4.DL;
using task4.UI;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = CircleUI.getCircleInput();
            Rectangle r = RectangleUI.getRectangleInput();
            Square s = SquareUI.getSquareInput();

            ShapeDL.addShapeToList(c);
            ShapeDL.addShapeToList(r);
            ShapeDL.addShapeToList(s);

            ShapeUI.showShapesAndAreas(ShapeDL.shapeList());
        }
    }
}
