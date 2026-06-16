//public class PAData
using PA_Library;
// using System.Transactions;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public struct PAData
{
    [DllImport("pa")]
    static extern PAData PADataPerformConstruct();
    [DllImport("pa")]
    static extern PAData PADataPerformInit(PAData Data, PAResource Resource);
    // DllExport struct PAData PADataPerformCopy(struct PAData);
    // DllExport struct PAData PADataPerformPutResource(struct PAData, PAResource);
    [DllImport("pa")]
    static extern PAData PADataPerformRuin(PAData PA);
    [DllImport("pa")]
    static extern PAData PADataPerformDelete(PAData PA);
    [DllImport("pa")]
    static extern PAData PADataPerformCopy(PAData from, PAData to);
}