using System.Dynamic;

public class TemplateClass
{

    public string id;

    private TemplateClass(int num)
        {
        this.id = GetName + num;
        }

    private string GetName
    {
        get { return "Löpnummer "; }

    }

    public static TemplateClass CreateInstance(int num)
    {
        return new TemplateClass(num);
    }
}

