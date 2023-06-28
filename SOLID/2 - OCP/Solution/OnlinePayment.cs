namespace SOLID.OCP.Solution;

public class OnlinePayment : Payment
{
    public override void MakePayment(decimal value)
    {
        // Make Online Payment validations
        // Make Online Payment

        GetTransactionId();

        ReportSucess();
    }
}
