using Kata.HospitalDomain.Outcomes;

namespace Kata.HospitalDomain.Things
{
    public class ToothPuller
    {
        public ProcedureOutcome PullTooth(int i)
        {    
            // Different tools for different teeth
            
            return new ProcedureOutcome($"Pulled tooth number {i}.");      
        }
    }
}