using Godot;
using System;
public partial class MovingState : State
{

    [Export]
	public int Speed {get; set;} = 300;

    private TargetableCharacter _player;
    private RayCast2D _forwardRay;
    private RayCast2D _backwardRay;
    private RayCast2D _upwardRay;
    private RayCast2D _downwardRay;
    

    public override void _Ready()
    {
        GD.Print("Entering moving state");
    }

        public override void _Process(double delta)
    {
        var velocity = Vector2.Zero; // The player's movement vector.

    if (Input.IsActionPressed("move_right"))
        if (!_forwardRay.IsColliding()) {
        velocity.X += 1;
    } else
        {
            GD.Print("Blocked!");
        }
    

    if (Input.IsActionPressed("move_left"))
        if(!_backwardRay.IsColliding()) {
        velocity.X -= 1;
    } else
        {
            GD.Print("Blocked!");
        }

    if (Input.IsActionPressed("move_down"))
        if(!_downwardRay.IsColliding()) {
        velocity.Y += 1;
    } else
        {
            GD.Print("Blocked!");
        }

    if (Input.IsActionPressed("move_up"))
        if(!_upwardRay.IsColliding()) {
        velocity.Y -= 1;
    } else
        {
            GD.Print("Blocked!");
        }

    if (velocity.Length() > 0)
    {
        velocity = velocity.Normalized() * Speed;
        _player.PlayMovingAnimation();
    }
    else
        {
            _player.PlayIdleAnimation();
        }
    
  
    
    _player.Position += velocity * (float)delta;
    _player.Position = new Vector2(
    x: Mathf.Clamp(_player.Position.X, 0, _player.ScreenSize.X),
    y: Mathf.Clamp(_player.Position.Y, 0, _player.ScreenSize.Y));

      if (velocity.X == 0 && velocity.Y == 0)
    {
        fsm.TransitionTo("idle");
    }

    }

    public override void Enter()
    {
        _player = GetNode<TargetableCharacter>("/root/Level/Necromancer");
        GD.Print("Entering moving state");
        _forwardRay = GetNode<RayCast2D>("/root/Level/Necromancer/ForwardRay");
        _backwardRay = GetNode<RayCast2D>("/root/Level/Necromancer/BackwardRay");
        _upwardRay = GetNode<RayCast2D>("/root/Level/Necromancer/UpwardRay");
        _downwardRay = GetNode<RayCast2D>("/root/Level/Necromancer/DownwardRay");
    }

    public override void Exit()
    {
        _player = GetNode<TargetableCharacter>("/root/Level/Necromancer");
        _player.StopAnimation();
        GD.Print("Leaving moving state");
    }
}
