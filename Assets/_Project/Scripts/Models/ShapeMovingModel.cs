

public class ShapeMovingModel: ShapeBaseModel
{
    public float velocity;

    public ShapeMovingModel(int id, float posX, float posY, string shapeType, string color, float velocity)
    {
        ID = id;
        PosX = posX;
        PosY = posY;
        ShapeType = shapeType;
        Color = color;
        velocity = velocity;
    }
}