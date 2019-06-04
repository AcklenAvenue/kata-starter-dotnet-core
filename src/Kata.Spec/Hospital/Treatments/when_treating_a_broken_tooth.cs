using System.Collections.Generic;
using Kata.HospitalDomain.Outcomes;
using Kata.HospitalDomain.Procedures;
using Machine.Specifications;
using Moq;
using It = Machine.Specifications.It;

namespace Kata.Spec.Hospital.Treatments
{
    public class when_treating_a_broken_tooth
    {
        Establish _context = () => { _systemUnderTest = new HospitalDomain.Hospital(Mock.Of<IProcedureStrategyFactory>()); };

        Because of = () => { _result = _systemUnderTest.TreatIllness("1292"); };

        It should_pull_the_tooth = () => { _result.ShouldHave("Pulled tooth number 20."); };

        It should_give_pain_killer = () => { _result.ShouldHave("Applied local anesthetic to Mouth."); };

        static HospitalDomain.Hospital _systemUnderTest;
        static TreatmentOutcome _result;
    }

    public class when_pulling_a_tooth
    {
        Establish _context = () => { _systemUnderTest = new ToothPullStrategy(); };

        Because of = () =>
        {
            _treatmentOutcome = new TreatmentOutcome();
            _result = _systemUnderTest.DoProcedure();
        };

        It should_pull_the_tooth = () => { _treatmentOutcome.ShouldHave("Pulled tooth number 20."); };

        It should_give_pain_killer = () => { _treatmentOutcome.ShouldHave("Applied local anesthetic to Mouth."); };

        static ToothPullStrategy _systemUnderTest;
        static TreatmentOutcome _treatmentOutcome;
        static IEnumerable<ProcedureOutcome> _result;
    }
}