using System;
using SOLID.ISP.Violation;

namespace EP.SOLID.ISP.Violation;

public class RegisterClient : IRegister
{
    public void ValidateData()
    {
        // Validate value
    }

    public void SaveDatabase()
    {
        // Insert Client database
    }

    public void SendEmail()
    {
        throw new NotImplementedException("Product has no email");
    }
}
