namespace TestPackage;

public class RemoveParentheses
{
	private string text;
	public string Remove()
	{
		var parentheses = 0;
		var result = "";
		foreach (var index in text)
			if (value == "(")
				var parentheses = parentheses + 1;
			else
				if (value == ")")
					var parentheses = parentheses - 1;
				else
					if (parentheses == 0)
						var result = result + value;
		result;
	}

	[Test]
	public void RemoveTest()
	{
		Assert.That(() => new RemoveParentheses("example(unwanted thing)example").Remove() == "exampleexample"));
	}
}