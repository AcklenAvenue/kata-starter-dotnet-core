using Kata.HospitalDomain.Outcomes;
using Kata.HospitalDomain.Things;
using Kata.HospitalDomain.Values;

namespace Kata.HospitalDomain.Procedures
{
    public class RightLegAmputationStrategy : IProcedureStrategy
    {
        BoneSaw _boneSaw;
        PainKiller _painKiller;
        Injector _injector;

        public RightLegAmputationStrategy()
        {
            _boneSaw = new BoneSaw();
            _injector = new Injector();
            _painKiller = new PainKiller();

        }
        public void DoProcedure(TreatmentOutcome outcome)
        {
            outcome.LogProcedure(_painKiller.ApplyGeneralAnesthetic());
            outcome.LogProcedure(_boneSaw.CutOff(BodyArea.RightLeg));
            outcome.LogProcedure(_injector.Inject(Medicine.Amoxicillin, BodyArea.RightLeg));
        }

        public bool CanDoProcedure(string medicalCode, bool isEmergency = false)
        {
            return medicalCode == "7635";
        }
    }
}