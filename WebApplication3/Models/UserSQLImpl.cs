using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Models;
using System.Configuration;
using System.Data.SqlClient;
namespace WebApplication3.Models
{
    public class UserSQLImpl : IUserRepository
    {
        public List<User> GetAllUser()
        {
            List<User> userList = new List<User>();
            string ConnectionStr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = $"Select * from UserDetails";
                connection.Open();
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    User user = new User();
                    user.Name = dr.GetString(0);
                    user.Email = dr.GetString(1);
                    user.Password = dr.GetString(2);
                    userList.Add(user);
                }
            }
            return userList;
        }

        public string Login(User u)
        {
            string password="";
            string ConnectionStr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = $"select trim(Password) from UserDetails where Email='{u.Email}'";
                connection.Open();
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    password = dr.GetString(0);
                }
            } 
            if(password.Length == 0)
            {
                return "Email not registered.";
            }
            else
            {
                if(password == u.Password)
                {
                    return "Successfully Loggedin";
                }
                else
                {
                    return "Incorrect Email or Password";
                }
            }
            
            
        }

        public User Register(User u)
        {
            string ConnectionStr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = $"insert into UserDetails (Name, Email, Password) values ('{u.Name}', '{u.Email}', '{u.Password}')";
                connection.Open();
                SqlDataReader dr = command.ExecuteReader();
            }
            return u;
        }
    }
}