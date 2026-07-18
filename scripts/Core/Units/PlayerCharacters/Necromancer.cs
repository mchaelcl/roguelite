using Godot;
using System;


public partial class Necromancer : TargetableCharacter
{
    private AnimatedSprite2D _anim;
    private RayCast2D _forwardRay;
    private RayCast2D _backwardRay;
    private RayCast2D _upwardRay;
    private RayCast2D _downwardRay;

	public override void _Ready()
{
    _anim = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
    _forwardRay = GetNode<RayCast2D>("ForwardRay");
    _backwardRay = GetNode<RayCast2D>("BackwardRay");
    _upwardRay = GetNode<RayCast2D>("UpwardRay");
    _downwardRay = GetNode<RayCast2D>("DownwardRay");
    CurrentHp = MaxHp;
    Position = new Vector2(500, 300);
    Name = "Necromancer";
}

	public override void _Process(double delta)
{

}
	}

