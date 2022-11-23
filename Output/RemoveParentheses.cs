namespace TestPackage;

public class RemoveParentheses
{
	private string text;
	public string Remove()
	{
		var parenthesesCount = 0;
		var result = "";
		foreach (var index in text)
				if (value == "(")
					parenthesesCount + 1;
				if (parenthesesCount == 0)
					result + value;
				if (value == ")")
					parenthesesCount - 1;
		result;
	}

	[Test]
	public void RemoveTest()
	{
		Assert.That(() => new RemoveParentheses("example(unwanted thing)example").Remove() == "exampleexample"));
	}
}