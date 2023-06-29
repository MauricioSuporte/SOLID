using SOLID.ISP.Solution.Interface;

namespace SOLID.ISP.Solution;

internal class RegisterClient : IRegisterClient
{
    public void ValidateData()
    {
        // Validate values
    }

    public void SaveDatabase()
    {
        // Insert Client database
    }

    public void SendEmail()
    {
        // Send email to client
    }

    public void ReportSucess()
    {
        Console.WriteLine("Successfully registered client.");
    }
}
