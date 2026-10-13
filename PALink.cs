using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using PA;

namespace PA
{
	public readonly partial struct PALink
	{
		readonly PAPair Pair;

		[LibraryImport("pa")]
		public static partial PALink PALinkPerformConstruct();
		[LibraryImport("pa")]
		public static partial PALink PALinkPerformInit(PALink link, PAPair pair);
		[LibraryImport("pa")]
		public static partial PALink PALinkPerformCopy(PALink from, PALink to);
		[LibraryImport("pa")]
		public static partial PALink PALinkPerformRuin(PALink pa);
		[LibraryImport("pa")]
		public static partial PALink PALinkPerformDelete(PALink pa);

		[LibraryImport("pa")]
		public static partial int PALinkOperatorEqual(PALink one, PALink other);

		[LibraryImport("pa")]
		public static partial int PALinkOperatorNotEqual(PALink onem, PALink other);


		public static bool operator ==(PALink one, PALink other) => (PALinkOperatorEqual(one, other) == PA.PARESULT_SUCCESS) ? true : false ;
		public static bool operator !=(PALink one, PALink other) => (PALinkOperatorNotEqual(one,other) == PA.PARESULT_SUCCESS) ? true : false;

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