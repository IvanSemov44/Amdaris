
namespace FacadeDesignPattern
{
    public class Order
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Place order started");

            Product product = new Product();
            product.GetProductDetails();

            Payment payment = new Payment();
            payment.MakePayment();

            Invoice invoice  = new Invoice();
            invoice.SendInvoice();

            Console.WriteLine("Order placed successfully");
        }
    }
}
