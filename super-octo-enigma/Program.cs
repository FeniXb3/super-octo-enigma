using System;

public class Program
{
	public static void Main()
	{
        Console.CursorVisible = false;
        Console.Clear();
		Player hero = new Player();
        Map map = new Map();
        Point mapOrigin = new Point(5, 3);
        map.Display(mapOrigin);
        map.DrawSomethingAt(hero.visuals, hero.position);
        while(true)
        {
            Point nextPosition = hero.GetNextPosition();
            if (map.IsPositionCorrect(nextPosition))
            {
                hero.MoveTo(nextPosition);
                map.RedrawCellAt(hero.previousPosition);
                map.DrawSomethingAt(hero.visuals, hero.position);
            }
        }
	}
}