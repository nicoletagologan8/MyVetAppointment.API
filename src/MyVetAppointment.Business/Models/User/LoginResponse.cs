﻿namespace MyVetAppointment.Business.Models.User;

public class LoginResponse
{
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Role { get; set; }
    public string Token { get; set; }
}