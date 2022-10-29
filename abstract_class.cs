abstract class GeoObject
{
    protected double coordX;
    protected double coordY;
    protected string name;
    protected string description;

    public double CoordX{ get { return coordX; } set { coordX = value;}}
    public double CoordY { get { return coordY; } set { coordY = value; } }
    public string Name { get { return name; } set { name = value; } }
    public string Description { get { return description; } set { description = value; } }

    public virtual void Info() { Console.Write($"Name of object: {Name}, coordinats: ({CoordX};{CoordY}),"); }


}
class River : GeoObject
{
    double speed;
    double length;
    public double Speed { get { return speed; } set { speed = value; } }
    public double Length { get { return length; } set { length = value; } }

    public override void Info()
    {
        base.Info();
        Console.WriteLine($" speed: {Speed}м/с, length: {Length}км, description: {Description}");
    }

}

class Mountain : GeoObject
{
    double highestPoint;
    public double HighestPoint { get { return highestPoint; } set { highestPoint = value; } }

    public override void Info()
    {
        base.Info();
        Console.WriteLine($" highest point: {HighestPoint}m, description: {Description}");
    }


}
