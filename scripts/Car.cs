using Godot;

public class Car : SlidingObjects
{
	public override void _PhysicsProcess(float delta)
	{
		time++;
		Vector3 vector = new Vector3(0, 0, SetSpeed());
		if (Input.IsActionPressed("ui_up") || Input.IsActionPressed("w"))
			vector.x = SetSpeed();
		if (Input.IsActionPressed("ui_down") || Input.IsActionPressed("s"))
			vector.x = -SetSpeed();
		if (Input.IsActionPressed("ui_left") || Input.IsActionPressed("a"))
			vector.z -= SetSpeed();
		if (Input.IsActionPressed("ui_right") || Input.IsActionPressed("d"))
			vector.z += SetSpeed();
		MoveAndSlide(vector, new Vector3(0, 1, 0));
	}
}