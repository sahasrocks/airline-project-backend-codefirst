﻿using Class20AirProCodeFTry.Models;
using Microsoft.AspNetCore.Mvc;

namespace Class20AirProCodeFTry.UsrRepo
{
    public interface IUsrRepo
    {
        Task<ActionResult<IEnumerable<User>>> GetUsers();
        Task<ActionResult<User>> PostUsers(User user);
        Task<ActionResult<User>> PutUsers(User user);
        Task<ActionResult<User>> DeleteUsers(string id);
        Task<ActionResult<User>> Login(string username,string password);
        Task<ActionResult<User>> CheckAdminLogin(string username, string password);
    }
}
