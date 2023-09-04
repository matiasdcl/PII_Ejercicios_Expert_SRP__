using System;
using System.Text;

namespace Library
{

    //el codigo cumple considerablemente con principio SRP ya que la unica responsabilidad es la de validar datos y finalmente la cita medica.
    //Sin embargo, se podria asignar a otra clase la responsabilidad de retornar el mensaje con el veredicto final de la cita(si fue validada o no).
    //Por otro lado, la clase  cumple con el patron Expert ya que la clase conoce la informacion para cumplir su funcion de validar datos.

    public class AppointmentService
    {
        public static void CreateAppointment(string name, string id,int age, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName, string doctorSpeciality, string appoinmentId)
        {
            Boolean isValid = true;
            string error;

            if (string.IsNullOrEmpty(name))
            {
                isValid = false;
                error = name;
                appointmentResult.AppoinmentIsValid(isValid,error);
            }

            if (string.IsNullOrEmpty(id))
            {
                isValid = false;
                error = id;
                appointmentResult.AppoinmentIsValid(isValid,error);
            }

            if ((age <= 0))
            {
                isValid = false;
                error = age.ToString();
                appointmentResult.AppoinmentIsValid(isValid,error);
            }
            string StrAge = age.ToString();
            if (string.IsNullOrEmpty(StrAge))
            {
                isValid = false;
                error = StrAge;
                appointmentResult.AppoinmentIsValid(isValid,error);
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                isValid = false;
                error = phoneNumber;
                appointmentResult.AppoinmentIsValid(isValid,error);
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                isValid = false;
                error = appoinmentPlace;
                appointmentResult.AppoinmentIsValid(isValid,error);
            }


            if (string.IsNullOrEmpty(doctorName))
            {
                isValid = false;
                error = doctorName;
                appointmentResult.AppoinmentIsValid(isValid,error);
            }

            if (string.IsNullOrEmpty(doctorSpeciality))
            {
                isValid = false;
                error = doctorSpeciality;
                appointmentResult.AppoinmentIsValid(isValid,error);
            }

            if (string.IsNullOrEmpty(appoinmentId))
            {
                isValid = false;
                error = appoinmentId;
                appointmentResult.AppoinmentIsValid(isValid,error);
            }

            if (isValid)
            {
                appointmentResult.AppoinmentIsValid(isValid, null);
            }

        }

    }
}
