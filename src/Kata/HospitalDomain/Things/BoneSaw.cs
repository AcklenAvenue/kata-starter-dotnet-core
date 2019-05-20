using Kata.HospitalDomain.Outcomes;
using Kata.HospitalDomain.Values;

namespace Kata.HospitalDomain.Things
{
    public class BoneSaw
    {
        public ProcedureOutcome CutOff(BodyArea leftArm)
        {
            return new ProcedureOutcome($"Amputated {leftArm}.");
        }
    }
}