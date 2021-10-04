using Godot;

public class Score : Label
{
	private int score = 0;
	public override void _Process(float delta)
	{
		Text = (++score).ToString();
	}
}
