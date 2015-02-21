using System;

namespace MiniStackOverflow.Domain.Entities
{
    public class Account : IEntity {
        public Guid Id { get; private set; }

        public Account()
        {
            Id = Guid.NewGuid();
        }
        //Atributos


    }
}