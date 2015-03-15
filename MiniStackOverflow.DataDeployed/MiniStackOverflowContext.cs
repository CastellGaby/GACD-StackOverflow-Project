using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniStackOverflow.Domain.Entities;
using System.Configuration;

namespace MiniStackOverflow.DataDeployed
{
    public class MiniStackOverflowContext:DbContext
    {
        public MiniStackOverflowContext() : base(ConnectionString.Get())
        {
            
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Question> Questions { get; set; }
    }

    public static class ConnectionString
    {
        public static string Get()
        {
            var environment = ConfigurationManager.AppSettings["Environment"];
            return String.Format("name={0}", environment);
        }
    }
}
