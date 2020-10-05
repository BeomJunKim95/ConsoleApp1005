using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1005
{
	class HashSet1
	{
		static void Main()
		{
			HashSet<int> lotto = new HashSet<int>();
			Random rnd = new Random();

			while(true)
			{
				lotto.Add(rnd.Next(1, 47));

				if (lotto.Count > 6)
					break;
			}
			//HashSet은 List와 다르게 중복체크 코드가 없다
			//HashSet은 중복된 값이 나오면 알아서 무시하기 때문에 Add만 해도 된다

			int[] a_lotto = lotto.ToArray<int>();
			Array.Sort(a_lotto);

			foreach(int temp in a_lotto)
			{
				Console.Write(temp + ",");
			}
		}
	}
}
