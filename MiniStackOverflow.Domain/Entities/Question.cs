using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStackOverflow.Domain.Entities
{
    public class Question:IEntity
    {
        public Guid Id{ get; set;}
        public Question()
        {
            Id = Guid.NewGuid();
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public Account OwnerUsername { get; set; }
        public DateTime CreationDate { get; set; }
        public int Votes { get; set; }
    }
}
