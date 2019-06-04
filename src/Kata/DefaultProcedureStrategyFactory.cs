using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Kata.HospitalDomain.Procedures;

namespace Kata
{
    public class DefaultProcedureStrategyFactory : IProcedureStrategyFactory
    {
        readonly IEnumerable<IProcedureStrategy> _strategies;

        public DefaultProcedureStrategyFactory(IEnumerable<IProcedureStrategy> strategies)
        {
            _strategies = strategies;
        }
        
        public IProcedureStrategy Create(string medicalCode, bool isEmergency)
        {
            return _strategies.First(x => x.CanDoProcedure(medicalCode, isEmergency));
        }
    }
}