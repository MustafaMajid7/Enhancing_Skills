using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
	public class SwitchCases
	{
		public static string switchCases(int num=10)
		{
			#region old way of switch
			//switch (num)
			//{
			//	case 0:
			//		return "mostafa";
			//	case 1:
			//		return "mahmoud";
			//	case 2:
			//		return "mohamed";
			//	case 3:
			//		return "ahmed";
			//	default:
			//		return "youssef";
			//} 
			#endregion

			// new way of switch (switch expression)

			return num switch
			{
				0 => "mostafa",
				1 => "mahmoud",
				2=> "mohamed",
				_ => "youssef"
			};
		}
	}
}
