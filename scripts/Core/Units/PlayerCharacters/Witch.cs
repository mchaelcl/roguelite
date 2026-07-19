using Godot;
using System;

public partial class Witch : TargetableCharacter
{
	public override void _Ready()
{
    base._Ready();
    MaxHp = 300;
    Position = new Vector2(500, 100);
    Name = "Witch";
    Portrait = "res://assets/characters/playerCharacters/witch.png";
    IsAlly = true;
}

	public override void _Process(double delta)
{

}
	

}
