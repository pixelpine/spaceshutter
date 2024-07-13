using Godot;
using System;

public partial class Meteor : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Connect("body_entered", new Callable(this, nameof(OnBodyEntered)));
	}

	private void OnBodyEntered(Node body)
	{
		GD.Print("Body entered " + body.Name);
	}
}
