using System.Linq;
using FluentAssertions;
using Kata.HospitalDomain.Outcomes;
using Machine.Specifications;

namespace Kata.Spec.Hospital
{
    public class when_treating_a_broken_tooth
    {
        Establish _context = () => { _systemUnderTest = new HospitalDomain.Hospital(); };

        Because of = () => { _result = _systemUnderTest.TreatIllness("1292"); };

        It should_pull_the_tooth = () =>
        {
            _result.ShouldHave("Pulled tooth number 20.");
        };

        It should_give_pain_killer = () =>
        {
            _result.ShouldHave("Applied local anesthetic to Mouth.");
        };

        static HospitalDomain.Hospital _systemUnderTest;
        static TreatmentOutcome _result;
    }
}