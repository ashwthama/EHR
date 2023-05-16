using EHR.Domain.Context;
using EHR.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.Repo.AppointmentRepo
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private EhrContext _ehrContext;
        public AppointmentRepository(EhrContext ehrContext)
        {
            _ehrContext = ehrContext;
        }
        public string AddAppointment(Appointment appointment)
        {
            _ehrContext.AppointmentDb.Add(appointment);
            _ehrContext.SaveChanges();
            return "Success";
        }
        public Appointment GetAppointmentById(int id)
        {
            return _ehrContext.AppointmentDb.FirstOrDefault(e => e.AppointmentId == id);
        }

    }
}
