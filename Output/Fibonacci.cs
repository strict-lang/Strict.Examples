namespace TestPackage;

public class Fibonacci
{
	private int number;
	public int GetNthFibonacci()
	{
		var first = Mutable(1);
		var second = Mutable(1);
		var next = Mutable(1);
		foreach (var index in new Range(2, number))
				var next = first + second;
				var first = second;
				var second = next;
		next;
	}

	[Test]
	public void GetNthFibonacciTest()
	{
		Assert.That(() => new Fibonacci(5).GetNthFibonacci() == 5));
		Assert.That(() => new Fibonacci(10).GetNthFibonacci() == 55));
	}
}