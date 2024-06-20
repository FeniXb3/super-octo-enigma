public class Player
{
	string visuals = "@";
    Point position = new Point(2, 3);
    public Point previousPosition = new Point(2, 3);
	
	public void Display()
	{
        Console.SetCursorPosition(position.x, position.y);
		Console.Write(visuals);
	}

    public void MoveTo(Point targetPoint)
    {
        previousPosition.x = position.x;
        previousPosition.y = position.y;

        position.x = targetPoint.x;
        position.y = targetPoint.y;
    }
    
    public Point GetNextPosition()
    {
        Point point = new Point(position.x, position.y);
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