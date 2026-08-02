namespace BUGSD.UI;

public class ContractTemplate
{
    public required string Header { get; set; } 
    public required string BondStatement { get; set; }
    public required string ContractStatement { get; set; }
    public required string PurchaserLabel { get; set; }
    public required string PurchaserPhoneLabel { get; set; }
    public required string StreetAddressLabel { get; set; }
    public required string BillingZipCode { get; set; }
    public required string BillingCountry { get; set; }
}