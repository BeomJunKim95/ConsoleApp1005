using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1005
{
	class Generic1
	{
		static void Main()
		{
			List<Person> list = new List<Person>();
			list.Add(new Person("홍길동"));
			list.Add(new Person("김길동"));
			list.Add(new Person("박길동"));
			list.Add(new Person("이길동"));

			for (int i = 0; i < list.Count; i++)
			{
				Console.WriteLine(list[i].Name);
			}

			//List<int> list = new List<int>(); // <> 꺽쇠는 제네릭을 나타냄
			////제네릭은 처음에 내가 정의한 타입만 넣을수있다 => 형변환이 필요없다
			//list.Add(10);
			//list.Add(20);
			////list.Add("딸기"); //제네릭을 인트타입으로 선언해 문자열은 컴파일부터 불가

			//for (int i = 0; i < list.Count; i++)
			//{
			//	Console.WriteLine(i);
			//}
		}
	}
}
