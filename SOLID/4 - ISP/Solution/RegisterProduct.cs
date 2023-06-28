using SOLID.ISP.Solution.Interface;

namespace SOLID.ISP.Solution;

internal class RegisterProduct : IRegisterProduct
{
    public void SaveDatabase()
    {
        // Validate CPF, Email, etc
    }

    public void ValidateData()
    {
        throw new NotImplementedException();
    }
}
