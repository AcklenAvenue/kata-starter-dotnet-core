using Kata.HospitalDomain.Procedures;

namespace Kata
{
    public interface IProcedureStrategyFactory
    {
        IProcedureStrategy Create(string medicalCode, bool isEmergency);
    }
}