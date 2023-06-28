namespace SOLID.OCP.Solution;

public class CreditCard : Payment
{
    public override void MakePayment(decimal value)
    {
        // Make Credit Card validations
        // Make Credit Card payment

        GetTransactionId();

        ReportSucess();
    }
}
