class Map
{
    string[] mapData = new string[]{
        "#########",
        "#.......#",
        "#.......#",
        "#........",
        "#.......######",
        "#............#",
        "#.......######",
        "#########",
    };
    private Point origin = new Point(0, 0);

    public void Display(Point mapOrigin)
    {
        origin = mapOrigin;
        Console.CursorTop = mapOrigin.Y;
        foreach (string row in mapData)
        {
            Console.CursorLeft = mapOrigin.X;
            Console.WriteLine(row);
        }
    }

    internal void DrawSomethingAt(string visuals, Point position)
    {
        SetCursorPositionWithOrigin(position);
        Console.Write(visuals);
    }

    private void SetCursorPositionWithOrigin(Point position)
    {
        int x = position.X + origin.X;
        int y = position.Y + origin.Y;

        Console.SetCursorPosition(x, y);
    }

    internal bool IsPositionCorrect(Point position)
    {
        if (position.Y >= 0 && position.Y < mapData.Length
            && position.X >= 0 && position.X < mapData[position.Y].Length)
        {
            if (mapData[position.Y][position.X] != '#')
            {
                return true;
            }
        }
        return false;
    }

    internal void RedrawCellAt(Point position)
    {
        string row = mapData[position.Y];
        char cell = row[position.X];

        SetCursorPositionWithOrigin(position);
        Console.Write(cell);
        // To poniżej to to samo co kilka poprzednich linijek
        // Console.SetCursorPosition(position.x, position.y);
        // Console.Write(mapData[position.y][position.x]);
    }
}