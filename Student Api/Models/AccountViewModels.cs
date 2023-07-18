using System;
using System.Collections.Generic;

namespace Student_Api.Models
{
    // Models returned by AccountController actions.

    public class ExternalLoginViewModel
    {
        public string Name { get; set; }

        public string Url { get; set; }
        public string state { get; set; }
        public string State { get; internal set; }
    }

    public class ManageInfoViewModel
    {
        public string LocalLoginProvider { get; set; }

        public string Email { get; set; }

        public IEnumerable<UserLoginInfoViewModel> Logins { get; set; }

        public IEnumerable<ExternalLoginViewModel> ExternalLoginProviders { get; set; }
    }

    public class UserInfoViewModel

    {
      /*  public string Fullname { get; set; }*/
        public string RegNO { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string SchoolName { get; set; }
        public string Course { get; set; }
        public int Gender { get; set; }
        public string PhoneNo { get; set; }
        public string CourseName { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }

        public bool HasRegistered { get; set; }

        public string LoginProvider { get; set; }
    }

    public class UserLoginInfoViewModel
    {
        public string LoginProvider { get; set; }

        public string ProviderKey { get; set; }
    }
}
