﻿using System;

public class Program
{
	public static void Main()
	{
        Console.CursorVisible = false;
        Console.Clear();
        Point startingPoint  = new Point(2, 3);
		Player hero = new Player("@", startingPoint);
        Enemy troll = new Enemy("T", new Point(4, 5));
        Map map = new Map();
        Point mapOrigin = new Point(5, 3);

        try
        {
            map.Display(mapOrigin);
            map.DrawSomethingAt(hero.Visuals, hero.Position);

            map.DrawSomethingAt(troll.Visuals, troll.Position);
            while(true)
            {
                Point nextPosition = hero.GetNextPosition();
                if (map.IsPositionCorrect(nextPosition))
                {
                    hero.MoveTo(nextPosition);
                    map.RedrawCellAt(hero.PreviousPosition);
                    map.DrawSomethingAt(hero.Visuals, hero.Position);
                }

                nextPosition = troll.GetNextPosition();
                if (map.IsPositionCorrect(nextPosition))
                {
                    troll.MoveTo(nextPosition);
                    map.RedrawCellAt(troll.PreviousPosition);
                    map.DrawSomethingAt(troll.Visuals, troll.Position);
                }
            }
        }
        catch (WindowToSmallToDrawException ex)
        {
            Console.WriteLine("Terminal window is to small to draw map. Make it bigger and restart the game.");
            Console.WriteLine(ex.Message);
            // Console.WriteLine($"Minimum required window size is ({ex.ExpectedSize.X}, {ex.ExpectedSize.Y})");
            Console.WriteLine("Press any key to close...");
            Console.ReadKey(true);
        }
        
	}
}