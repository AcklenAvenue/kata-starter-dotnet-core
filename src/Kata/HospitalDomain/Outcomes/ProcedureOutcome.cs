namespace Kata.HospitalDomain.Outcomes
{
    public class ProcedureOutcome
    {
        public string WhatHappened { get; }


        public ProcedureOutcome(string whatHappened)
        {
            WhatHappened = whatHappened;
        }
    }
}