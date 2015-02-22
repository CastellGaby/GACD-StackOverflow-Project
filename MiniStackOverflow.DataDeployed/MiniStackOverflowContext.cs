using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniStackOverflow.Domain.Entities;

namespace MiniStackOverflow.DataDeployed
{
    public class MiniStackOverflowContext:DbContext
    {
        public DbSet<Account> Accounts { get; set; }
    }
}
