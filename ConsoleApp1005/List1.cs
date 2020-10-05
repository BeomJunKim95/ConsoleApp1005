using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1005
{
	class List1
	{
		static void Main()
		{
			List<string> list = new List<string>(); //반드시 new해야함

			list.Add("김치찌개");
			list.Add("된장찌개");
			list.Add("순두부찌개");
			list.Add("동태찌개");
			list.Add("김치찌개"); //List는 인덱스가 중요해서 중복해도 오류가안남


			foreach(string item in list) //foreach 사용
			{
				Console.WriteLine();
			}

			list.Sort();
			list.Reverse();

			string[] arr = list.ToArray(); //ToArray(); => List의 요소를 배열로 복사하는 메서드
			int[] strArr = new int[3] { 10, 20, 30 };
			List<int> iList = strArr.ToList<int>();
			//List가 배열로 배열이 List로 자유자재로 바꿀수있다

			for(int i =0;i<list.Count;i++)//for 사용
			{
				Console.WriteLine(list[i]);
			}

		}
	}
}
