using System.Linq;
using FluentAssertions;
using Kata.HospitalDomain.Outcomes;
using Machine.Specifications;

namespace Kata.Spec.Hospital
{
    public class when_treating_dead_arm
    {
        Establish _context = () => { _systemUnderTest = new HospitalDomain.Hospital(); };

        Because of = () => { _result = _systemUnderTest.TreatIllness("8372"); };

        It should_put_the_patient_to_sleep = () => { _result.ShouldHave("Applied general anesthetic."); };

        It should_cut_the_patients_arm_off = () => { _result.ShouldHave("Amputated LeftArm."); };

        It should_have_injected_antibiotics = () => { _result.ShouldHave("Injected Amoxicillin into LeftArm."); };

        static HospitalDomain.Hospital _systemUnderTest;
        static TreatmentOutcome _result;
    }
}