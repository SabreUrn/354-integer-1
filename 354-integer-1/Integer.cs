using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _354_integer_1 {
	public class Integer {
		Dictionary<long, long> _factors;

		public Integer() {
			_factors = new Dictionary<long, long>();
		}

		public long FindSumOfFactors(long a) {
			//ensure a is positive
			if (a <= 0) {
				Console.WriteLine("Product must be a positive integer.");
				return -1;
			}

			long tempSum = 0;
			long sum = a+1; //will always be the sum of the first factorisation (a * 1) and other correct sums will always be lower than or equal to
			for(long i = 1; i <= Math.Sqrt(a); i++) { //after the sqrt of a, we're past the half-way point. all pairs afterwards are duplicates.
				if(a % i == 0) {			//if a divides with i with no remainder,
					tempSum = a / i + i;	//set the value to check against to the sum of i and a / i
				}
				if(tempSum <= sum) {
					sum = tempSum;
				} else {
					break;				//we're going the other way now, break the for-loop
				}
			}
			//DebugPrintDictionaryContents();
			return sum;
		}

		private void DebugPrintDictionaryContents() {
			foreach (KeyValuePair<long, long> kvp in _factors) {
				Console.WriteLine(kvp.Key + ", " + kvp.Value);
			}
			Console.WriteLine();
		}
	}
}
