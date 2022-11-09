using System.Globalization;


Console.WriteLine("-------Split/Join------");

string item = "1,2,3,4,5";
string[] arr = item.Split(',', StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine(string.Join(" - ", arr));

Console.WriteLine("-------DateTime------");

DateTime date1 = DateTime.Now;
DateTime date2 = DateTime.UtcNow;

TimeSpan interval = date2 - date1;
Console.WriteLine(interval);

Console.WriteLine("-------DateTimeOffset------");

DateTimeOffset dateTimeOffsetNow = DateTimeOffset.Now;
DateTimeOffset dateTimeOffsetUtcNow = DateTimeOffset.UtcNow;

TimeSpan intervalOffset = dateTimeOffsetNow - dateTimeOffsetUtcNow;
Console.WriteLine(intervalOffset);

Console.WriteLine("-------TimeZoneInfo------");

TimeZoneInfo info1 = TimeZoneInfo.Local;
DateTime info2 = TimeZoneInfo.ConvertTimeToUtc(date1);

Console.WriteLine(info1);
Console.WriteLine(info2);

Console.WriteLine("-------CultureInfo------");

CultureInfo cultureInfo = new CultureInfo("bg-BG");

List<string> list = new List<string>();
list.Add(cultureInfo.ToString());
list.Add(cultureInfo.DisplayName);
list.Add(cultureInfo.IsNeutralCulture.ToString());
list.Add(cultureInfo.Parent.ToString());
list.Add(cultureInfo.Parent.ToString());
list.Add(cultureInfo.ThreeLetterISOLanguageName.ToString());
list.Add(cultureInfo.NativeName.ToString());



Console.WriteLine(string.Join("\n",list));