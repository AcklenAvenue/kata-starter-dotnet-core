using Kata.HospitalDomain.Outcomes;
using Kata.HospitalDomain.Values;

namespace Kata.HospitalDomain.Things
{
    public class PainKiller
    {
        public ProcedureOutcome ApplyLocalAnesthetic(BodyArea bodyArea)
        {
            return new ProcedureOutcome($"Applied local anesthetic to {bodyArea}.");
        }

        public ProcedureOutcome ApplyGeneralAnesthetic()
        {
            return new ProcedureOutcome($"Applied general anesthetic.");
        }
    }
}