abstract class GeoObject
{
    protected double coordX; 
    protected double coordY;
    protected string name;
    protected string description;
    
    public  double CoordX
    {
        set { coordX = value; }
    }
    public  double CoordY { set { coordY = value; } }
    public  string Name {set { name = value; } }
    public  string Description { set {description = value; }}

    public virtual void Info(){}
    
    
}
class  River:GeoObject
{    
     double speed;
     double length;
    public int Speed {set { speed = value; } }
    public int Length { set { length = value; } }

    public override void Info()
    {
        Console.WriteLine($"Name of the river is {name}, coordinats of river are ({coordX};{coordY}), speed is {speed}м/с, length is {length}км description: {description},");
    }
    
}

class Mountain : GeoObject
{
    protected double highestPoint;
    public double HighestPoint { set { highestPoint = value; } }

    public override void Info()
    {
      Console.WriteLine(  $"Name of the mountain is {name}, coordinats of mountain are: ({coordX};{coordY}), highest point: {highestPoint}, description: {description},");
    }


}