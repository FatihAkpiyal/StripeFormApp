using Stripe;

namespace Stripe_FormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Test kart token'ý
                var testCardToken = "tok_visa"; // Bu Stripe tarafýndan saðlanan test kart token'ýdýr

                StripeConfiguration.ApiKey = "";

                var chargeOptions = new ChargeCreateOptions
                {
                    Amount = 2000, // Ödeme miktarý (kuruþ cinsinden, örneðin 20.00 TL için 2000 kuruþ)
                    Currency = "usd",
                    Source = testCardToken,
                    Description = "Örnek Ödeme"
                };

                var chargeService = new ChargeService();
                Charge charge = chargeService.Create(chargeOptions);
                lblStatus.Text = "Ödeme baþarýlý: " + charge.Id;
            }
            catch (StripeException ex)
            {
                lblStatus.Text = "Ödeme baþarýsýz: " + ex.Message;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Hata: " + ex.Message;
            }
        }
    }
}
