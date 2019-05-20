using System.Collections.Generic;

namespace Kata.HospitalDomain.Outcomes
{
    public class TreatmentOutcome
    {
        public TreatmentOutcome()
        {
            ProcedureOutcomes = new List<ProcedureOutcome>();
        }

        public void LogProcedure(ProcedureOutcome procedureOutcome)
        {
            ProcedureOutcomes.Add(procedureOutcome);
        }

        public IList<ProcedureOutcome> ProcedureOutcomes { get; }
    }
}