using Kata.HospitalDomain.Outcomes;
using Kata.HospitalDomain.Things;
using Kata.HospitalDomain.Values;

namespace Kata.HospitalDomain
{
    public class Hospital
    {
        readonly BoneSaw _boneSaw;
        readonly Injector _injector;
        readonly ToothPuller _toothPuller;
        readonly PainKiller _painKiller;
        readonly EmergencyRoom _emergencyRoom;


        public Hospital()
        {
            _boneSaw = new BoneSaw();
            _injector = new Injector();
            _toothPuller = new ToothPuller();
            _painKiller = new PainKiller();
            _emergencyRoom = new EmergencyRoom();
        }

        public TreatmentOutcome TreatIllness(string medicalCode, bool isEmergency = false)
        {
            var outcome = new TreatmentOutcome();
            switch (medicalCode)
            {
                case "1292":
                    outcome.LogProcedure(_painKiller.ApplyLocalAnesthetic(BodyArea.Mouth));
                    outcome.LogProcedure(_toothPuller.PullTooth(20));
                    break;
                case "8372" when isEmergency:
                    outcome.LogProcedure(_emergencyRoom.Diagnose());
                    outcome.LogProcedure(_painKiller.ApplyGeneralAnesthetic());
                    outcome.LogProcedure(_boneSaw.CutOff(BodyArea.LeftArm));
                    outcome.LogProcedure(_injector.Inject(Medicine.Amoxicillin, BodyArea.LeftArm));
                    break;
                case "8372":
                    outcome.LogProcedure(_painKiller.ApplyGeneralAnesthetic());
                    outcome.LogProcedure(_boneSaw.CutOff(BodyArea.LeftArm));
                    outcome.LogProcedure(_injector.Inject(Medicine.Amoxicillin, BodyArea.LeftArm));
                    break;
                case "7635":
                    outcome.LogProcedure(_painKiller.ApplyGeneralAnesthetic());
                    outcome.LogProcedure(_boneSaw.CutOff(BodyArea.RightLeg));
                    outcome.LogProcedure(_injector.Inject(Medicine.Amoxicillin, BodyArea.RightLeg));
                    break;
            }

            return outcome;
        }
    }
}