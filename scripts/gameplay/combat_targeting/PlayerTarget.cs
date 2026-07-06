using System;
using Godot;

public partial class PlayerTarget : Node
{

    public event Action<Enemy> TargetChanged;
    public Enemy CurrentTarget;
    
    public override void _Ready()
    {

        GD.Print("PlayerTarget ready");
        foreach (Node node in GetTree().GetNodesInGroup("Enemies"))
        {
            Enemy enemy = node as Enemy;

            if (enemy != null)
            {
                enemy.Clicked += OnEnemyClicked;
            }
        }
        GD.Print("Enemies added");
    }

    public override void _Process(double delta)
    {
       
    }

    public void OnEnemyClicked(Enemy enemy)
    {
        CurrentTarget = enemy;

        TargetChanged?.Invoke(enemy);

        GD.Print($"Target selected: {enemy.EnemyName}");
    }


}