using SOLID.ISP.Solution.Interface;

namespace SOLID.ISP.Solution;

internal class RegisterClient : IRegisterClient
{
    public void ValidateData()
    {
        // Validate CPF, Email, etc
    }

    public void SendEmail()
    {
        // Insert Client database
    }

    public void SaveDatabase()
    {
        throw new NotImplementedException("Product has no email");
    }
}
