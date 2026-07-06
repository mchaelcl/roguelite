using Godot;
using System;

public partial class EnemyPortrait : TextureRect
{
	public PlayerTarget _playerTarget;
	

	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_playerTarget = GetNode<PlayerTarget>("../PlayerTarget");

		_playerTarget.TargetChanged += OnTargetChanged;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}

	private void OnTargetChanged(Enemy enemy)
	{
		Texture = GD.Load<Texture2D>(enemy.EnemyPortrait);
	}
}
