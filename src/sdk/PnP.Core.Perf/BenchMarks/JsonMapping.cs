﻿using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnP.Core.Perf.BenchMarks
{
    /// <summary>
    /// Resoureces:
    /// https://github.com/ServiceStack/ServiceStack.Text/blob/master/src/ServiceStack.Text/StringSpanExtensions.cs
    /// </summary>
    [MemoryDiagnoser]
    public class JsonMapping
    {
        #region works
        /*
        |        Method |     Mean |    Error |   StdDev | Ratio |  Gen 0 | Allocated |
        |-------------- |---------:|---------:|---------:|------:|-------:|----------:|
        |     CamelCase | 25.28 ns | 0.162 ns | 0.151 ns |  1.00 | 0.0191 |     120 B |
        | CamelCaseSpan | 17.94 ns | 0.204 ns | 0.181 ns |  0.71 | 0.0166 |     104 B |
        */
        //[Benchmark(Baseline = true)]
        //public string CamelCase()
        //{
        //    string str = "ThisIsAString";
        //    if (!string.IsNullOrEmpty(str) && str.Length > 1)
        //    {
        //        return char.ToLowerInvariant(str[0]) + str.Substring(1);
        //    }
        //    return str;
        //}

        //[Benchmark]
        //public string CamelCaseSpan()
        //{
        //    Span<char> toCamelCase = "ThisIsAString".ToCharArray();
        //    if (toCamelCase.Length > 1)
        //    {
        //        toCamelCase[0] = char.ToLowerInvariant(toCamelCase[0]);
        //    }

        //    return toCamelCase.ToString();
        //}

        /*
        |    Method |      Mean |    Error |   StdDev | Ratio |  Gen 0 | Allocated |
        |---------- |----------:|---------:|---------:|------:|-------:|----------:|
        |     Split | 198.87 ns | 2.051 ns | 1.918 ns |  1.00 | 0.0548 |     344 B |
        | SplitSpan |  82.65 ns | 0.518 ns | 0.484 ns |  0.42 |      - |         - |
        */
        //[Benchmark(Baseline = true)]
        //public Guid Split()
        //{
        //    string idFieldValue = "bertonline.sharepoint.com,cf1ed1cb-4a3c-43ed-bb3f-4ced4ce69ecf,1de385e4-e441-4448-8443-77680dfd845e";
        //    if (!string.IsNullOrEmpty(idFieldValue))
        //    {
        //        string id = idFieldValue.Split(new char[] { ',' })[2];

        //        return Guid.Parse(id);
        //    }

        //    return Guid.Empty;
        //}

        //[Benchmark]
        //public Guid SplitSpan()
        //{
        //    ReadOnlySpan<char> idFieldValue = "bertonline.sharepoint.com,cf1ed1cb-4a3c-43ed-bb3f-4ced4ce69ecf,1de385e4-e441-4448-8443-77680dfd845e";
        //    if (!idFieldValue.IsNullOrEmpty())
        //    {
        //        var id = idFieldValue.LastRightPart(',');
        //        return Guid.Parse(id);
        //    }
        //    return Guid.Empty;
        //}

        #endregion

    }
}
