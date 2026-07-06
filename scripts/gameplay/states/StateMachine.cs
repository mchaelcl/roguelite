using Godot;
using System;
using System.Collections.Generic;

//sources https://www.youtube.com/watch?v=Kcg1SEgDqyk

public partial class StateMachine : Node
{
	[Export] public NodePath initialState;

	private Dictionary<string, State> _states;
	private State _currentState;
	public override void _Ready()
	{
		_states = new Dictionary<string, State>();
		foreach (Node node in GetChildren()){
			if (node is State s)
			{
				_states[node.Name] = s;
				s.fsm = this;
				s.Ready();
				s.Exit();
			}
		}

		_currentState = GetNode<State>(initialState);
		_currentState.Enter();
		TransitionTo("idle");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// _currentState.PhysicsUpdate((float) delta);
	}

	public void TransitionTo(string key)
	{
		if(!_states.ContainsKey(key) || _currentState == _states[key])
			return;

			_currentState.Exit();
			_currentState = _states[key];
			_currentState.Enter();
	}
}
