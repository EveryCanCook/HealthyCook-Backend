﻿using HealthyCook_Backend.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyCook_Backend.Domain.IRepositories
{
    public interface IUserRepository
    {
        Task SaveUser(User user);
        Task<bool> ValidateExistence(User user);
        Task<User> SearchUser(int userID);
        Task DeleteUser(User user);
    }
}
