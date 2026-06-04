//public class PAData
using PA_Library;
using System.Transactions;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public struct PAData
{
    PAData PADataPerformConstruct();

    PAData PADataPerformInit(PAData Data, PAResource Resource);
// DllExport struct PAData PADataPerformCopy(struct PAData);
// DllExport struct PAData PADataPerformPutResource(struct PAData, PAResource);
    // [DllImport("palibrary")]
    PAData PADataPerformRuin(PAData);
    // [DllImport("palibrary")] 
    PAData PADataPerformDelete(PAData);
    // [DllImport("palibrary")]
    PAData PADataPerformCopy(PAData from, PAData to);
//typedef struct PAData Data;

    // private PAResource Resource;
    // [DllImport("palibrary")]
    // public static extern PAData PADataConstruct(int Resource);
    // [DllImport("palibrary")]
    // public static extern int PADataRuin(int Resource);
    // [DllImport("palibrary")]
    // public static extern PAData PADataInit(PAData Data);
    // [DllImport("palibrary")]
    // public static extern int PADataDelete(PAData PA);
    //struct PAResource
    // [StructLayout(LayoutKind.Sequential)]
    // private struct PAData data {get;}

    // public int value;//todo use in unsafe contexts

    // public static implicit operator byte(PAData d) => (byte)d.value;
    // public static explicit operator PAData(byte b) => Copy(b);
    // public static implicit operator int(PAData d) => (int)d.value;
    // public static explicit operator PAData(int i) => Copy(i);
    // public static implicit operator long(PAData d) => (long)d.value;
    // public static explicit operator PAData(long l) => Copy(l);
    // public static implicit operator short(PAData d) => (short)d.value;
    // public static explicit operator PAData(short s) => Copy(s);
    // public static implicit operator ushort(PAData d) => (ushort)d.value;
    // public static explicit operator PAData(ushort us) => Copy(us);
    // public static implicit operator ulong(PAData d) => (ulong)d.value;
    // public static explicit operator PAData(ulong ul) => Copy(ul);

    //public static void init(PANod nod, int value)
    // public static PAData Copy(int value)
    // {
    //     PAData copy = new PAData();
    //     copy.value = value;
    //     return copy;

    // }
    // public static PAData Copy(byte value)
    // {
    //     PAData copy = new PAData();
    //     copy.value = value;
    //     return copy;

    // }
    // public static PAData Copy(long value)
    // {
    //     PAData copy = new PAData();
    //     copy.value = (int) value;
    //     return copy;

    // }
    // public static PAData Copy(short value)
    // {
    //     PAData copy = new PAData();
    //     copy.value = value;
    //     return copy;

    // }
    // public static PAData Copy(ulong value)
    // {
    //     PAData copy = new PAData();
    //     copy.value = (int)(uint) value;
    //     return copy;

    // }
    // public static PAData Copy(ushort value)
    // {
    //     PAData copy = new PAData();
    //     copy.value = (int)(uint)value;
    //     return copy;

    // }
    // public PANod toPANod()
    // {
    //     PAData data = new PAData();
    //     data.value = value;
    //     PANod nod = new PANod(data);
    //     return nod;
    //     //nod = new PANod(data, nod);
    //     //return new PANod(data
    //     //,);
    // }
    //public static PAData Clone()
    //{
    //}
}