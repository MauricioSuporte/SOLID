namespace SOLID.ISP.Solution.Interface;

internal interface IRegisterClient
{
    void ValidateData();

    void SaveDatabase();

    void SendEmail();
}
