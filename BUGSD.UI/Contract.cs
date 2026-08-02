namespace BUGSD.UI;

public class Contract
{
    public required string PurchaserName { get; set; }
    public string? PurchaserPhone { get; set; }
    public string? PurchaserEmail { get; set; }
    public string? PurchaserBillingAddress { get; set; }
    public string? PurchaserBillingCity { get; set; }
    public string PurchaserBillingState { get; set; } = "AL";
    public string? PurchaserBillingZip { get; set; }
    public required string PropertyDescription { get; set; }
    public DateTime EffectiveDate { get; set; }
    public DateTime EndOfContractDate { get; set; }
    public required string ContractPrice { get; set; }
    public required string RenewalPrice { get; set; }
    
}