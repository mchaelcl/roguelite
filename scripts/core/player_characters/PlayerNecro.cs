using Godot;
using System;


public partial class PlayerNecro : CharacterBody2D
{
	[Export]
	public int Speed {get; set;} = 300;
    [Export]
    public int MaxHp {get; set;} = 300;
    [Export]
    public int CurrentHP;

	public Vector2 ScreenSize;

    private AnimatedSprite2D _anim;

    private RayCast2D _forwardRay;
    private RayCast2D _backwardRay;
    private RayCast2D _upwardRay;
    private RayCast2D _downwardRay;

	public override void _Ready()
{
    _anim = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
    ScreenSize = GetViewportRect().Size; //?
    _forwardRay = GetNode<RayCast2D>("ForwardRay");
    _backwardRay = GetNode<RayCast2D>("BackwardRay");
    _upwardRay = GetNode<RayCast2D>("UpwardRay");
    _downwardRay = GetNode<RayCast2D>("DownwardRay");
    CurrentHP = MaxHp;
}

	public override void _Process(double delta)
{

}

public  void PlayIdleAnimation()
    {
        _anim.Play("idle");
    }
    public void StopIdleAnimation()
    {
        _anim.Stop();
    }

    public void PlayAttackingAnimation()
    {
        _anim.Play("attacking");
    }

     public void PlayMovingingAnimation()
    {
        _anim.Play("moving");
    }

    public void StopAnimation()
    {
        _anim.Stop();
    }

    public void PlayMovingAnimation()
    {
        _anim.Play("moving");
    }
	}

