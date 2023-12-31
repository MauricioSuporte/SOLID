﻿using SOLID.SRP.Solution;

namespace SOLID.DIP.Violation;

public class Client
{
    public int ClientId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string CPF { get; set; } = string.Empty;

    public DateTime RegisterDate { get; set; }

    public bool IsValid()
    {
        return EmailService.IsValid(Email) && CPFService.IsValid(CPF);
    }
}
