using System.Collections.Generic;
using Kata.HospitalDomain.Outcomes;
using Kata.HospitalDomain.Things;
using Kata.HospitalDomain.Values;

namespace Kata.HospitalDomain.Procedures
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

        public IEnumerable<ProcedureOutcome> DoProcedure()
        {
            return new List<ProcedureOutcome>
            {
                _emergencyRoom.Diagnose(),
                _painKiller.ApplyGeneralAnesthetic(),
                _boneSaw.CutOff(BodyArea.LeftArm),
                _injector.Inject(Medicine.Amoxicillin, BodyArea.LeftArm)
            };
        }

        public bool CanDoProcedure(string medicalCode, bool isEmergency = false)
        {
            return isEmergency && medicalCode == "8372";
        }
    }
}