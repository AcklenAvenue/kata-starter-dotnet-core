using System.Collections.Generic;
using FluentAssertions;
using Kata.HospitalDomain.Outcomes;
using Kata.HospitalDomain.Procedures;
using Machine.Specifications;
using Moq;
using It = Machine.Specifications.It;

namespace Kata.Spec.Hospital.Treatments
{
    public class when_treating_an_illness
    {
        const string MedicalCode = "6453";
        const bool IsEmergency = false;

        Establish _context = () =>
        {
            _procedureStrategyFactory = Mock.Of<IProcedureStrategyFactory>();

            _systemUnderTest = new HospitalDomain.Hospital(_procedureStrategyFactory);
            
            _procedureStrategy = Mock.Of<IProcedureStrategy>();
            Mock.Get(_procedureStrategyFactory).Setup(x => x.Create(MedicalCode, IsEmergency))
                .Returns(_procedureStrategy);

            _expectedProdecureOutcome = new ProcedureOutcome("something");
            Mock.Get(_procedureStrategy).Setup(x => x.DoProcedure()).Returns(new List<ProcedureOutcome>{_expectedProdecureOutcome});
        };

        Because of = () => { _result = _systemUnderTest.TreatIllness(MedicalCode); };

        It should_treat_the_illness_appropriately = () =>
        {
            _result.ProcedureOutcomes.Should().Contain(_expectedProdecureOutcome);
        };

        static HospitalDomain.Hospital _systemUnderTest;
        static TreatmentOutcome _result;
        static IProcedureStrategyFactory _procedureStrategyFactory;
        static IProcedureStrategy _procedureStrategy;
        static ProcedureOutcome _expectedProdecureOutcome;
    }
}