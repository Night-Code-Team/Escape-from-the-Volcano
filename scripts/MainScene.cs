using Godot;
using System;

public class MainScene : Spatial
{
	private int time = 0;
	public double difficulty { get; set; }
	private float z_coord = -15.6F;
	private string[] road_names = System.IO.Directory.GetFiles(@"scene/Tiles_road");
	private string[] environment_names = System.IO.Directory.GetFiles(@"scene/Tiles_env");
	private Random blessrng_road = new Random();
	private Random blessrng_env_bot = new Random();
	private Random blessrng_env_top = new Random();
	public override void _Ready()
	{
		for (int i = 0; i < 5; i++)
		{
			AddNewTile();
		}
	}
	public override void _Process(float delta)
	{
		time++;
		if (time % 5 == 0)
		{
			AddNewTile();
		}
		if ((GetNode("Car") as KinematicBody).Translation.z - (GetNode("MainCamera") as KinematicBody).Translation.z <= -2.5)
		{
			GetTree().ChangeScene("res://scene/mainMenu.tscn");
		}
	}
	private void AddNewTile()
	{
		int i = blessrng_road.Next(0, road_names.Length);
		var spawn_road = (GD.Load($"res://{road_names[i]}") as PackedScene).Instance() as Spatial;
		spawn_road.Translate(new Vector3(0, -0.75F, z_coord));
		AddChild(spawn_road);
		i = blessrng_env_bot.Next(0, environment_names.Length);
		var spawn_env_bot = (GD.Load($"res://{environment_names[i]}") as PackedScene).Instance() as Spatial;
		spawn_env_bot.Translate(new Vector3(-6.4F, -0.75F, z_coord));
		AddChild(spawn_env_bot);
		i = blessrng_env_top.Next(0, environment_names.Length);
		var spawn_env_top = (GD.Load($"res://{environment_names[i]}") as PackedScene).Instance() as Spatial;
		spawn_env_top.Translate(new Vector3(6.4F, -0.75F, z_coord));
		AddChild(spawn_env_top);
		z_coord += 6.4F;
	}
}
