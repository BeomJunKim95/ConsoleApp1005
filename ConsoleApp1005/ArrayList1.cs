using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1005
{
	class ArrayList1
	{
		static void Main()
		{
			#region 입력하는대로 이름,전화번호,생일을 모두 저장했다가 출력해보세요.(컬렉션)
			//Console.WriteLine("몇명까지 입력하실겁니까? : ");
			//int Cnt = int.Parse(Console.ReadLine());
			//Person[] pArr2 = new Person[Cnt];
			//먼저 명수를 int로 입력받고 그만큼 배열을 만들면됨 
			//하지만 이건 우리가 원하는 동적코딩이 아님 

			Person info = new Person();
			info.Name = "홍길동";
			info.Phone = "010-1111-1111";

			ArrayList alist = new ArrayList(); //네임스페이스가 System.Collections

			alist.Add("사과"); //컬렉션에서는 Add속성으로 그냥 이렇게 추가
			alist.Add("사과"); //컬렉션은 인덱스로 관리하기 때문에 같은 밸류의 값이 있어도 ㄱㅊ
			alist.Add("딸기");
			alist.Add("참외");
			alist.Add("수박");
			alist.Add(123); //문자열만 넣다가 숫자를 넣어도 들어감
			alist.Add(info); //내부적으로는 ToString을 호출하는것이니 네임스페이스.클래스명이 나옴
			alist.Insert(1, "포도"); // Add는 무조건 배열의 끝으로 넣지만 Insert함수는 지정한 인덱스에 넣는다

			alist.Sort();
			//Array에서는 정렬이 정적메서드 였지만 ArrayList에서는 인스턴스 메서드로 제공됨
			//하지만 정렬을 하려면 ArrayList안의 요소들은 모두 같은 타입이여야함

			//배열에 고정길이와 같은 타입을 개선한게 바로 컬렉션
			Console.WriteLine(alist.Count); //Count속성을 사용하면 인덱스 출력

			alist.Remove("수박"); // 삭제도 쉬움
			alist.RemoveAt(2); //몇번째 인덱스로 삭제할때 RemoveAt
			//alist.Clear(); //Clear는 모든요소 삭제

			Console.WriteLine(alist.Count); // 3이나옴

			for (int i = 0; i < alist.Count; i++)
			{
				if (alist[i] is Person)
				{
					Console.WriteLine(((Person)alist[i]).Name); // 컬렉션의 단점 : 박싱과 언박싱 또는 형변환이 자주 일어남
				}
				else
					Console.WriteLine(alist[i]);
			}

			#endregion

			
		}
	}
}
