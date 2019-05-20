using System.Linq;
using FluentAssertions;
using Kata.HospitalDomain.Outcomes;

namespace Kata.Spec.Hospital
{
    public static class TreatmentOutcomeExtensions
    {
        public static void ShouldHave(this TreatmentOutcome outcome, string text)
        {
            outcome.ProcedureOutcomes.Select(x => x.WhatHappened).Should().Contain(text);
        }
    }
}