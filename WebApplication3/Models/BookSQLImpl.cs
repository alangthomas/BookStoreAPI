using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace WebApplication3.Models
{
    public class BookSQLImpl : IBookRepository
    {
        public Book AddBook(Book b)
        {
            string ConnectionStr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = $"insert into Books (Id, Title, Author, Price, Description) values ({b.Id}, '{b.Title}', '{b.Author}', {b.Price}, '{b.Description}')";
                connection.Open();
                SqlDataReader dr = command.ExecuteReader();
            }
            return b;
        }

        public List<Book> BestSeller()
        {
            throw new NotImplementedException();
        }

        public Book DeleteBook(int id)
        {
            Book book = new Book();
            string ConnectionStr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = $"delete from Books where Id = '{id}'";
                connection.Open();
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    book.Id = dr.GetInt32(0);
                    book.Title = dr.GetString(1);
                    book.Author = dr.GetString(2);
                    book.Price = dr.GetInt32(3);
                    book.Description = dr.GetString(4);
                }
            }
            return book;
        }
        
        public List<Book> GetAllBooks()
        {
            List <Book> bookList = new List<Book>();
            string ConnectionStr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            using(SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = $"Select * from Books order by Id";
                connection.Open();
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    Book book = new Book();
                    book.Id = dr.GetInt32(0);
                    book.Title = dr.GetString(1);
                    book.Author = dr.GetString(2);
                    book.Price = dr.GetInt32(3);
                    book.Description = dr.GetString(4);
                    bookList.Add(book);
                }
            }
            return bookList;
        }

        public List<Book> GetBookByCatId(int id)
        {
            throw new NotImplementedException();
        }

        public Book GetBookById(int id)
        {
            Book book = new Book();
            string ConnectionStr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = $"Select * from Books where Id = '{id}'";
                connection.Open();
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    book.Id = dr.GetInt32(0);
                    book.Title = dr.GetString(1);
                    book.Author = dr.GetString(2);
                    book.Price = dr.GetInt32(3);
                    book.Description = dr.GetString(4);
                }
            }
            return book;
        }

        public Book UpdateBook(int id, Book b)
        {
            string connectionStr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = $"update Books set Title='{b.Title}', Author='{b.Author}', Price={b.Price}, Description='{b.Description}'  where Id='{id}'";
                connection.Open();
                SqlDataReader dr = command.ExecuteReader();
                return b;
            }
        }
    }
}