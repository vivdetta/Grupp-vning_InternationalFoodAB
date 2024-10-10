using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace Gruppövning_InternationalFoodAB.Classes
{

    public static class LoginAuthenticator
    {
        public static bool CheckForAdmin(Admin adminTrying)
        {
            string jsonAdminUserFilePath = FileDirectory.GetJsonAdminFilePath();
            var json = File.ReadAllText(jsonAdminUserFilePath);
            var adminInfo = JsonSerializer.Deserialize<List<Admin>>(json);

            if (adminInfo == null)
            {
                // If there are no admins in the file, return false
                return false;
            }

            return adminInfo
                .Any(admin => admin.UserName == adminTrying.UserName // Ensure property name matches
                && admin.Password == adminTrying.Password);
        }
    }
}
