using System;
using System.Collections.Generic;
using UnityEngine;

namespace _Project.Scripts
{
    [CreateAssetMenu]
    public class ShapeData : ScriptableObject
    {
        public List<ShapeSprite> shapeSprites;
    
        public Sprite GetSprite(ShapeType shapeType)
        {
            foreach (var shapeSprite in shapeSprites)
            {
                if (shapeSprite.shapeType == shapeType)
                {
                    return shapeSprite.sprite;
                }
            }

            return null;
        }
    }


    [Serializable]
    public class ShapeSprite
    {
        public ShapeType shapeType;
        public Sprite sprite;
    }
}