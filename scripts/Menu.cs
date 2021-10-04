using Godot;

public class Menu : Control
{
	public void OnStartPressed()
	{
		GetTree().ChangeScene("res://scene/Main.tscn");
	}
	public void OnQuitPressed()
	{
		GetTree().Quit();
	}
}
