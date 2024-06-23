[Serializable]
internal class WindowToSmallToDrawException : Exception
{
    public Point ExpectedSize;
    public WindowToSmallToDrawException(Point expectedSize) : base($"Minimum required window size is ({expectedSize.X}, {expectedSize.Y})")
    {
        ExpectedSize = expectedSize;
        // string message = $"Minimum required window size is ({expectedSize.X}, {expectedSize.Y})";
    }
}