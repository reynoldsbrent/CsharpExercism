using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        //throw new NotImplementedException("Please implement the (static) Badge.Print() method");

        if(department == null && id == null){
            return $"{name} - OWNER";
        }
        else if(department == null && id != null){
            return $"[{id}] - {name} - OWNER";
        }
        else if(id != null) {
            return $"[{id}] - {name} - {department.ToUpper()}";
        }
        else {
            return $"{name} - {department.ToUpper()}";
        }
    }
}
