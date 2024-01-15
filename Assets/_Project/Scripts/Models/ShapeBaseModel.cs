using Realms;
using UnityEngine;

namespace _Project.Scripts.Models
{
    public class ShapeBaseModel : RealmObject
    {
        [PrimaryKey] public int ID { get; set; }
        
        public float PosX { get; set; }
        public float PosY { get; set; }
        public string ShapeType { get; set; }
        public string Color { get; set; }
        
        public ShapeBaseModel(int id, float posX, float posY, string shapeType, string color){
            ID = id;
            PosX = posX;
            PosY = posY;
            ShapeType = shapeType;
            Color = color;
        }
    }
    
   
}
