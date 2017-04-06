using System;
using Dapper;
using ServiceStack.OrmLite;
using MySql.Data.MySqlClient;
namespace dapper_2
{
    [ServiceStack.DataAnnotations.AliasAttribute("people")]
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
