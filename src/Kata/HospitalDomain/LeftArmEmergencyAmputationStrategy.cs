using System.Diagnostics.SymbolStore;
using Kata.HospitalDomain.Outcomes;
using Kata.HospitalDomain.Things;
using Kata.HospitalDomain.Values;

namespace Kata.HospitalDomain
{
    public class LeftArmEmergencyAmputationStrategy : IProcedureStrategy
    {
        BoneSaw _boneSaw;
        Injector _injector;
        PainKiller _painKiller;
        EmergencyRoom _emergencyRoom;

        public LeftArmEmergencyAmputationStrategy()
        {
            _boneSaw = new BoneSaw();
            _injector = new Injector();
            _painKiller = new PainKiller();
            _emergencyRoom = new EmergencyRoom();
        }

        public void DoProcedure(TreatmentOutcome outcome)
        {
            outcome.LogProcedure(_emergencyRoom.Diagnose());
            outcome.LogProcedure(_painKiller.ApplyGeneralAnesthetic());
            outcome.LogProcedure(_boneSaw.CutOff(BodyArea.LeftArm));
            outcome.LogProcedure(_injector.Inject(Medicine.Amoxicillin, BodyArea.LeftArm));
        }

        public bool CanDoProcedure(string medicalCode, bool isEmergency = false)
        {
            return isEmergency && medicalCode == "8372";
        }
    }
}