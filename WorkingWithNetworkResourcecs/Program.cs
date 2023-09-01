using static System.Console;
using System.Net;
using System.Net.NetworkInformation;

WriteLine("유효한 웹사이트 주소를 입력하세요: ");
string? url = ReadLine();

if(string.IsNullOrWhiteSpace(url))
{
    url = "https://stackoverflow.com/search?q=securestring";
}
Uri uri = new(url);
WriteLine($"URL : {url}");
WriteLine($"Scheme : {uri.Scheme}");
WriteLine($"Port : {uri.Port}");
WriteLine($"Host : {uri.Host}");
WriteLine($"Path : {uri.AbsolutePath}");
WriteLine($"Query : {uri.Query}");

IPHostEntry entry = Dns.GetHostEntry(uri.Host);
WriteLine($"{entry.HostName} 의 ip 주소");
foreach(IPAddress address in entry.AddressList)
{
    WriteLine($"    {address} ({address.AddressFamily})");
}

//핌 보내기
try
{
    Ping ping = new();
    WriteLine("서버에 Ping 전송");
    PingReply reply = ping.Send(uri.Host);
    WriteLine();
    if(reply.Status == IPStatus.Success)
    {
        WriteLine("{0}으로부터의 응답 시간 {1:N0}ms",
            arg0:reply.Address,
            arg1:reply.RoundtripTime);
    }
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType().ToString()} says {ex.Message}");
}
