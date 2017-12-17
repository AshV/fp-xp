using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace XP_FP_Workshop
{
    [Pure]
    public class Location
    {
        public readonly string Name;
        public readonly List<MedicalItems> Stock;
    }
}