using Kata.HospitalDomain.Outcomes;

namespace Kata.HospitalDomain.Things
{
    public class ToothPuller
    {
        public ProcedureOutcome PullTooth(int i)
        {
            return new ProcedureOutcome($"Pulled tooth number {i}.");      
        }
    }
}