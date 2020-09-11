using System;
using System.Collections.Generic;

namespace QuestionFour
{
    public static class AccessControlProvider
    {
        private static Dictionary<string, AccessControl> accessControls;

        static AccessControlProvider()
        {
            Console.WriteLine("Fetching data from external resources and creating access control objects...");

            accessControls = new Dictionary<string, AccessControl>
            {
                { "USER", new AccessControl(Access.DoWork, "USER") },
                { "MANAGER", new AccessControl(Access.GenerateAndReadReports, "MANAGER") },
                { "ADMIN", new AccessControl(Access.AddAndRemoveUsers, "ADMIN") }
            };
        }

        public static AccessControl GetAccessControlObject(string controlLevel) {
            return accessControls[controlLevel].Clone();
        }
    }
}