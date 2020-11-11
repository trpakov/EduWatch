using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWatch.Model
{
    // Inteface, used to access the Username and Password properties of all entities that implement it.
    public interface User
    {
        string Username { get; set; }
        string Password { get; set; }
        UserType UserType { get; set; }
    }

    partial class Teacher : User
    {
        public string Username { get => username; set => username = value; }
        public string Password { get => password_hash; set => password_hash = value; }
        public UserType UserType { get; set; } = UserType.Teacher;
    }

    partial class Parent : User
    {
        public string Username { get => username; set => username = value; }
        public string Password { get => password_hash; set => password_hash = value; }
        public UserType UserType { get; set; } = UserType.Parent;
    }

    partial class Admin : User
    {
        public string Username { get => admin_username; set => admin_username = value; }
        public string Password { get => admin_password; set => admin_password = value; }
        public UserType UserType { get; set; } = UserType.Admin;
    }

    public enum UserType
    {
        Teacher,
        Parent,
        Admin
    }
}
