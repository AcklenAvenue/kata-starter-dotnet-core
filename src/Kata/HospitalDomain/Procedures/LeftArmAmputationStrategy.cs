using System.Collections;
using System.Collections.Generic;
using Kata.HospitalDomain.Outcomes;
using Kata.HospitalDomain.Things;
using Kata.HospitalDomain.Values;

namespace Kata.HospitalDomain.Procedures
{
    public class LeftArmAmputationStrategy : IProcedureStrategy
    {
        BoneSaw _boneSaw;
        Injector _injector;
        PainKiller _painKiller;
        
        public LeftArmAmputationStrategy()
        {
            _boneSaw = new BoneSaw();
            _injector = new Injector();
            _painKiller = new PainKiller();
        }

        public IEnumerable<ProcedureOutcome> DoProcedure()
        {
            return new List<ProcedureOutcome>
            {
                _painKiller.ApplyGeneralAnesthetic(),
                _boneSaw.CutOff(BodyArea.LeftArm),
                _injector.Inject(Medicine.Amoxicillin, BodyArea.LeftArm)
            };
        }

        public bool CanDoProcedure(string medicalCode, bool isEmergency = false)
        {
            return !isEmergency && medicalCode == "8372";
        }
    }
}