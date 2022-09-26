public class RednBlue
{

    private float RedValue;
    private float BlueValue;
    public float blue = 0f;
    public float red =0f;
    private float total;

    public RednBlue()
    {
        this.BlueValue = 50f;
        this.RedValue = 50f;
        this.total = this.BlueValue + this.RedValue;
    }


    public float Red
    {
      get { return this.RedValue  = (Math.Abs(Math.Clamp(this.red, 0.0f, 100.0f) - this.RedValue )) + (this.BlueValue- Math.Clamp(this.blue,0.0f,100.0f)); }
    }

    public float Blue
    {
        get { return this.BlueValue = total - this.RedValue; }

    }
}

