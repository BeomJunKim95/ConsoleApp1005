using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1005
{
	class ArrayList2
	{
		static void Main()
		{
			ArrayList list = new ArrayList();

			list.Add(new Person("홍길동"));
			list.Add(new Person("김길동"));
			list.Add(new Person("박길동"));
			list.Add(new Person("이길동"));
			// 그래서 일반적으로 ArrayList가 아무리 Object로 받는다지만 같은타입으로만 넣는다

			list.Sort(); // 사용자정의타입은 정렬을 하려면 기준이 필요하기 때문에 인터페이스를 사용해한다

			foreach(Person info in list) //그래서 어차피 Person타입만 들어갔으니 그냥 클래스타입으로 형변환
			{
				Console.WriteLine(info.Name);
			}
		}
	}
}
