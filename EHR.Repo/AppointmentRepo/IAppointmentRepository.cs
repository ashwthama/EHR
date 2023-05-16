using EHR.Domain.Model;

namespace EHR.Repo.AppointmentRepo
{
    public interface IAppointmentRepository
    {
        string AddAppointment(Appointment appointment);
        Appointment GetAppointmentById(int id);
    }
}