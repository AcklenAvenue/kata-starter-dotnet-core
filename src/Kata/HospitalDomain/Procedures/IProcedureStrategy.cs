using System.Collections.Generic;
using Kata.HospitalDomain.Outcomes;

namespace Kata.HospitalDomain.Procedures
{
    public interface IProcedureStrategy
    {
        IEnumerable<ProcedureOutcome> DoProcedure();
        bool CanDoProcedure(string medicalCode, bool isEmergency = false);
    }
}