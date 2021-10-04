using Godot;

public class Music : AudioStreamPlayer3D
{
	public override void _Ready()
	{
		Autoplay = true;
		Play();
	}
}
