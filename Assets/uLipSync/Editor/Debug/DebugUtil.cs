using UnityEngine;
using System.Text;

namespace uLipSync.Debugging
{

public static class DebugUtil
{
    public static void DumpMfccData(StringBuilder sb, MfccData data)
    {
        sb.Append(data.name);
        sb.AppendLine();
        foreach (var mcd in data.mfccCalibrationDataList)
        {
            var array = mcd.array;
            for (int i = 0; i < array.Length; ++i)
            {
                sb.Append(array[i]);
                if (i != array.Length - 1) sb.Append(",");
            }
            sb.AppendLine();
        }
    }

    public static void DumpProfile(StringBuilder sb, Profile profile)
    {
        foreach (var mfccData in profile.mfccs)
        {
            DumpMfccData(sb, mfccData);
            sb.AppendLine();
        }
    }
}

}