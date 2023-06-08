namespace CalPoints
{
	class Solution
	{
		public int CalPoints(string[] ops)
		{
			List<int> opList = new();

			foreach (var item in ops)
			{
				switch (item)
				{
					case var _ when int.TryParse(item, out int value):
						opList.Add(value);
						break;

					case "+":
						opList.Add(opList[^2] + opList[^1]);
						break;

					case "D" :
						opList.Add(2 * opList[^1]);
						break;

					case "C":
						opList.RemoveAt(opList.Count - 1);
						break;
				}
			}

			return opList.Sum();

		}

	}

	class CalPoints
	{
		public static void Main(string[] args)
		{
			var solution = new Solution();
			var space = new char[] { ' ' };

			string[] ops = Console.ReadLine().Split(space);
			int output = solution.CalPoints(ops);
			Console.Write(output.ToString());
		}
	}

}
