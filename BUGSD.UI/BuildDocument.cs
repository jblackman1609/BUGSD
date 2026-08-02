
using System.Runtime.Serialization;
using BUGSD.UI;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
public class BuildDocument
{
    private static string contractStatement = "This Contract provides for the retreatment of the infested areas of the covered structure(s)"
        + " and the repair of damage caused by subterranean termites only within teh limits stated in this Contract.";
    private static string rootPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); 
    //private static string contractFolder = rootPath;  //"Docs\\SampleContract8.docx";
    
    public static void Build(Contract contract)
    {
        string contractName = rootPath + "\\" + contract.PurchaserName;
        using (WordprocessingDocument wordDoc = WordprocessingDocument.Create(contractName, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
        {
            MainDocumentPart mainPart = wordDoc.AddMainDocumentPart(); 
            mainPart.Document = new Document(new Body(BuildHeader(), BuildPurchaserInfo(contract), BuildParagraphs()));
            mainPart.Document.Save();
       }
       Console.WriteLine("Word document created successfully!");
   }

    private static Paragraph BuildHeader()
    {
        Run headerRun = 
           new Run(
            new RunProperties(
                new Bold(),   
                new FontSize() { Val = "36" }), 
            new Text("BRADSHAW PEST CONTROL"), 
            new Break(), new Text("244 Davis Street East Elba, AL 36323"), 
            new Break(), new Text("334-897-6531"),
            new Break(), new Text("Subterranean Termite Control Bond"));

        Run contractRun = 
           new Run(
            new RunProperties(
                new Bold(),  
                new FontSize() { Val = "30" }), 
            new Text(contractStatement));

        Paragraph paragraph = 
        new Paragraph(
            new ParagraphProperties(new Justification() { Val = JustificationValues.Center }), headerRun, new Break(), contractRun);
        return paragraph;
    }

    private static Paragraph BuildPurchaserInfo(Contract contract)
    {
        Run purchaserRun = new Run(new RunProperties(new FontSize() { Val = "24" }));
        purchaserRun.Append(new Text("PURCHASER: ")); 
        purchaserRun.Append(new Text(contract.PurchaserName));
        purchaserRun.Append(new Text("   "));
        purchaserRun.Append(new Text("PHONE: "));
        purchaserRun.Append(new Text(contract.PurchaserPhone ?? string.Empty));
        purchaserRun.Append(new Text("   "));
        purchaserRun.Append(new Text("EMAIL: "));
        purchaserRun.Append(new Text(contract.PurchaserEmail ?? string.Empty));
        purchaserRun.Append(new Break());

        Run addressRun = new Run(new RunProperties(new FontSize() { Val = "24" }));
        addressRun.Append(new Text("STREET ADDRESS: "));
        addressRun.Append(new Text(contract.PurchaserBillingAddress ?? string.Empty));
        addressRun.Append(new Break());
        addressRun.Append(new Text("STATE: "));
        addressRun.Append(new Text("AL"));
        addressRun.Append(new Break());
        addressRun.Append(new Text("CITY: "));
        addressRun.Append(new Text(contract.PurchaserBillingCity ?? string.Empty));
        addressRun.Append(new Break());
        addressRun.Append(new Text("ZIP: "));
        addressRun.Append(new Text(contract.PurchaserBillingZip ?? string.Empty));
        addressRun.Append(new Break());
        addressRun.Append(new Text("PROPERTY DESCRIPTION: "));
        addressRun.Append(new Text(contract.PropertyDescription)); 

        return new Paragraph(purchaserRun, addressRun);
    }

    private static Paragraph BuildDates(Contract contract)
    {
        Run datesRun = new Run(new RunProperties(new FontSize() { Val = "24" }));
        datesRun.Append(new Text("EFFECTIVE DATE: "));
        datesRun.Append(new Text(contract.EffectiveDate.ToShortDateString()));
        datesRun.Append(new Break());
        datesRun.Append(new Text("END OF CONTRACT DATE: "));
        datesRun.Append(new Text(contract.EndOfContractDate.ToShortDateString()));
        datesRun.Append(new Break());
        datesRun.Append(new Text("CONTRACT PRICE: "));
        datesRun.Append(new Text(contract.ContractPrice));
        return new Paragraph(datesRun);
    }

    private static Paragraph BuildParagraphs()
    {
        ContractBody body = new ContractBody(); 
        Run run = new Run();
        run.Append(new Text(body.Paragraph1Text));
        run.Append(new Text(body.Paragraph2Text));

        return new Paragraph(run);
    }
}