using System;
using Godot;

public partial class PlayerTarget : Node
{

    public event Action<TargetableCharacter> TargetChanged;
    public CharacterBody2D CurrentTarget;
    
    public override void _Ready()
    {

        GD.Print("PlayerTarget ready");
        foreach (Node node in GetTree().GetNodesInGroup("Target"))
        {
            TargetableCharacter target = node as TargetableCharacter;

            if (target != null)
            {
                target.Clicked += OnTargetClicked;
            }
        }
        GD.Print("Enemies added");
    }

    public override void _Process(double delta)
    {
       
    }

    public void OnTargetClicked(TargetableCharacter target)
    {
        CurrentTarget = target;

        TargetChanged?.Invoke(target);

        GD.Print($"Target selected: {target.Name}");
    }


}