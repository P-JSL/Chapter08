using static System.Console;
using System.Globalization;

WriteLine("가장 빠른 날짜/시간 값은 : {0}", DateTime.MinValue);
WriteLine("UNIX epoch 날짜/시간 값은 : {0}",DateTime.UnixEpoch);
WriteLine("현재 날짜/시간 값은 : {0}",DateTime.Now);
WriteLine("오늘 날짜/시간 값은 : {0}",DateTime.Today);

WriteLine("현재 문화권 : {0}",arg0:CultureInfo.CurrentCulture.Name);
string textDate = "4 July 2021";
DateTime independenceDay = DateTime.Parse(textDate);
WriteLine($": {0}, DateTime : {1:d MMMM}", arg0:textDate, arg1:independenceDay);
textDate = "7/4/2021";
independenceDay = DateTime.Parse(textDate);
WriteLine($"Text : {0}, DateTime: {1:d MMMM}", arg0:textDate, arg1:independenceDay);
independenceDay = DateTime.Parse(textDate, provider: CultureInfo.GetCultureInfo("en-US"));
WriteLine($"Text : {0}, DateTime: {1:d MMMM}", arg0: textDate, arg1: independenceDay);

DateOnly queenBirtyday = new(year:2022,month:4,day:21);
WriteLine($"여왕의 다음 생일은 {queenBirtyday}");
TimeOnly partyStarts = new(hour: 20, minute: 30);
WriteLine($"여왕의 파티 시작 시간 {partyStarts}");
DateTime calendarEntry = queenBirtyday.ToDateTime(partyStarts);
WriteLine($"캘린더 항목 추가 {calendarEntry}");