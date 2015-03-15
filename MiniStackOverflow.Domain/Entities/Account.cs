using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace MiniStackOverflow.Domain.Entities
{
    public class Account : IEntity
    {
        public Guid Id { get; set; }

        public Account()
        {
            Id = Guid.NewGuid();
        }
        //Atributos
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Confirm { get; set; }

       // public IEnumerable<Question> QuestionEnum { get; set; }

    }
}