using Godot;
using System;

public partial class TargetHP : Label
{
private PlayerTarget _playerTarget;	
public override void _Ready()
	{
		_playerTarget = GetNode<PlayerTarget>("../PlayerTarget");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// Text = $"HP:{_playerTarget.CurrentHp}";
	}
}
