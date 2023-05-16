using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.Domain.Model
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public string Problem { get; set; }
        public string Department { get; set; }
        public string Doctor { get; set; }
        public string Fee { get; set; }

    }
}
