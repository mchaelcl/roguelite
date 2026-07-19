using Godot;
using System;

public partial class IdleState : State
{
	private TargetableCharacter _player;
	
	public override void _Ready()
	{
		GD.Print("Idle State Ready");
	}

    public override void _Process(double delta)
    {
        if (Input.IsActionJustPressed("move_right") || 
		Input.IsActionJustPressed("move_left") ||
		Input.IsActionJustPressed("move_up") ||
		Input.IsActionJustPressed("move_down"))
		{
			GD.Print("Input detected, exiting idle");
			fsm.TransitionTo("moving");	
		}  
		
    }

    public override void Enter()
    {
		GD.Print("Transition to idle state");
        _player = GetNode<TargetableCharacter>("/root/Level/Necromancer");
		_player.PlayIdleAnimation();
    }

    public override void Exit()
    {
		_player = GetNode<TargetableCharacter>("/root/Level/Necromancer");
		_player.StopAnimation();
		GD.Print("Leaving idle");
    }


}
