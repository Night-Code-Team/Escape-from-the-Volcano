using System;
using Godot;

public class Menu : Control
{
	private int difficulty = 1;
	public void OnStartPressed()
	{
		(GetTree().Root.GetNode("Main") as MainScene).difficulty = Convert.ToDouble(difficulty) / 5;
		GetTree().ChangeScene("res://scene/Main.tscn");
	}
	public void OnQuitPressed()
	{
		GetTree().Quit();
}
	private void OnHardPPressed()
	{
		if (difficulty < 3)
		{
			difficulty += 1;
			(GetNode("Difficulty") as Label).Text = (difficulty == 0.4) ? "2" : "3";
		}
		else
		{
			(GetNode("Difficulty") as Label).Text = "3";
		}
	}
	private void OnHardMPressed()
	{
		if (difficulty > 1)
		{
			difficulty -= 1;
			(GetNode("Difficulty") as Label).Text = (difficulty == 0.4) ? "2" : "1";
		}
		else
		{
			(GetNode("Difficulty") as Label).Text = "1";
		}
	}
}
