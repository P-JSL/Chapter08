using static System.Console;

string city = "London";
WriteLine($"{city}의 문자 길이는 {city.Length}입니다.");
WriteLine($"첫 번째 문자는 {city[0]}이고 세 번째 문자는 {city[2]}입니다.");

string cities = "Paris,Tehran,Cheenal,Sydney,New York,Medellin";
string[] citiesArray = cities.Split(',');
WriteLine($"배열에는 아래와 같이, 총 {citiesArray.Length}개의 항목이 있습니다.");
foreach(string item in citiesArray)
{
    WriteLine(item);
}
