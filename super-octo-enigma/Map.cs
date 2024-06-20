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
        Console.CursorTop = mapOrigin.y;
        foreach (string row in mapData)
        {
            Console.CursorLeft = mapOrigin.x;
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
        int x = position.x + origin.x;
        int y = position.y + origin.y;

        Console.SetCursorPosition(x, y);
    }

    internal bool IsPositionCorrect(Point position)
    {
        if (position.y >= 0 && position.y < mapData.Length
            && position.x >= 0 && position.x < mapData[position.y].Length)
        {
            if (mapData[position.y][position.x] != '#')
            {
                return true;
            }
        }
        return false;
    }

    internal void RedrawCellAt(Point position)
    {
        string row = mapData[position.y];
        char cell = row[position.x];

        SetCursorPositionWithOrigin(position);
        Console.Write(cell);
        // To poniżej to to samo co kilka poprzednich linijek
        // Console.SetCursorPosition(position.x, position.y);
        // Console.Write(mapData[position.y][position.x]);
    }
}