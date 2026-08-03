using DocumentFormat.OpenXml.Office2016.Excel;

namespace BUGSD.UI.Models;

public class Address
{
    public string? StreetAddress { get;  set; }
    public string? City { get; set; }
    public required string State { get; set; }
    public string? ZipCode { get; set; }

    public Address(string street, string city, string zip)
    {
        StreetAddress = street;
        City = city;
        State = "AL";
        ZipCode = zip;
    }
}