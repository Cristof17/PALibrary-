using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using PA;

namespace PA
{
    public readonly partial struct PAStatus
    {
        public readonly int Visited
        {
            get
            {
                return _visited;   
            }
        }

        internal readonly int _visited;

        [LibraryImport("pa")]
        internal static partial 
        PAStatus PAStatusPerformConstruct();

        [LibraryImport("pa")]
        internal static partial 
        PAStatus PAStatusPerformInit(PAStatus status, int visited);

        [LibraryImport("pa")]
        internal static partial 
        PAStatus PAStatusPerformCopy(PAStatus from, PAStatus to);

        [LibraryImport("pa")]
        internal static partial 
        PAStatus PAStatusPerformRuin(PAStatus pa);

        [LibraryImport("pa")]
        internal static partial 
        PAStatus PAStatusPerformDelete(PAStatus pa);

        public static bool operator==(PAStatus one, PAStatus other) => one._visited == other._visited;
        public static bool operator!=(PAStatus one, PAStatus other) => one._visited != other._visited;

        public override bool Equals([NotNullWhen(true)] object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}