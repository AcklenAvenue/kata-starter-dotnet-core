using Kata.HospitalDomain.Outcomes;
using Machine.Specifications;
using Moq;
using It = Machine.Specifications.It;

namespace Kata.Spec.Hospital.Treatments
{
    public class when_treating_dead_leg
    {
        Establish _context = () => { _systemUnderTest = new HospitalDomain.Hospital(Mock.Of<IProcedureStrategyFactory>()); };

        Because of = () => { _result = _systemUnderTest.TreatIllness("7635"); };

        It should_put_the_patient_to_sleep = () => { _result.ShouldHave("Applied general anesthetic."); };

        It should_cut_the_patients_leg_off = () => { _result.ShouldHave("Amputated RightLeg."); };

        It should_have_injected_antibiotics = () => { _result.ShouldHave("Injected Amoxicillin into RightLeg."); };
        
        static HospitalDomain.Hospital _systemUnderTest;
        static TreatmentOutcome _result;
    }
}