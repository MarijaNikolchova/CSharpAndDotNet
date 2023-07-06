using System.Linq;
using Microsoft.EntityFrameworkCore;
using Azure;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.Net.Mail;
using System;
using System.Collections.Generic;
using ProjectVs;
using ProjectVs.Models;

namespace ProjectVs.Data
{
    public class UserRepository
    {
        private readonly MyDbContext _dbContext;

        public UserRepository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Users GetUserByUsername(string username)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Username == username);
        }
    }
}