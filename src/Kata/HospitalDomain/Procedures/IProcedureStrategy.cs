using Kata.HospitalDomain.Outcomes;

namespace Kata.HospitalDomain.Procedures
{
    public interface IProcedureStrategy
    {
        void DoProcedure(TreatmentOutcome outcome);
        bool CanDoProcedure(string medicalCode, bool isEmergency = false);
    }
}