using System;
using System;

namespace Disemvoweler
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Disemvoweler ("Hello world!");
		}

		/// <summary>
		/// Prints input string without spaces or vowels
		/// </summary>
		/// <param name="input">Input string</param>
		static void Disemvoweler(string input){

			string disemvoweled="";
			string vowelspace="";

			foreach(var c in input){
				string s = c.ToString().ToUpper ();
				if("AEIOU".Contains(s)){
					vowelspace = vowelspace + c;
				}

				else if(c==' '){

				}
				else{
					disemvoweled = disemvoweled + c;
				}

			}
			Console.Write (disemvoweled);
			Console.WriteLine (vowelspace);

			//			for(int i=0;i<input.Length; i++){
			//				if(Char.IsWhiteSpace(input[i])){
			//					Console.WriteLine ("space");
			//					//input = input.Remove(i,1);
			//					//input.Replace(" ", String.Empty);
			//
			//				}
			//
			//				string c = input[i].ToString().ToUpper();
			//
			//				if("AEIOU".Contains(c)){
			//					Console.Write ("vowelspace");
			//					input = input.Remove(i,1);
			//				}
			//				Console.WriteLine (input[i]);
			//			}
			//
			//			Console.WriteLine (input);
		}
	}
}
