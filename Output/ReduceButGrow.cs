namespace TestPackage;

public class ReduceButGrow
{
	private List<int> numbers = new List<int>();
	public int GetMultiplicationOfNumbers()
	{
		var result = 1;
		for numbers
			result = result * value;
		result;
	}

	[Test]
	public void GetMultiplicationOfNumbersTest()
	{
		Assert.That(() => new from(2, 3, 4, 5).GetMultiplicationOfNumbers() == 120));
		Assert.That(() => new from(120, 5, 40, 0).GetMultiplicationOfNumbers() == 0));
		Assert.That(() => new from(2, 2, 2, 2).GetMultiplicationOfNumbers() == 16));
	}
}