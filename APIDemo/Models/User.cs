using System;

namespace APIDemo.Models
{
    public class User
    {
        public UserData Data { get; set; }
        public UserSupport Support { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
