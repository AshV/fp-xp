using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XP_FP_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var wareHouse = new Location(
                "Warehouse",
                new PureList<MedicalItem>(
                    new MedicalItem(Items.Paracetamol, 8),
                    new MedicalItem(Items.Ibuprofen, 45),
                    new MedicalItem(Items.Syringe, 80),
                    new MedicalItem(Items.Scalpel, 90)
               ));
            var icu = new Location(
                "ICU",
                new PureList<MedicalItem>(
                    new MedicalItem(Items.Paracetamol, 0),
                    new MedicalItem(Items.Ibuprofen, 20),
                    new MedicalItem(Items.Syringe, 9),
                    new MedicalItem(Items.Scalpel, 18)
               ));
            var dispensary = new Location(
                "Dispensary",
                new PureList<MedicalItem>(
                    new MedicalItem(Items.Paracetamol, 52),
                    new MedicalItem(Items.Ibuprofen, 38),
                    new MedicalItem(Items.Syringe, 8),
                    new MedicalItem(Items.Scalpel, 80)

               ));

            var transactions = new PureList<Transaction>();


        }
    }
}