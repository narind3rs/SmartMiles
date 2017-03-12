using System;

public class Odometer
{
    public int Id { get; set; }

    public OdometerUnits Units
    {
        get;
        set;
    }//miles or km

    public string Reading
    {
        get;
        set;
    }

    public DateTime ReadingDate
    {
        get;
        set;
    }
}