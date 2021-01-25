using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWatch.Model
{
    // Interface, used to access the Username and Password properties of all entities that implement it.
    public interface IUser
    {
        string Username { get; set; }
        string Password { get; set; }
        UserType UserType { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    partial class Teacher : IUser
    {
        public string Username { get => username; set => username = value; }
        public string Password { get => password_hash; set => password_hash = value; }
        public UserType UserType { get; set; } = UserType.Teacher;
        public string FirstName { get => teacher_firstN; set => teacher_firstN = value; }
        public string LastName { get => teacher_lastN; set => teacher_lastN = value; }

    }

    partial class Parent : IUser
    {
        public string Username { get => username; set => username = value; }
        public string Password { get => password_hash; set => password_hash = value; }
        public UserType UserType { get; set; } = UserType.Parent;
        public string FirstName { get => parent_firstN; set => parent_firstN = value; }
        public string LastName { get => parent_lastN; set => parent_lastN = value; }
        public string Email { get => email; set => email = value; }
    }

    partial class Admin : IUser
    {
        public string Username { get => admin_username; set => admin_username = value; }
        public string Password { get => admin_password; set => admin_password = value; }
        public UserType UserType { get; set; } = UserType.Admin;
        public string FirstName { get => admin_firstN; set => admin_firstN = value; }
        public string LastName { get => admin_lastN; set => admin_lastN = value; }
    }

    public enum UserType
    {
        Teacher,
        Parent,
        Admin
    }
}
