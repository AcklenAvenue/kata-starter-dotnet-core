using System.Collections.Generic;

namespace Kata.SupplyChain
{
    public class TreatmentSupplier
    {
        IEnumerable<MedicalItem> GetSupplies(string medicalCode, bool isEmergency=false){

            switch (medicalCode)
            {
                case "1010":
                    return new List<MedicalItem>
                    {
                        new Bandage10x10(),
                        new SalineSolution(),
                        new Antibiotic(),
                        new Chainsaw()
                    };
                case "2998":
                    if (isEmergency)
                    {
                        return new List<MedicalItem>
                        {
                            new Bandage10x10(),
                            new Bandage10x10(),
                            new Bandage10x10(),
                            new SalineSolution(),
                            new SalineSolution(),
                            new Antibiotic(),
                            new SteakKnife()
                        };
                    }
                    return new List<MedicalItem>
                    {
                        new Bandage10x10(),
                        new SalineSolution(),
                        new Antibiotic(),
                        new SteakKnife()
                    };
                case "8854":
                    return new List<MedicalItem>
                    {
                        new Bandage10x10(),
                        new Antibiotic(),
                    };
                default:
                    return new List<MedicalItem>();
            }
        }
    }
}