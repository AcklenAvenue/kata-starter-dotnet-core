using System;
using System.Collections.Generic;
using System.Linq;
using Kata.HospitalDomain.Outcomes;
using Kata.HospitalDomain.Procedures;
using Kata.HospitalDomain.Scheduling;

namespace Kata.HospitalDomain
{
    public class Hospital
    {
        readonly IProcedureStrategyFactory _procedureStrategyFactory;
        
        public Hospital(IProcedureStrategyFactory procedureStrategyFactory)
        {
            _procedureStrategyFactory = procedureStrategyFactory;
        }

        public TreatmentOutcome TreatIllness(string medicalCode, bool isEmergency = false)
        {
            var outcome = new TreatmentOutcome();

            var strategy = _procedureStrategyFactory.Create(medicalCode, isEmergency);
            foreach (var procedureOutcome in strategy.DoProcedure())
            {
                outcome.LogProcedure(procedureOutcome);
            }
            
            return outcome;
        }

        public Appointment ScheduleProcedure(string medicalCode)
        {
            //how will we create this appointment?
            
            return new Appointment();
        }
    }
}