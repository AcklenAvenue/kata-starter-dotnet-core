using System.Collections.Generic;
using Kata.HospitalDomain.Outcomes;
using Kata.HospitalDomain.Things;
using Kata.HospitalDomain.Values;

namespace Kata.HospitalDomain.Procedures
{
    public class ToothPullStrategy : IProcedureStrategy
    {
        PainKiller _painKiller;
        ToothPuller _toothPuller;

        public ToothPullStrategy()
        {
            _toothPuller = new ToothPuller();
            _painKiller = new PainKiller();

        }
        public IEnumerable<ProcedureOutcome> DoProcedure()
        {
            return new List<ProcedureOutcome>
            {
                _painKiller.ApplyLocalAnesthetic(BodyArea.Mouth),
                _toothPuller.PullTooth(20)
            };
        }

        public bool CanDoProcedure(string medicalCode, bool isEmergency = false)
        {
            return !isEmergency && medicalCode == "1292";
        }
    }
}