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
                // Test kart token'�
                var testCardToken = "tok_visa"; // Bu Stripe taraf�ndan sa�lanan test kart token'�d�r

                StripeConfiguration.ApiKey = "";

                var chargeOptions = new ChargeCreateOptions
                {
                    Amount = 2000, // �deme miktar� (kuru� cinsinden, �rne�in 20.00 TL i�in 2000 kuru�)
                    Currency = "usd",
                    Source = testCardToken,
                    Description = "�rnek �deme"
                };

                var chargeService = new ChargeService();
                Charge charge = chargeService.Create(chargeOptions);
                lblStatus.Text = "�deme ba�ar�l�: " + charge.Id;
            }
            catch (StripeException ex)
            {
                lblStatus.Text = "�deme ba�ar�s�z: " + ex.Message;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Hata: " + ex.Message;
            }
        }
    }
}
