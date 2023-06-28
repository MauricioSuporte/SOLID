namespace SOLID.ISP.Violation;

public interface IRegister
{
    void ValidateData();

    void SaveDatabase();

    void SendEmail();
}
