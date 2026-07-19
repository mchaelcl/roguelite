using System;
using Godot;

public partial class TargetableCharacter : CharacterBody2D
{
    public event Action<TargetableCharacter> Clicked;

    [Export]
    public int Speed {get; set;} = 300;
    [Export]
    public int MaxHp {get; set;}
    [Export]
    public int CurrentHp;

    public Boolean IsAlly;

    public Vector2 ScreenSize;

    private AnimatedSprite2D _anim;

    private RayCast2D _forwardRay;
    private RayCast2D _backwardRay;
    private RayCast2D _upwardRay;
    private RayCast2D _downwardRay;

    public String Portrait;

    public override void _Ready()
{
    _anim = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
    _forwardRay = GetNode<RayCast2D>("ForwardRay");
    _backwardRay = GetNode<RayCast2D>("BackwardRay");
    _upwardRay = GetNode<RayCast2D>("UpwardRay");
    _downwardRay = GetNode<RayCast2D>("DownwardRay");
    CurrentHp = MaxHp;
}

	public override void _Process(double delta)
{

}

public  void PlayIdleAnimation()
    {
        _anim.Play("idle");
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

    public override void _InputEvent(
    Viewport viewport,
    InputEvent @event,
    int shapeIdx)
{
    if (@event is InputEventMouseButton mouse &&
        mouse.Pressed &&
        mouse.ButtonIndex == MouseButton.Left)
    {
        Clicked?.Invoke(this);
        GD.Print("Input event received");
    }
}
}