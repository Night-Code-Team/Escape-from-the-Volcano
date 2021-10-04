using Godot;

public class SlidingObjects : KinematicBody
{
	protected float difficulty = 0.2F;
	protected const int startvel = 5;
	protected int time = 0;
	
	protected float SetSpeed() => time * difficulty / 100 + startvel;
}
