namespace SOLID.OCP.Violation;

public class Payment
{
    public void MakePayment(decimal value, PaymentType paymentType)
    {
        if (paymentType == PaymentType.CreditCard)
        {
            // Make the Credit Card logic validation
            // Make Credit Card payment
        }

        if (paymentType == PaymentType.DebitCard)
        {
            // Make the Debit Card logic validation
            // Make Debit Card payment
        }
    }
}
