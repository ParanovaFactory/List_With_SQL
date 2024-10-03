using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ListWİthSQL
{
    internal class Book_Db
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Courses\C# 25\ListWİthSQL\Bookcase.accdb");

        public List<Book> books()
        {
            List<Book> list = new List<Book>();
            conn.Open();
            OleDbCommand command = new OleDbCommand("select * from TblBooks", conn);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Book book = new Book();
                book.Id = reader.GetInt32(0);
                book.Name = reader.GetString(1);
                book.Author = reader.GetString(2);
                book.Page = reader.GetString(3);
                book.Type = reader.GetString(4);
                book.Publisher = reader.GetString(5);

                list.Add(book);
            }
            conn.Close();
            return list;
        }

        public void bookAdd(Book book)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("insert into TblBooks (name,author,page,type,publisher) values(@p1,@p2,@p3,@p4,@p5)",conn);
            cmd.Parameters.AddWithValue("@p1", book.Name);
            cmd.Parameters.AddWithValue("@p2", book.Author);
            cmd.Parameters.AddWithValue("@p3", book.Page);
            cmd.Parameters.AddWithValue("@p4", book.Type);
            cmd.Parameters.AddWithValue("@p5", book.Publisher);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
