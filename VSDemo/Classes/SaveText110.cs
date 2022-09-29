public class SaveText110
{
    private static string _text = string.Empty;
    public static int _vowels = 0;
    public static int _consonants = 0;
    public static int totalLength =0;
    public static int averageLength = 0;
    public static int instances = 0;

    public string Text { get { return _text; } set { _text = value; } }

    private static char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };
    private static char[] consonant = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'y', 'z' };


    public int Vowels { get { return _vowels; } }
    public int Consonants { get { return _consonants; } }

    private SaveText110(string sentence)
    {
        _text = sentence;
        VowelsAndConsonants();
    }

    public static void VowelsAndConsonants()
    {
        for (int i = 0; i < _text.Length; i++)
        {
            if (_text[i].Equals(" ")) { continue; }
            else
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (_text[i].Equals(vowels[j]))
                    {
                        _vowels++;
                        break;
                    }
                }
                for (int k = 0; k < consonant.Length; k++)
                {
                    if (_text[i].Equals(consonant[k]))
                    {
                        _consonants++;
                        break;
                    }
                }
            }
        }

        totalLength += _text.Length;
        averageLength = totalLength / instances;
    }

    public static SaveText110 CreateInstance(string Text)
    {
        instances++;
        return new SaveText110(Text);
    }

}
