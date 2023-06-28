namespace SOLID.SRP.Solution;

public static class CPFService
{
    public static bool IsValid(string cpf)
    {
        return cpf.Length == 11;
    }
}