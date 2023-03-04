using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KozlovAppV2.ViewModel
{
    class PartialComparer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            return x.Equals(y);
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            return obj.GetHashCode();
        }
    }
}
