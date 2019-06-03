using System;
using System.Collections.Generic;
using FluentAssertions;
using Kata.HospitalDomain;
using Kata.HospitalDomain.Rooms;
using Kata.HospitalDomain.Scheduling;
using Kata.HospitalDomain.Staff;
using Machine.Specifications;

namespace Kata.Spec.Hospital.Scheduling
{
    public class when_scheduling_an_appointment_for_a_yearly_checkup
    {
        Establish _context = () => { _systemUnderTest = new HospitalDomain.Hospital(); };

        Because of = () => { _result = _systemUnderTest.ScheduleProcedure("7456"); };

        It should_have_a_nurse = () => _result.MedicalStaff.Should().ContainItemsAssignableTo<Nurse>();
        
        It should_have_a_room = () => _result.Room.Should().BeOfType<ExaminationRoom>();

        It should_have_a_doctor = () => _result.MedicalStaff.Should().ContainItemsAssignableTo<Doctor>();

        It should_have_a_date_and_time = () => _result.DateTime.Should().BeAfter(DateTime.Today);
        
        static HospitalDomain.Hospital _systemUnderTest;
        static Appointment _result;
    }
}