using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1005
{

	class Program
	{
		static void Main(string[] args)
		{
			#region 5명의 이름을 입력받고 , 5명의 이름을 출력해보세요.
			//string[] nameArr = new string[5];

			//for (int i = 0; i < nameArr.Length; i++)
			//{
			//	Console.Write("이름을 입력해 주세요 : ");
			//	nameArr[i] = Console.ReadLine();
			//}

			//foreach (string name in nameArr)
			//{
			//	Console.WriteLine(name);
			//}
			#endregion

			#region 5명의 이름과 전화번호를 입력받아서, 출력해보세요

			//string[,] personArr = new string[5, 2]; // string[,] 2차배열 , string[][] 가변배열

			//for (int i = 0; i < personArr.GetLength(0); i++) //GetLength(); = 차수를 파라미터로 입력하면 2차배열의 길이 출력가능
			//{
			//	Console.Write("이름을 입력해주세요 : ");
			//	personArr[i, 0] = Console.ReadLine();

			//	Console.WriteLine("전화번호를 입력해주세요 : ");
			//	personArr[i, 1] = Console.ReadLine();
			//}

			//for (int i = 0; i < personArr.GetLength(0); i++)
			//{
			//	Console.WriteLine($"{personArr[i, 0]}님의 전화번호는 {personArr[i, 1]} 입니다.");
			//}
			#endregion

			#region 5명의 이름, 전화번로, 생일을 입력받아서 출력해보세요
			////더 늘어날수록 2차배열로 하기엔 너무 귀찮음 클래스를 만들어 편하게 

			//Person[] pArr = new Person[5]; //그래서 내가만든 타입의 1차배열로 만들자
			//for (int i = 0; i < pArr.Length; i++)
			//{
			//	Person info = new Person();
			//	Console.Write("이름 : ");
			//	info.Name = Console.ReadLine();
			//	Console.Write("전화번호 : ");
			//	info.Phone = Console.ReadLine();
			//	Console.Write("생일 : ");
			//	info.Birth = Console.ReadLine();

			//	pArr[i] = info;
			//}
			//foreach (Person info in pArr)
			//{
			//	Console.WriteLine($"{info.Name}, {info.Phone}, {info.Birth}");
			//}
			#endregion

			//입력하는대로 이름,전화번호,생일을 모두 저장했다가 출력해보세요.(컬렉션)

			//ArrayList arrPerson = new ArrayList();
			List<Person> list = new List<Person>();
			while (true)
			{
				Person info = new Person();
				Console.Write("이름을 입력하세요 : ");
				info.Name = Console.ReadLine();
				Console.Write("전화번호를 입력하세요 : ");
				info.Phone = Console.ReadLine();
				Console.Write("생일을 입력하세요 : ");
				info.Birth = Console.ReadLine();

				//arrPerson.Add(info);
				//arrPerson.Add(100); // 컴파일에 오류는 나지않지만 밑에 foreach출력부분에서 오류가 남 (타입이 다르기 때문에)
				list.Add(info);
				//list.Add(100); // 제네릭을 쓰면 바로 오류가뜸

				Console.Write("입력을 계속하시겠습니까? (Y/N): ");
				if(Console.ReadLine().ToUpper() =="N")
				{
					break;
				}

			}
			//foreach(Person info in arrPerson)
			foreach (Person info in list)
			{
				Console.WriteLine($"{info.Name} {info.Phone} {info.Birth}");
			}



		}
	}
	class Person : IComparable
	{
		public string Name { get; set; }
		public string Phone { get; set; }
		public string Birth { get; set; }

		#region ctor
		public Person()
		{

		}
		public Person(string name)
		{
			Name = name;
		}
		public Person(string name, string phone, string birth)
		{
			Name = name;
			Phone = phone;
			Birth = birth;
		}
		#endregion

		public int CompareTo(object obj)
		{
			Person info = (Person)obj;

			return this.Name.CompareTo(info.Name); //String의 CompareTo메서드를 사용해 이름정렬
		}

		public override bool Equals(object obj)
		{
			//return obj is Person info &&
			//	   Name == info.Name;
			Person info = (Person)obj;
			return this.Name == info.Name; //이름만 같으면 같은거로 봄
		}

		public override int GetHashCode()
		{
			return EqualityComparer<string>.Default.GetHashCode(Name);
		}
	}
}
