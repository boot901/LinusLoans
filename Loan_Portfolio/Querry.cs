using System;
namespace Loan_Portfolio
{
	public static class Querry
	{
		public static bool IsInQuerry(string q,string s) {
			String morefunc = s;
			String QQ = q;

			if (QQ.Equals(q))
			{
				return true;
			}
			else if (q.Contains(QQ))
			{
				return true;
			}
			else {
				return false;
			}
		}
	}
}

