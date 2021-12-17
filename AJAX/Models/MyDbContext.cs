using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AJAX.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public MyDbContext(): base("conn")
        {

        }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}