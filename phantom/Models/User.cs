using System;
using System.ComponentModel.DataAnnotations;
using phantom.Interfaces;

namespace phantom.Models
{
    public class User : IUser
    {
        public Guid ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}