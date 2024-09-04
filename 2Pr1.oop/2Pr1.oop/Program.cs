
/* Приклад 1    
 * string s = "Dfg + t5 - r7y; asd* s34; rt";
int t = s.IndexOf(";");
int i, k = 0;
for (i = 0; i <= t; i++)
{
    if (char.IsLetter(s[i])) k++;
}
Console.WriteLine(k);
Console.ReadKey();*/

/*  Приклад 2
 *  string s = "АУАУАПАУК";
int i = 0;
do
{
    string ss = s.Substring(i, 2);
    if (ss == "АУ")
    {
        s = s.Insert(i, "О"); i = i + 3;
    }
    else
    {
        i++;
    };
}
while (i < s.Length - 1);
Console.WriteLine(s);
Console.ReadKey();*/


/* Приклад 3
 * string s = "бiологiя алгебра iсторiя географiя геометрiя";
string c = "i";
string[] a;
a = s.Split(' ');
int i;
for (i = 0; i < a.Length; i++)
{
    int t = a[i].IndexOf(c);
    if (t != -1) Console.WriteLine(a[i]);
}
Console.ReadKey();*/

/* Приклад 4
 * string s1 = "бiологiя алгебра iсторiя географiя геометрiя";
string[] a;
a = s1.Split(' ');
Array.Reverse(a);
string s2 = string.Join(" ", a);
Console.WriteLine(s2);
Console.ReadKey();*/


/* 1
 * string s = "Gi$u;u1h;.Hyil.k!j.k;:";
int t = s.LastIndexOf(".");
if (t==-1 || t == s.Length - 1)
{
    Console.WriteLine(0);
    return;
}
int k = 0;
for (int i = t + 1; i < s.Length; i++)
{
    if (char.IsLetterOrDigit(s[i]) || char.IsPunctuation(s[i]) || char.IsSymbol(s[i]))
    {
        k++;
    }
}
Console.WriteLine(k);
Console.ReadKey();*/

/* 2
 * string s = "гбаавггдлгга";
if (string.IsNullOrEmpty(s))
{
    Console.WriteLine(s);
    return;
}
char firstChar = s[0];
string res = s.Replace(firstChar.ToString(), "");
Console.WriteLine(res);
Console.ReadKey();*/

/* 3
 * string s = " I love Kramatorsk!";
string[] a = s.Split(' ');
for (int i = 0; i < a.Length; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine($"{a[i]}: {a[i].Length} букв");
    }
}
Console.ReadKey();*/

string s = "Привiт, мене звуть Тамара";
string[] a = s.Split(' ');
string c = a[0];
a[0] = a[1];
a[1] = c;
string newSentence = string.Join(" ", a);
Console.WriteLine(newSentence);
Console.ReadKey();
