using Godot;
using System;


public partial class Necromancer : TargetableCharacter
{
	public override void _Ready()
{
    base._Ready();
    Position = new Vector2(500, 300);
    Name = "Necromancer";
    IsAlly = true;
    MaxHp = 300;
    Portrait = "res://assets/characters/playerCharacters/witch.png";
}

	public override void _Process(double delta)
{

}
	}

