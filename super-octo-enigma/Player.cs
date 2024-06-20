public class Player
{

    public string Visuals { get; private set; } = "@";
    public Point Position { get; private set; } = new Point(2, 3);
    public Point PreviousPosition { get; private set; } = new Point(2, 3);
	
	public void Display()
	{
        Console.SetCursorPosition(Position.x, Position.y);
		Console.Write(Visuals);
	}

    public void MoveTo(Point targetPoint)
    {
        PreviousPosition.x = Position.x;
        PreviousPosition.y = Position.y;

        Position.x = targetPoint.x;
        Position.y = targetPoint.y;
    }
    
    public Point GetNextPosition()
    {
        Point point = new Point(Position.x, Position.y);
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        if (keyInfo.Key == ConsoleKey.D)
        {
            point.x += 1;
        }
        else if (keyInfo.Key == ConsoleKey.A)
        {
            point.x -= 1;
        }
        else if (keyInfo.Key == ConsoleKey.W)
        {
            point.y -= 1;
        }
        else if (keyInfo.Key == ConsoleKey.S)
        {
            point.y += 1;
        }
        
        return point;
    }
}