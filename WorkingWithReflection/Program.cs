using static System.Console;
using System.Reflection;
using Packt.Shared;



WriteLine("어셈블리 메타데이터");
Assembly? assembly = Assembly.GetEntryAssembly();
if(assembly is null)
{
    WriteLine("어셈블리 항목 가져오기 실패");
    return;
}

WriteLine($"    전체 이름: {assembly.FullName}");
WriteLine($"    위치 : {assembly.Location}");
IEnumerable<Attribute> attribute = assembly.GetCustomAttributes();
WriteLine($"    어셈블리 레벨 속성:");
foreach( Attribute a in attribute)
{
    WriteLine($"    {a.GetType()}");
}

AssemblyInformationalVersionAttribute? version = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
WriteLine($"    버전 : {version?.InformationalVersion}");
AssemblyCompanyAttribute? company = assembly.GetCustomAttribute<AssemblyCompanyAttribute>();
WriteLine($"    회사 : {company?.Company}");


WriteLine();
WriteLine(" Types : ");
Type[] types = assembly.GetTypes();
foreach( Type type in types)
{
    WriteLine();
    WriteLine($"Type : {type.FullName}");
    MemberInfo[] members = type.GetMembers();

    foreach( MemberInfo member in members)
    {
        WriteLine("{0} : {1} ({2})",
            arg0:member.MemberType,
            arg1:member.Name,
            arg2:member.DeclaringType?.Name);

        IOrderedEnumerable<CoderAttribute> coders = member.GetCustomAttributes<CoderAttribute>()
                                                    .OrderByDescending(c => c.LastModified);
        foreach( CoderAttribute coder in coders)
        {
            WriteLine("-> Modified by {0} on {1}",
                coder.Coder,coder.LastModified.ToShortTimeString());
        }

    }
}

class Animal
{
    [Coder("Mark price", "22 August 2021")]
    [Coder("Johnni Rasmussen", "13 September 2021")]
    public void Speak()
    {
        WriteLine("Woof...");
    }
}