using System.ComponentModel.DataAnnotations;

public class Address
{
    [MaxLength(50), MinLength(5)]
    public string StreetAddress
    {
        get;
        set;
    }
    [MaxLength(50), MinLength(0)]
    public string StreetAddressLine2
    {
        get;
        set;
    }

    [MaxLength(50), MinLength(2)]
    public string City
    {
        get;
        set;
    }
    [MaxLength(40), MinLength(2)]
    public string State
    {
        get;
        set;
    }

    [DataType(DataType.PostalCode)]    
    public string Zip
    {
        get;
        set;
    }

    public string Country { get; set; }

}