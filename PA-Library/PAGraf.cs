//@Author Cristofor Rotsching
using System.Xml.XPath;
namespace PA_Library {
	public readonly ref struct PAGraf
	//public readonly class PAGraf
	//public struct PAGraf
	{
		public void Dispose()
        {
            
        }
		[MarshalAs(UnmanagedType.IDispatch)]
		private PACardinal n { get; }

		[MarshalAs(UnmanagedType.IDispatch)]
		private PACardinal m { get; }

		[MarshalAs(UnmanagedType.IDispatch)]
		private PASir adj { get; }

		[MarshalAs(UnmanagedType.IDispatch)]
		private PANod sursa { get; }
	}
}