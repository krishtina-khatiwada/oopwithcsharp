namespace singleton
{
    sealed class Uploadservice
{
    private Uploadservice(){}
    public int Id { get; private set; }
    private static Uploadservice _instance;
    private static readonly object _lock = new object();
    public static Uploadservice Instance(int id)
{
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Uploadservice();
                        _instance.Id = id;
                    }
                }
            }
        return _instance;
}
}

}