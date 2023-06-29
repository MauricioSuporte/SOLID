using System;
using SOLID.ISP.Violation;

namespace EP.SOLID.ISP.Violation;

public class RegisterClient : IRegister
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
}
