// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Global
using System.Text;
using SmartFormat;

namespace SmarterFormat;

public static class SmarterFormat
{
    public static void AppendSmartLineWithTab(this StringBuilder builder, string value, int counter, params object[] args)
    {
        if (counter <= 0)
        {
            builder.AppendLine(Smart.Format(value,args));
        }
        else
        {
            builder.AppendLine($"{new string('\t', counter)}{Smart.Format(value,args)}");
        }
    }
    public static void AppendSmartLineWithWhiteSpace(this StringBuilder builder, string value, int counter, params object[] args)
    {
        if (counter <= 0)
        {
            builder.AppendLine(Smart.Format(value,args));
        }
        else
        {
            builder.AppendLine($"{new string(' ', counter)}{Smart.Format(value,args)}");
        }
    }
    public static void AppendSmartWithTab(this StringBuilder builder, string value, int counter, bool tab = true, params object[] args)
    {
        if (counter <= 0)
        {
            builder.Append(Smart.Format(value,args));
        }
        else
        {
            builder.Append($"{new string('\t', counter)}{Smart.Format(value,args)}");
        }
    }
    public static void AppendSmartWithWhiteSpace(this StringBuilder builder, string value, int counter, bool tab = true, params object[] args)
    {
        if (counter <= 0)
        {
            builder.Append(Smart.Format(value,args));
        }
        else
        {
            builder.Append($"{new string(' ', counter)}{Smart.Format(value,args)}");
        }
    }
}