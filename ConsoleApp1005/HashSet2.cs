using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1005
{
	class HashSet2
	{
		static void Main()
		{
			HashSet<string> sets = new HashSet<string>();
			sets.Add("홍길동");
			sets.Add("김길동");
			sets.Add("홍길동"); // 컴파일 오류는 나지않지만 출력하면 무시되서 아예 없어짐
			Console.WriteLine(sets.Count); //Count = 2


			HashSet<Person> persons = new HashSet<Person>();
			persons.Add(new Person("홍길동"));
			persons.Add(new Person("김길동"));
			persons.Add(new Person("홍길동"));

			Console.WriteLine(persons.Count); // 3이 나오는 이유는 값은 같더라도 인스턴스가 달라 중복이 아니라고 판단
											  // 여기서 Equals과 GetHashCode를 오버라이드 하지않으면 계속 들어간다
											  // Person클래스에서 재정의한 후 실행해보면 2가 나온다
		}
	}
}
