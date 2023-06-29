using System;
using SOLID.ISP.Violation;

namespace EP.SOLID.ISP.Violation;

public class RegisterProduct : IRegister
{
    public void ValidateData()
    {
        // Validate values
    }

    public void SaveDatabase()
    {
        // Insert Product database
    }

    public void SendEmail()
    {
        throw new NotImplementedException("Product has no email");
    }
}
