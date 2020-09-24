using ComplexFirebaseRequest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplexFirebaseRequest.Data
{
    public class DbInitializer
    {

        public static void Initialize(DatabaseContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
                new User{Uid = Guid.NewGuid().ToString(), Domain = 1, Role = 0 },
                new User{Uid = Guid.NewGuid().ToString(), Domain = 1, Role = 1 },
                new User{Uid = Guid.NewGuid().ToString(), Domain = 1, Role = 2 },
                new User{Uid = Guid.NewGuid().ToString(), Domain = 2, Role = 0 },
                new User{Uid = Guid.NewGuid().ToString(), Domain = 2, Role = 1 },
                new User{Uid = Guid.NewGuid().ToString(), Domain = 2, Role = 1 },
                new User{Uid = Guid.NewGuid().ToString(), Domain = 2, Role = 1 },
                new User{Uid = Guid.NewGuid().ToString(), Domain = 2, Role = 2 },
                new User{Uid = Guid.NewGuid().ToString(), Domain = 2, Role = 2 },
                new User{Uid = Guid.NewGuid().ToString(), Domain = 3, Role = 0 },
                new User{Uid = Guid.NewGuid().ToString(), Domain = 3, Role = 1 },
                new User{Uid = Guid.NewGuid().ToString(), Domain = 3, Role = 1 },
                new User{Uid = Guid.NewGuid().ToString(), Domain = 3, Role = 1 },
            };

            context.Users.AddRange(users);
            context.SaveChanges();
        }


    }
}
