using System;
static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
    return DateTime.Parse(appointmentDateDescription);
    }
    public static bool HasPassed(DateTime appointmentDate)
    {
        //throw new NotImplementedException("Please implement the (static) Appointment.HasPassed() method");
        if(DateTime.Now > appointmentDate) {
            return true;
        }
        else {
            return false;
        }
        
    }
    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        if(appointmentDate.Hour >= 12 && appointmentDate.Hour < 18) {
            return true;
        }
        else {
            return false;
        }
    }
    public static string Description(DateTime appointmentDate)
    {
        return $"You have an appointment on {appointmentDate.ToString()}.";
    }
    public static DateTime AnniversaryDate()
    {
        return new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
    }
}
