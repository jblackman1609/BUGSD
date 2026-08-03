namespace BUGSD.UI.Models;

public class Contract : Model
{
    public Header Header {get; set; }
    public Address CustomerAddress { get; set; }
    public string CustomerName { get; set; }
    public required string PropertyDescription { get; set; }
    public DateTime EffectiveDate { get; set; }
    public DateTime EndOfContractDate { get; set; }
    public required string ContractPrice { get; set; }
    public required string RenewalPrice { get; set; }
    public required string BondType { get; set; }
    public required string ContractType { get; set; }
     
    public Contract(string id, 
                    DateTime createdAt, 
                    string custName, 
                    string propertyDesc, 
                    string bondType, 
                    string contractType,
                    string contractPrice,
                    string renewalPrice) : base(id, createdAt)
    {
        PropertyDescription = propertyDesc;
        BondType = bondType;
        ContractType = contractType;
        ContractPrice = contractPrice;
        RenewalPrice = renewalPrice;
    }
}