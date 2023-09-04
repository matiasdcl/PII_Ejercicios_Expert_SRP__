using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            AppointmentService.CreateAppointment("Steven Jhonson", "986782342", 46, "5555-555-555", DateTime.Now, "Wall Street", "Armand", "Dermatologyst", "1234");
            AppointmentService.CreateAppointment("Ralf Manson", "", 22, "5555-555-555", DateTime.Now, "Queen Street", "", "Dermatologist", "4321");
        }
    }
}
