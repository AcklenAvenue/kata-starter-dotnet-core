using FluentAssertions;
using Kata.HospitalDomain.Procedures;
using Machine.Specifications;

namespace Kata.Spec.Hospital.Treatments
{
    public class when_creating_a_procedure_strategy_from_tooth_pull_medical_code
    {
        Establish _context = () =>
        {
            _systemUnderTest = new DefaultProcedureStrategyFactory() as IProcedureStrategyFactory;
        };

        Because of = () => { _result = _systemUnderTest.Create("1292", false); };

        It should_return_the_tooth_pull_strategy = () => { _result.Should().BeOfType<ToothPullStrategy>(); };
        
        static IProcedureStrategyFactory _systemUnderTest;
        static IProcedureStrategy _result;
    }
    
    public class when_creating_a_procedure_strategy_from_left_arm_amputation_medical_code
    {
        Establish _context = () =>
        {
            _systemUnderTest = new DefaultProcedureStrategyFactory() as IProcedureStrategyFactory;
        };

        Because of = () => { _result = _systemUnderTest.Create("8372", false); };

        It should_return_the_left_arm_amputation_strategy = () => { _result.Should().BeOfType<LeftArmAmputationStrategy>(); };
        
        static IProcedureStrategyFactory _systemUnderTest;
        static IProcedureStrategy _result;
    }
    
    
}