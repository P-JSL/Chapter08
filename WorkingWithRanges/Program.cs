using static System.Console;

string name = "samatha Jones";
int lengthOffFirst = name.IndexOf(' ');
int lengthOfLast = name.Length - lengthOffFirst - 1;
string firstName = name.Substring(startIndex: 0, length: lengthOffFirst-1);
string lastName = name.Substring(startIndex:name.Length - lengthOfLast, length: lengthOfLast-1);
WriteLine($"이름 : {firstName}, 성:{lastName}");

//span
ReadOnlySpan<char> nameAsSpan = name.AsSpan();
ReadOnlySpan<char> firstNameSpan = nameAsSpan[0..lengthOffFirst];
ReadOnlySpan<char> lastNameSpan = nameAsSpan[^lengthOfLast..^0];
WriteLine("이름: {0}, 성: {1}",
    arg0:firstNameSpan.ToString(),
    arg1:lastNameSpan.ToString());