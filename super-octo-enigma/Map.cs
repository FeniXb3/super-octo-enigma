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

    public void Display()
    {
        foreach (string row in mapData)
        {
            Console.WriteLine(row);
        }
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

        Console.SetCursorPosition(position.x, position.y);
        Console.Write(cell);
        // To poniżej to to samo co kilka poprzednich linijek
        // Console.SetCursorPosition(position.x, position.y);
        // Console.Write(mapData[position.y][position.x]);
    }
}