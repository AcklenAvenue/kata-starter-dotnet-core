using FluentAssertions;
using Kata.HospitalDomain.Procedures;
using Machine.Specifications;

namespace Kata.Spec.Hospital
{
    public class when_deciding_if_tooth_pull_is_right
    {
        Establish _context = () => { _systemUnderTest = new ToothPullStrategy(); };

        Because of = () => { _result = _systemUnderTest.CanDoProcedure("1292", false); };

        It should_be_able_to_do_the_procedure = () => { _result.Should().BeTrue(); };
        
        static ToothPullStrategy _systemUnderTest;
        static bool _result;
    }
}