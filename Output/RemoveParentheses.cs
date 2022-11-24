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
			else
				if (value == ")")
					parentheses - 1;
				else
					if (parentheses == 0)
						result + value;
		result;
	}

	[Test]
	public void RemoveTest()
	{
		Assert.That(() => new RemoveParentheses("example(unwanted thing)example").Remove() == "exampleexample"));
	}
}