using Kata.HospitalDomain.Outcomes;

namespace Kata.HospitalDomain
{
    public interface IProcedureStrategy
    {
        void DoProcedure(TreatmentOutcome outcome);
        bool CanDoProcedure(string medicalCode, bool isEmergency = false);
    }
}