using System.Linq;
using FluentAssertions;
using Kata.HospitalDomain;
using Kata.HospitalDomain.Outcomes;
using Machine.Specifications;

namespace Kata.Spec.Hospital
{
    public class when_treating_a_broken_tooth
    {
        Establish _context = () => { _systemUnderTest = new HospitalDomain.Hospital(); };

        Because of = () => { _result = _systemUnderTest.TreatIllness("1292"); };

        It should_pull_the_tooth = () => { _result.ShouldHave("Pulled tooth number 20."); };

        It should_give_pain_killer = () => { _result.ShouldHave("Applied local anesthetic to Mouth."); };

        static HospitalDomain.Hospital _systemUnderTest;
        static TreatmentOutcome _result;
    }

    public class when_deciding_if_tooth_pull_is_right
    {
        Establish _context = () => { _systemUnderTest = new ToothPullStrategy(); };

        Because of = () => { _result = _systemUnderTest.CanDoProcedure("1292", false); };

        It should_be_able_to_do_the_procedure = () => { _result.Should().BeTrue(); };
        
        static ToothPullStrategy _systemUnderTest;
        static bool _result;
    }

    public class when_pulling_a_tooth
    {
        Establish _context = () => { _systemUnderTest = new ToothPullStrategy(); };

        Because of = () =>
        {
            _treatmentOutcome = new TreatmentOutcome();
            _systemUnderTest.DoProcedure(_treatmentOutcome);
        };

        It should_pull_the_tooth = () => { _treatmentOutcome.ShouldHave("Pulled tooth number 20."); };

        It should_give_pain_killer = () => { _treatmentOutcome.ShouldHave("Applied local anesthetic to Mouth."); };

        static ToothPullStrategy _systemUnderTest;
        static TreatmentOutcome _treatmentOutcome;
    }
}