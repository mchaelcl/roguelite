using Godot;
using System;

public partial class AttackingState : State


{
	private PlayerNecro _player;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		 GD.Print("Attack State Ready");
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("move_left"))
		{
			GD.Print("Input detected, exiting attacking");
			fsm.TransitionTo("idle");	
		}
		
	}

	public override void Enter()
	{
		GD.Print("Entering attack state");
		_player = GetNode<PlayerNecro>("/root/Level/Necro");
		_player.PlayAttackingAnimation();
		GD.Print("Playing attack animation");
	}

    public override void Exit()
    {
		_player = GetNode<PlayerNecro>("/root/Level/Necro");
		_player.StopAnimation(); 
		GD.Print("Leaving attacking");
	}   
}
