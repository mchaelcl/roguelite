using System;
using Godot;

public partial class PlayerTarget : Node
{

    public event Action<TargetableCharacter> TargetChanged;
    public TargetableCharacter CurrentTarget;
    
    public override void _Ready()
    {

        GD.Print("PlayerTarget ready");
        foreach (Node node in GetTree().GetNodesInGroup("TargetableCharacter"))
        {
            GD.Print($"Found: {node.Name}");

            TargetableCharacter target = node as TargetableCharacter;

            if (target != null)
            {
                target.Clicked += OnTargetClicked;
            }
        }
        GD.Print("Targetable characters added");
    }

    public override void _Process(double delta)
    {
       
    }

    public void OnTargetClicked(TargetableCharacter target)
    {
        CurrentTarget = target;
        GD.Print("Target updated");

        TargetChanged?.Invoke(target);
        GD.Print("Event invoked");

        GD.Print($"Target selected: {target.Name}");
    }


}