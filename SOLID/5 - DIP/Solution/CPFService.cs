namespace SOLID.DIP.Solution;

public class CPFService : ICPFService
{
    public bool IsValid(string cpf)
    {
        return cpf.Length == 11;
    }
}
