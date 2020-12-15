using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppClient.Models;

namespace WebAppClient.Data
{
    public class WebAppClientContext : DbContext
    {
        public WebAppClientContext (DbContextOptions<WebAppClientContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppClient.Models.Accounts> Accounts { get; set; }
    }
}
