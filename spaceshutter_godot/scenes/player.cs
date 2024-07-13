using Godot;
using System;
using System.IO;
using System.Numerics;

public partial class player : Node2D

{
	[Export] // Export the variable to be seen in the godot editor
	private float speed = 500;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready() // Called once
	{
		Position = new Godot.Vector2(100,500);
		//Node2D playerimage = GetNode<Node2D>("PlayerImage");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		/*if (Input.IsActionPressed("ui_down"))
        {
			Position += new Godot.Vector2(1,0) * 50 * (float)delta;
			// Get only the node PlayerImage and rotate it
			GetNode<Node2D>("PlayerImage").Rotation += 0.1f*(float)delta;
            GD.Print("S key or Down Arrow key is pressed!");
        }
		*/
		bool up = Input.IsActionPressed("ui_up");
		bool down = Input.IsActionPressed("ui_down");
		bool left = Input.IsActionPressed("ui_left");
		bool right = Input.IsActionPressed("ui_right");
		Godot.Vector2 directionalInput = new Godot.Vector2((right ? 1 : 0)-(left ? 1 : 0), (down ? 1 : 0) - (up ? 1 : 0));
		Position += directionalInput * speed * (float)delta; 
	}
}
