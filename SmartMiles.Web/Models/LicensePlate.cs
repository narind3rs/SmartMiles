using System;

public class LicensePlate
{
    public int Id
    {
        get;
        set;
    }

    public string State
    {
        get;
        set;
    }

    public string Number
    {
        get;
        set;
    }

    public DateTime ReceivedDate
    {
        get;
        set;
    }

    public DateTime? ExpiryDate
    {
        get;
        set;
    }

    public DateTime? RenewalDueDate
    {
        get;
        set;
    }

    public DateTime? LastRenewedDate
    {
        get;
        set;
    }


}