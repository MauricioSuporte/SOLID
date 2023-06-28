namespace SOLID.OCP.Solution;

public class DebitCard : Payment
{
    public override void MakePayment(decimal value)
    {
        // Make Debit Card validations
        // Make Debit Card payment

        GetTransactionId();

        ReportSucess();
    }
}
