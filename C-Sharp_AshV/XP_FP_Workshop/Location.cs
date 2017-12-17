using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace XP_FP_Workshop
{
    [Pure]
    public class Location
    {
        public readonly string Name;
        public readonly PureList<MedicalItem> Stock;

        public Location(string Name, PureList<MedicalItem> Stock)
        {
            this.Name = Name;
            this.Stock = Stock;
        }
    }
}