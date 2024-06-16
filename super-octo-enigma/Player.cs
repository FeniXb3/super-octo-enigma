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

        // position = targetPoint;
        position.x = targetPoint.x;
        position.y = targetPoint.y;
    }
    
    public Point GetNextPosition()
    {
        // Point point = new Point();
        // point.x = 2;
        // point.y = 5;
        // Point point = new Point()
        // {
        //     x = 2,
        //     y = 5
        // };
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

/*
Klasa Player

dane:
- pozycja
- zdrowie (aktualne/maksymalne)
- bazowy atak
- reprezentacja graficzna
- pancerz

akcje:
- poruszanie się
- atak
- podnoszenie przedmiotów
- obrywanie
- leczenie
- wyświetlenie na ekranie
- animacja

*/