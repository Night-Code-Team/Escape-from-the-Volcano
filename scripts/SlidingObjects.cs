using Godot;

public class SlidingObjects : KinematicBody
{
	protected const int difficulty = 1;
	protected const int startvel = 5;
	protected const int slide = 5;
	protected int time = 0;
	
	protected float SetSpeed() => time / (100 * difficulty) + startvel;
}