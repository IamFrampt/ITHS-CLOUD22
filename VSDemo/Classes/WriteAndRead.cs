public class WriteAndRead
    {
    private static string _write = string.Empty;
    public static string Read { get { return _write; } }
    public static string Write { set { _write = value; } }


    public WriteAndRead()
    {
        
    }

}

