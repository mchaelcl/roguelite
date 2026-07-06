using Godot;
using System;

public partial class HPLabel : Label
{

	private PlayerNecro _player;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_player = GetNode<PlayerNecro>("/root/Level/Necro");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Text = $"HP: {_player.CurrentHP}";
	}
}
