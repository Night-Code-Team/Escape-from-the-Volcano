using Godot;

public class MainCamera : SlidingObjects
{
	public override void _PhysicsProcess(float delta)
	{
		time++;
		Vector3 vector = new Vector3(0, 0, SetSpeed());
		MoveAndSlide(vector, new Vector3(0, 1, 0));
	}
}