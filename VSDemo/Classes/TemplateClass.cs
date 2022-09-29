public class TemplateClass
{
    private static int nextSerial =1;
    public string _serialNumber;
    private string SerialNumber { get { return "Löpnummer "; } }

    private TemplateClass(int serial)
    {
        _serialNumber = SerialNumber + serial;
    }

    public static TemplateClass CreateInstance()
    {
        return new TemplateClass(nextSerial++);
    }
}

