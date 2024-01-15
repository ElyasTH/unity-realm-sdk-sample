

public class ShapeDamageModel : ShapeMovingModel
{
    public float damage;
    public float health;

    public ShapeDamageModel (int id, float posX, float posY, string shapeType, string color, float velocity , float damage, float health)
    {
        ID = id;
        PosX = posX;
        PosY = posY;
        ShapeType = shapeType;
        Color = color;
        Velocity = velocity;
        damage = damage;
        health = health;
    }
}