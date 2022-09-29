public class Number
{
    private int _number = 0;
    List<int> allNumbers = new List<int>();

    public int myNumber
    {
        get
        {
            return _number;
        }
        set
        {
            _number = value;
            allNumbers.Add(_number);
            GetHistory();
        }
    }

    public int[] GetHistory()
    {
        int[] history = new int[allNumbers.Count];

        for (int i = 0; i < allNumbers.Count; i++)
        {
            history[i] = allNumbers[i];
        }

        return history;
    }

}
