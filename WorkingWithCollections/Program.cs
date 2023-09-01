using System.Diagnostics;
using static System.Console;

static void Output(string title, IEnumerable<string> collections)
{
    WriteLine(title);
    foreach(string item in collections)
    {
        WriteLine($"    {item}");
    }
}

static void WorkingWithLists()
{
    //리스트 3개 추가
    List<string> cities = new();
    cities.Add("London");
    cities.Add("Paris");
    cities.Add("Milan");

    //다른방법
    List<string> cities2 = new() { "London", "Pairs", "Milan" };

    List<string> cities3 = new();
    cities3.AddRange(new[] {"London", "Pairs", "Milan" });

    Output("리스트 초기값",cities);
    WriteLine($"첫번째 도시는 {cities[0]}");
    WriteLine($"마지막 도시는 {cities[cities.Count-1]}");
    cities.Insert(0, "Sydney");
    Output("인덱스 0에 Sydney를 추가한 후 리스트 값",cities);
    cities.RemoveAt(1);
    cities.Remove("Milan");
    Output("두 개의 도시를 삭제한 후 리스트 값",cities);
}

WorkingWithLists();

static void WorkingWithDictionaries()
{
    Dictionary<string, string> keywords1 = new();

    keywords1.Add(key: "int", value: "32-bit interger data type");
    keywords1.Add("long", "64-bit interger data type");
    keywords1.Add("float", "Single precision floating point number");

    Dictionary<string, string> keywords2 = new()
    {
        {"int", "32-bit interger data type"},
        { "long","64-bit interger data type"},
        {"float", "Single precision floating point number" },        
    };

    Dictionary<string, string> keywords3 = new()
    {
        ["int"] = "32-bit interger data type",
        ["long"] = "64-bit interger data type",
        ["float"] = "Single precision floating point number"
    };

    Output("딕셔너리 값", keywords1.Keys);
    Output("딕셔너리 값", keywords1.Values);
    WriteLine("키와 값");
    foreach(KeyValuePair<string,string> item in keywords1)
    {
        WriteLine($"    {item.Key}: {item.Value}");
    }

    string key = "long";
    WriteLine($"키 {key}의 값 : {keywords1[key]}");
}

WorkingWithDictionaries();