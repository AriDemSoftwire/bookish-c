using Bookish.DataAccess;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using System;
using Npgsql;
async Task<IEnumerable<Book>> getAllBooks()
{
    string conn = "Host=localhost;Port=5432;Username=postgres;Password=_oCoqG5q5L;Database=bookishc";
    var connection = new NpgsqlConnection(conn);
    connection.Open();

    var books = await connection.QueryAsync<Book>("select * from bookstable");

    return books;
}


