using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1005
{
	class HashTable1
	{
		static void Main()
		{
			//Hashtable은 검색속도의 중요도에따라 사용할지 결정
			//검색이 많은경우 사용하면 좋다
			Hashtable ht = new Hashtable();
			ht.Add("홍길동", 25); //키값과 밸류값 모두 입력해야한다 => ht.Add(키값, 밸류값)
			ht.Add("김길동", 25);
			ht.Add("박길동", 35);
			ht.Add("이길동", 40);
			//ht.Add("이길동", 25); // 키값이 같은값이 이미 있어 예외처리됨

			if (!ht.ContainsKey("이길동")) //ContainsKey 키값이 있는지 bool타입으로 반환해줌
				ht.Add("이길동", 40);

			//int age = (int)ht["박길동"];
			//Console.WriteLine(age);

			foreach (string key in ht.Keys)
			{
				Console.WriteLine($"{key}- {ht[key]}");
			}


			//SortedList는 HashTable과 사용법이 유사하다 
			//SortedList는 key그자체가 정렬되어 값의 순서에 영향을 준다
			//하지만 많이 사용되지 않는다
			Console.WriteLine("SortedList");
			SortedList st = new SortedList();
			st.Add("홍길동", 25); 
			st.Add("김길동", 25);
			st.Add("박길동", 35);
			st.Add("이길동", 40);
			

			if (!ht.ContainsKey("이길동")) 
				ht.Add("이길동", 40);

			foreach (string key in st.Keys)
			{
				Console.WriteLine($"{key}- {st[key]}");
			}
		}
	}
}
