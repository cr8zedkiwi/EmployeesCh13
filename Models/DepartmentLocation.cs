﻿namespace EmployeesCh12.Models
{
    public class DepartmentLocation
    {
        //Composite Primary key and Foreign key for Department
        public int DepartmentID { get; set; }
        //Composite Primary key and Foreign key for Location
        public int LocationID { get; set; }

        //navigation properties
        public Department Department { get; set; } = null!;
        public Location Location { get; set; } = null!;

    }
}
