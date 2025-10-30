using Microsoft.VisualBasic;

namespace Ialsindex;

class Program
{
    static void Main(string[] args)
    {
        string[] japanseWords = new string[10]
        {
            "こんにちは – 今日は",          // Konnichiwa – Hello
            "ありがとう – 有難う",          // Arigatou – Thank you
            "さようなら – 左様なら",        // Sayounara – Goodbye
            "すみません – 済みません",       // Sumimasen – Excuse me / Sorry
            "はい – はい",                 // Hai – Yes
            "いいえ – いいえ",              // Iie – No
            "水 – 水",                     // Mizu – Water
            "火 – 火",                     // Hi – Fire
            "山 – 山",                     // Yama – Mountain
            "川 – 川"                      // Kawa – River
        };
        int i = 0;
        Console.WriteLine($"{i}: {japanseWords[i]}"); //
        i ++;
        Console.WriteLine($"{i}: {japanseWords[i]}"); //
        i ++;
        Console.WriteLine($"{i}: {japanseWords[i]}"); //
        i ++;
        Console.WriteLine($"{i}: {japanseWords[i]}");
        i ++;
        Console.WriteLine($"{i}: {japanseWords[i]}");
        i ++;
        Console.WriteLine($"{i}: {japanseWords[i]}"); //
        i ++;
        Console.WriteLine($"{i}: {japanseWords[i]}");
        i ++;
        Console.WriteLine($"{i}: {japanseWords[i]}");
        i ++;
        Console.WriteLine($"{i}: {japanseWords[i]}"); //
        i ++;
        Console.WriteLine($"{i}: {japanseWords[i]}");
    }
}
