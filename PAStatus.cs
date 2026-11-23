
using System.Runtime.InteropServices;


namespace PA
{
    public readonly partial struct PAStatus
    {
        readonly int Visited { get { return _Visited; } }

        internal readonly int _Visited;

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
        internal static partial PAStatus PAStatusPerformRuin(PAStatus pa);

        [LibraryImport("pa")]
        internal static partial
        PAStatus PAStatusPerformDelete(PAStatus pa);

        [LibraryImport("pa")]
        public static partial int PAStatusOperatorEqual(PAStatus one, PAStatus other);

        [LibraryImport("pa")]
        public static partial int PAStatusOperatorNotEqual(PAStatus one, PAStatus other);

        public static bool operator ==(PAStatus one, PAStatus other) => (PAStatusOperatorEqual(one, other) == PA.PARESULT_SUCCESS ? true : false);
        public static bool operator !=(PAStatus one, PAStatus other) => (PAStatusOperatorNotEqual(one, other) == PA.PARESULT_SUCCESS ? true : false);
    }
}