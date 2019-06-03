using System;
using System.Collections.Generic;
using Kata.HospitalDomain.Rooms;
using Kata.HospitalDomain.Staff;

namespace Kata.HospitalDomain.Scheduling
{
    public class Appointment
    {
        public IEnumerable<IMedicalStaff> MedicalStaff { get;  }
        public IRoom Room { get;  }
        public DateTime DateTime { get; }
    }
}