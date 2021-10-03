using Godot;
using System.Collections.Generic;

public class MainScene : Spatial
{
	private List<MeshInstance> roads = new List<MeshInstance>();
	private int time = 0;
	public int score { get; private set; }
	public override void _Process(float delta)
	{
		time++;
		score = time;
	}
	private MeshInstance AddNewTile(List<MeshInstance> roads)
	{
		// заготовка метода для генерации дороги
		MeshInstance road = new MeshInstance();
		return road;
	}
}
