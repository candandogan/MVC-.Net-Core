using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introNetCore.Modals
{
    public static class AcceptedUsers
    {
        public static List<UserResponse> inComingUsers = new List<UserResponse>();

        public static void Add(UserResponse userResponse)
        {
            inComingUsers.Add(userResponse);
        }
    }
}
