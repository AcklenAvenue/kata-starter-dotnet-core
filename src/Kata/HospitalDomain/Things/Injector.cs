using Kata.HospitalDomain.Outcomes;
using Kata.HospitalDomain.Values;

namespace Kata.HospitalDomain.Things
{
    public class Injector
    {
        public ProcedureOutcome Inject(Medicine medicine, BodyArea bodyArea)
        {
            return new ProcedureOutcome($"Injected {medicine.ToString()} into {bodyArea.ToString()}.");
        }
    }
}