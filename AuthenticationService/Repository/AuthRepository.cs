﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationService.Models;

namespace AuthenticationService.Repository
{
    public class AuthRepository : IAuthRepository
    {
        //Define a private variable to represent AuthDbContext

        public AuthRepository(AuthDbContext dbContext)
        {
        }

        //This methos should be used to Create a new User
        public bool CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        //This methos should be used to check the existence of user
        public bool IsUserExists(string userId)
        {
            throw new NotImplementedException();
        }

        //This methos should be used to Login a user
        public bool LoginUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
