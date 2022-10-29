interface IGeoObject
{
    public double Coord_X {  set; get; }
    public double Coord_Y {  set;get; }
    public string Name { set; get; }
    public  string Description { set; get; }
    void I_Info();
}

class River:IGeoObject

{
    double coord_X;
    double coord_Y;
    double speed;
    double length;
    string name;
    string description;
    public double Coord_X { set { coord_X = value; } get { return coord_X; } }
    public double Coord_Y { set { coord_Y = value; } get { return coord_Y; } }
    public double Speed {  set { speed = value; } get { return speed; } }
    public double Length { set { length = value; } get { return length; } }
    public string Name {  set { name = value; } get { return name; } }
    public string Description {  set { description = value; } get { return description; } }

    void IGeoObject.I_Info()
    {
        Console.WriteLine($"River name: {Name}, river coordinates: ({Coord_X};{Coord_Y}) speed: {Speed}м/с, length: {Length}, description: {Description} ");
    }
    

}

class Mountain: IGeoObject
{
    double coord_X;
    double coord_Y;
    double highestPoint;
    string name;
    string description;
    
    public double Coord_Y {  set { coord_Y = value; } get { return coord_Y; } }
    public double Coord_X { set { coord_X = value; } get { return coord_X; } }
    public double HighestPoint {  set { highestPoint = value; } get { return highestPoint; } }
    public string Name {  set { name = value; } get { return name; } }
    public string Description {  set { description = value; } get { return description; } }

    void IGeoObject.I_Info()
    {
        Console.WriteLine($"Mountain name: {Name}, mountain coordinates: ({Coord_X};{Coord_Y}), highest point: {HighestPoint}, description: {Description} ");
    }

}
