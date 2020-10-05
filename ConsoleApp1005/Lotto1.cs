using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1005
{
	class Lotto1
	{
		static void Main()
		{
			#region 기존의 로또번호 뽑는 방식
			//int[] lotto = new int[6];
			//Random rand = new Random();

			//int i = 0;
			//while (true)
			//{
			//	lotto[i] = rand.Next(1, 47);
			//	i++;

			//	if (i < 5)
			//	{
			//		break;
			//	}
			//}
			#endregion

			#region List로 바꿨을때
			List<int> lotto = new List<int>();
			Random rand = new Random();

			while(true)
			{
				int temp = rand.Next(1, 47);
				if (!lotto.Contains(temp))
					lotto.Add(temp);
				
				if (lotto.Count > 6)
					break;
			}
			//중복체크도 너무 쉬워지고 코드도 간편해진다
			#endregion
		}
	}
}
