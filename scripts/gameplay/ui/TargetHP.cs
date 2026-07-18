using Godot;
using System;

public partial class TargetHP : Label
{
private TargetableCharacter _target;	
public override void _Ready()
	{
		_target = GetNode<TargetableCharacter>("/root/Level/Necromancer");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Text = $"HP:{_target.CurrentHp}";
	}
}
