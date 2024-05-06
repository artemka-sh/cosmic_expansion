using Godot;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public partial class label : Label
{

	private int _speed = 400;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Text = "some shit";
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		float dt = (float)delta;
		update(dt);
		inputEventUpdate(dt);
		
	}

	public void inputEventUpdate(float dt)
	{
		if(Input.IsKeyPressed(Key.W)) this.Position += new Vector2(0, -50) * dt;
		if(Input.IsKeyPressed(Key.A)) this.Position += new Vector2(-50, 0) * dt;
		if(Input.IsKeyPressed(Key.S)) this.Position += new Vector2(0, 50) * dt;
		if(Input.IsKeyPressed(Key.D)) this.Position += new Vector2(50, 0) * dt;

	}

	private void update(float dt)
	{
		Rotation += (float)Math.PI * dt;
		Position += Vector2.Up.Rotated(Rotation) * _speed * (float)dt;
	}
}
