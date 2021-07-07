namespace CommonData
{
    public interface IShape
    {
        string Name { get; set; }

        double Volume();
    }
}
