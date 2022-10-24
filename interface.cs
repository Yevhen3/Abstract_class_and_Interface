interface IGeoObject
{
   public double Coord_X {  set; }
   public double Coord_Y {  set; }
   public string Name { set; }
   public  string Description { set; }
   void I_Info(){}

    

}

class River:IGeoObject

{
     double coord_X;
     double coord_Y;
     double speed;
     double length;
     string name;
     string description;
    public double Coord_X { set { coord_X = value; } }
    public double Coord_Y { set { coord_Y = value; } }
    public double Speed {  set { speed = value; } }
    public double Length { set { length = value; } }
    public string Name {  set { name = value; } }
    public string Description {  set { description = value; } }

     void IGeoObject.I_Info()
    {
        Console.WriteLine($"River name: {name}, river coordinates: ({coord_X};{coord_Y}) speed: {speed}м/с, length: {length}, description: {description} ");
    }
    

}

class Mountain: IGeoObject
{
     double coord_X;
     double coord_Y;
     double highestPoint;
     string name;
     string description;
    
    public double Coord_Y {  set { coord_Y = value; } }
    public double Coord_X { set { coord_X = value; } }
    public double HighestPoint {  set { highestPoint = value; } }
    public string Name {  set { name = value; } }
    public string Description {  set { description = value; } }

    void IGeoObject.I_Info()
    {
        Console.WriteLine($"Mountain name: {name}, mountain coordinates: ({coord_X};{coord_Y}), highest point: {highestPoint}, description: {description} ");
    }

}