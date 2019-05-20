using Kata.HospitalDomain.Outcomes;

namespace Kata.HospitalDomain.Things
{
    internal class EmergencyRoom
    {
        public ProcedureOutcome Diagnose()
        {
            return new ProcedureOutcome($"Diagnosed problems with emergency patient.");
        }
    }
}