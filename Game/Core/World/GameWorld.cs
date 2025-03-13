using Godot;
using System;

public partial class GameWorld : Node2D
{
	public static GameWorld Instance { get; set; }
	static bool start;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Instance = this;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if(!start){
			start = true;
			SaveAndLoad.Load();
		}
	}
}
