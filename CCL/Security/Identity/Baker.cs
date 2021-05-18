using System;
using System.Collections.Generic;
using System.Text;

namespace OSBB.Security.Identity
{
    public class Baker
        : Client
    {
        public Baker(int userId, string name, int catalogId) 
            : base(userId, name, catalogId, nameof(Baker))
        {
        }
    }
}
