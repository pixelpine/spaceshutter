using Godot;
using System;

public partial class Timer_x : Timer
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Connect("timeout", new Callable(this, nameof(OnTimeout)));
		Start();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void OnTimeout()
	{
		GD.Print("Meteor");
	}
}
