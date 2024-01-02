// See https://aka.ms/new-console-template for more information

using System.Reflection;

RomanToInt("III");

short RomanToInt(string typedRoman)
{

    var roman = new
    {
        I = 1,
        V = 5,
        X = 10,
        L = 50,
        C = 100,
        D = 500,
        M = 1000
    };

    char[] romanToNumeric = new char[typedRoman.Length];
    short result = 0;

    for (int i = 0; i < typedRoman.Length; i++)
    {
        romanToNumeric[i] = Convert.ToChar(roman.GetType().GetProperty(typedRoman[i].ToString()).GetValue(roman, null));
    }

    for (int c = 0; c < romanToNumeric.Length - 1; c++)
    {
        if (Convert.ToInt16(romanToNumeric[c]) >= Convert.ToByte(romanToNumeric[c + 1]))
        {
            result += Convert.ToInt16(romanToNumeric[c]);
        }
        else
        {
            result -= Convert.ToInt16(romanToNumeric[c]);
        }
    }

    result += Convert.ToInt16(romanToNumeric[romanToNumeric.Length - 1]);

    return result;
}