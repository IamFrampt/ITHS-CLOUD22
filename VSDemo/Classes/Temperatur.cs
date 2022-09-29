public class Temperatur
{
    private double _c;
    private double _f;
    private double _k;
    public double Celsius
    {
        get { return _c; }
        set { _c = value; }
    }
    public double Farenheit
    {
        get
        {
            return _f;
        }
        set { _f = (this._c * 1.8d) + 32; }
    }
    public double Kelvin
    {
        get
        {
            return _k;
        }
        set { _k = this._c + 273.15d; }
    }

    public Temperatur(double _C)
    {
        this.Celsius = _C;
        this.Farenheit = this._f;
        this.Kelvin = this._k;
    }

    public Temperatur()
    {
        this._c = 0;
    }

}
