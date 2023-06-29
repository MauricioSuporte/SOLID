namespace SOLID.OCP.Solution;

public abstract class Payment
{
    public string TransactionId { get; set; } = string.Empty;

    public abstract void MakePayment(decimal value);

    public string GetTransactionId()
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        var random = new Random();
        TransactionId = new string(Enumerable.Repeat(chars, 15)
          .Select(s => s[random.Next(s.Length)]).ToArray());

        return TransactionId;
    }

    public void ReportSucess()
    {
        Console.WriteLine("Payment made successfully.");
        Console.WriteLine($"TransactionId: {TransactionId}");
    }
}
