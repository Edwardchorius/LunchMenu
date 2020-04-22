using System;
using System.Collections.Generic;
using System.Text;

namespace LunchMenu.Application.Interfaces
{
    public interface IHashingService
    {
        string GenerateHash(string text, string saltString);
        string GenerateHash(string text);
    }
}
