namespace BUGSD.UI.Models;

public class Header
{
    public required string CompanyName { get; set; }
    public required string CompanyAddress { get; set; }
    public required string CompanyPhone { get; set; }

    public Header(string name, string address, string phone)
    {
        CompanyName = name;
        CompanyAddress = address;
        CompanyPhone = phone;
    }
}