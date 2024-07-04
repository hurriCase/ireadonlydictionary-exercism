using System;
using System.Collections;
using System.Collections.Generic;

public static class ResistorColorDuo
{
    private static readonly IReadOnlyDictionary<string, string> Colors = new Dictionary<string, string>
    {
        {"black", "0"},
        {"brown", "1"},
        {"red", "2"},
        {"orange", "3"},
        {"yellow", "4"},
        {"green", "5"},
        {"blue", "6"},
        {"violet", "7"},
        {"grey", "8"},
        {"white", "9"},
    };
    public static int Value(string[] colors) =>
        Convert.ToInt32(Colors[colors[0]] + Colors[colors[1]]);
}
