using UnityEngine;

namespace _Project.Scripts.Utility
{
    public static class Serializer
    {

        public static ShapeType GetShapeType(string shapeType)
        {
            switch (shapeType)
            {
                case "Circle": return ShapeType.Circle;
                case "Square": return ShapeType.Square;
                case "Triangle": return ShapeType.Triangle;
            }

            return ShapeType.None;
        }


        public static Color GetColor()
        {
            return Color.black;
        }
        
    }
}