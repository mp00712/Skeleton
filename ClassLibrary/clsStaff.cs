using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public int StaffID { get; internal set; }
        public string StaffName { get; internal set; }
        public bool IsStaff { get; internal set; }
        public DateTime DateCreated { get; internal set; }
        public int Salary { get; internal set; }
        public string StaffEmail { get; internal set; }
    }
}