using EHR.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.Domain.Context
{
        public class EhrContext : DbContext
        {
            public EhrContext(DbContextOptions options) : base(options) { }
            public DbSet<User> Usertable { get; set; }
            public DbSet<Appointment> AppointmentDb { get; set; }
    }
}
