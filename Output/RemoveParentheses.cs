namespace TestPackage;

public class RemoveParentheses
{
	private string text;
	public string Remove()
	{
		var parentheses = new Count(0);
		var result = "";
		foreach (var index in text)
				if (value == "(")
					parentheses.Increment();
				if (parentheses == 0)
					result + value;
				if (value == ")")
					parentheses - 1;
		result;
	}

	[Test]
	public void RemoveTest()
	{
		Assert.That(() => new RemoveParentheses("example(unwanted thing)example").Remove() == "exampleexample"));
	}
}