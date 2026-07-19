using Godot;
using System;

public partial class Bird : TargetableCharacter
{
    public override void _Ready()  
    {
    base._Ready();
    MaxHp = 300;
    Position = new Vector2(600, 300);
    Name = "Bird";
    Portrait = "res://assets/characters/enemies/enemy_portraits/bird_portrait.png";
}

    public override void _Process(double delta)
    {
        
    }

}