using System;

namespace ClassLibrary
{
    public class clsStaff
    {

        private Int32 mStaffID;
        private bool mIsAdmin;
        private DateTime mDateCreated;
        private Int32 mSalary;
        private string mStaffEmail;
        private string mStaffName;

        public Int32 StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }

        public string StaffName
        {
            get
            {
                return mStaffName;
            }
            set
            {
                mStaffName = value;
            }
        }
        public bool IsAdmin
        {
            get
            {
                return mIsAdmin;
            }
            set
            {
                mIsAdmin = value;
            }
        }
        public DateTime DateCreated
        {
            get
            {
                return mDateCreated;
            }
            set
            {
                mDateCreated = value;
            }
        }
        public int Salary
        {
            get
            {
                return mSalary;
            }
            set
            {
                mSalary = value;
            }
        }
        public string StaffEmail
        {
            get
            {
                return mStaffEmail;
            }
            set
            {
                mStaffEmail = value;
            }
        }
        public bool Find(int staffID)
        {
            mStaffID = 21;
            mStaffName = "Chris Smith";
            mIsAdmin = true;
            mDateCreated = Convert.ToDateTime("18/02/2013");
            mSalary = 1;
            mStaffEmail = "Tommy@gmail.com";
            return true;
        }

        
    }
}