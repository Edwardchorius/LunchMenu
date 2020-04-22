using LunchMenu.Application.Interfaces;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace LunchMenu.Application.Services
{
    public  class HashingService : IHashingService
    {
        public string GenerateHash(string text, string saltString)
        {
            var salt = Encoding.ASCII.GetBytes(saltString);

            var hashed = KeyDerivation.Pbkdf2(
                password: text,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA512,
                iterationCount: 10000,
                numBytesRequested: 256);

            var result = Convert.ToBase64String(hashed);

            return result;
        }
        
        public string GenerateHash(string text)
        {
            var salt = Encoding.ASCII.GetBytes("RAZDVATRI");

            var hashed = KeyDerivation.Pbkdf2(
                password: text,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA512,
                iterationCount: 10000,
                numBytesRequested: 256);

            var result = Convert.ToBase64String(hashed);

            return result;
        }

        private byte[] GetRandomSalt()
        {
            var salt = new byte[128 / 8];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            return salt;
        }
    }
}
