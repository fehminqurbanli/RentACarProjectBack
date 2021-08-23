using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string BrandAdded="Brand added successfully";
        public static string BrandAddedError = "Brand couldn't be added";
        internal static string BrandDeleted="Brand deleted successfully";
        internal static string CarAddedError="Car couldn't be added";
        internal static string CarListed="Car listed";
        internal static string CarImageAdded="Car added successfully";
        internal static string UserRegistered="Successfully registered";
        internal static string UserNotFound="User not found";
        internal static string PasswordError="Invalid password";
        internal static string SuccessfulLogin="Successfully login";
        internal static string UserAlreadyExists="Already exists";
        internal static string AccessTokenCreated="Token created";
        internal static string AuthorizationDenied="Authorization denied";
        internal static string BrandNameInvalid="Brand name must be at least 2 character";
    }
}
