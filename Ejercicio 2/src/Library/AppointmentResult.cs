using System;
using System.Text;

namespace Library
{
    //con esta clase se cumpliria completamente el principio SRP ya que las responsabilidades estan divididas
    public class appointmentResult
    {
        
        public static string AppoinmentIsValid(bool result, string error)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            if (result == true)
            {
                stringBuilder.Append("Appoinment scheduled");
            }
            else if(result == false)
            {
                stringBuilder.Append($"Unable to schedule appointment, {error} is required\n");
            }

            return stringBuilder.ToString();
        }

    }

}