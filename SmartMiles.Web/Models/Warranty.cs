using System;

public class Warranty
{
    public int Id
    {
        get;
        set;
    }

    public WarrantyTypes Type
    {
        get;
        set;
    }//manufacturer or extended

    public DateTime? EffectiveDate
    {
        get;
        set;
    }

    public DateTime? ExpiryDate
    {
        get;
        set;
    }

    public WarrantyAdministrator Warrantor
    {
        get;
        set;
    }

    public string Notes
    {
        get;
        set;
    }
}
