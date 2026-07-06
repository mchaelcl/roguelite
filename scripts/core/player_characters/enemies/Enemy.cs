using Godot;
using System;

public partial class Enemy : CharacterBody2D
{
	public const float Speed = 300.0f;
	public const float JumpVelocity = -400.0f;
    public bool IsEnemy = true;
    public string EnemyName = "Bird";
	public int MaxHP {get; set;} = 300;
    public int CurrentHP;
    public event Action<Enemy> Clicked;
    public String EnemyPortrait = "res://assets/characters/enemies/enemy_portraits/bird_portrait.png";

    public override void _Ready()
    {
       CurrentHP = MaxHP;
    }

    public override void _Process(double delta)
    {
        
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