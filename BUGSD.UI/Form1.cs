using BUGSD.UI.Models;

namespace BUGSD.UI;

public partial class Form1 : Form
{
    // Make controls fields so event handlers can access them
    private TextBox customerNameTextBox;
    private TextBox customerPhoneTextBox;
    private TextBox customerEmailTextBox;
    private TextBox billingAddressTextBox;
    private TextBox billingCityTextBox;
    private TextBox billingZipTextBox;
    private TextBox contractPurchasePriceTextBox;
    private ComboBox propertyDescriptionComboBox;
    private ComboBox renewalFeeTextBox;
    private DateTimePicker effectiveDatePicker;
    private DateTimePicker endOfContractDatePicker;
    private Button submitButton;

    public Form1()
    {
        InitializeComponent();

        //Purchaser (Customer) Name Label: Textbox
        var customerNameLabel = new Label()
        {
            Text = "Purchaser (Customer) Name:",
            Location = new Point(50, 50),
            AutoSize = true
        };
        this.Controls.Add(customerNameLabel);

        customerNameTextBox = new TextBox()
        {
            Location = new Point(250, 50),
            Width = 200
        };
        this.Controls.Add(customerNameTextBox);

        //Purchaser (Customer) Phone Label: Textbox
        var customerPhoneLabel = new Label()
        {
            Text = "Purchaser (Customer) Phone:",
            Location = new Point(50, 80),
            AutoSize = true
        };
        this.Controls.Add(customerPhoneLabel);

        customerPhoneTextBox = new TextBox()
        {
            Location = new Point(250, 80),
            Width = 200
        };
        this.Controls.Add(customerPhoneTextBox);

        //Purchaser (Customer) Email Label: Textbox
        var customerEmailLabel = new Label()
        {
            Text = "Purchaser (Customer) Email:",
            Location = new Point(50, 110),
            AutoSize = true
        };
        this.Controls.Add(customerEmailLabel);

        customerEmailTextBox = new TextBox()
        {
            Location = new Point(250, 110),
            Width = 200
        };
        this.Controls.Add(customerEmailTextBox);

        //Purchaser (Billing) Street Address Label: Textbox 
        var billingAddressLabel = new Label()
        {
            Text = "Purchaser (Billing) Street Address:",
            Location = new Point(50, 140),
            AutoSize = true
        };       
        this.Controls.Add(billingAddressLabel);

        billingAddressTextBox = new TextBox()
        {
            Location = new Point(250, 140),
            Width = 200
        };
        this.Controls.Add(billingAddressTextBox);

        //Purchaser (Billing) City Label: Textbox
        var billingCityLabel = new Label()
        {
            Text = "Purchaser (Billing) City:",
            Location = new Point(50, 170),
            AutoSize = true
        };
        this.Controls.Add(billingCityLabel);

        billingCityTextBox = new TextBox()
        {
            Location = new Point(250, 170),
            Width = 200
        };
        this.Controls.Add(billingCityTextBox);

        //Purchaser (Billing) Zip Code Label: Textbox
        var billingZipLabel = new Label()
        {
            Text = "Purchaser (Billing) Zip Code:",
            Location = new Point(50, 200),
            AutoSize = true
        };
        this.Controls.Add(billingZipLabel);

        billingZipTextBox = new TextBox()
        {
            Location = new Point(250, 200),
            Width = 200
        };
        this.Controls.Add(billingZipTextBox);

        //Property Description Label: Dropdown (Residential, Commercial)
        var propertyDescriptionLabel = new Label()
        {
            Text = "Property Description:",
            Location = new Point(50, 230),
            AutoSize = true
        };
        this.Controls.Add(propertyDescriptionLabel);

        propertyDescriptionComboBox = new ComboBox()
        {
            Text = "Select Property Description",
            Location = new Point(250, 230),
            Width = 200
        };
        propertyDescriptionComboBox.Items.Add("Residential");
        propertyDescriptionComboBox.Items.Add("Commercial");
        this.Controls.Add(propertyDescriptionComboBox);

        //Effective Date Label: Date Picker
        var effectiveDateLabel = new Label()
        {
            Text = "Effective Date:",
            Location = new Point(50, 260),
            AutoSize = true
        };
        this.Controls.Add(effectiveDateLabel);

        effectiveDatePicker = new DateTimePicker()
        {
            Location = new Point(250, 260),
            Width = 200
        };
        this.Controls.Add(effectiveDatePicker);

        //End of Contract Date Label: Date Picker
        var endOfContractDateLabel = new Label()
        {
            Text = "End of Contract Date:",
            Location = new Point(50, 290),
            AutoSize = true
        };
        this.Controls.Add(endOfContractDateLabel);

        endOfContractDatePicker = new DateTimePicker()
        {
            Location = new Point(250, 290),
            Width = 200
        };
        this.Controls.Add(endOfContractDatePicker);

        //Contract Purchase Price Label: Textbox
        var contractPurchasePriceLabel = new Label()
        {
            Text = "Contract Purchase Price:",
            Location = new Point(50, 320),
            AutoSize = true
        };
        this.Controls.Add(contractPurchasePriceLabel);

        contractPurchasePriceTextBox = new TextBox()
        {
            Location = new Point(250, 320),
            Width = 200
        };
        this.Controls.Add(contractPurchasePriceTextBox);

        var renewalFeeLabel = new Label()
        {
            Text = "Annual Renewal Fee:",
            Location = new Point(50, 350),
            AutoSize = true
        };
        this.Controls.Add(renewalFeeLabel);

        renewalFeeTextBox = new ComboBox()
        {
            Text = "Select Renewal Fee",
            Location = new Point(250, 350),
            Width = 200
        };
        renewalFeeTextBox.Items.Add("$120");
        renewalFeeTextBox.Items.Add("$130");
        renewalFeeTextBox.Items.Add("$150");
        renewalFeeTextBox.Items.Add("$170");
        renewalFeeTextBox.Items.Add("$175");
        renewalFeeTextBox.Items.Add("$200");
        renewalFeeTextBox.Items.Add("$250");
        this.Controls.Add(renewalFeeTextBox);

        //Submit Button
        submitButton = new Button()
        {
            Text = "Generate",
            Location = new Point(150, 380),
            Width = 100,
            Height = 30
        };
        submitButton.Click += SubmitButton_Click;
        this.Controls.Add(submitButton);
    }

    private void SubmitButton_Click(object? sender, EventArgs e)
    {
        //var contract = new Contract
        //{
            //PurchaserName = customerNameTextBox.Text,
            //PurchaserPhone = customerPhoneTextBox.Text,
            //PurchaserEmail = customerEmailTextBox.Text,
            //PurchaserBillingAddress = billingAddressTextBox.Text,
            //PurchaserBillingCity = billingCityTextBox.Text,
            //PurchaserBillingZip = billingZipTextBox.Text,
          //  PropertyDescription = propertyDescriptionComboBox.SelectedItem?.ToString() ?? string.Empty,
          //  EffectiveDate = effectiveDatePicker.Value,
          //  EndOfContractDate = endOfContractDatePicker.Value,
          //  ContractPrice = contractPurchasePriceTextBox.Text,
          //  RenewalPrice = renewalFeeTextBox.SelectedItem?.ToString() ?? string.Empty
        //};

        //BuildDocument.Build(contract);
        
        // Handle the button click event here
        MessageBox.Show("Form submitted!");
    }
}
