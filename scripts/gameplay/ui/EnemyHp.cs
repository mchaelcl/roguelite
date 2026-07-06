using Godot;
using System;

public partial class EnemyHp : Label
{
private Enemy _enemy;	public override void _Ready()
	{
		_enemy = GetNode<Enemy>("/root/Level/Enemy");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Text = $"HP:{_enemy.CurrentHP}";
	}
}
