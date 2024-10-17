using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState 
{
    protected PlayerStateMachine staetMachine;
    protected Player player;

    private string animBoolName;

    public PlayerState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName)
    {
        this.player = _player;
        this.staetMachine = _stateMachine; 
        this.animBoolName = _animBoolName;  
    }

    public virtual void Enter()
    {
        Debug.Log("I enter " + animBoolName);
    }

    public virtual void Update()
    {
        Debug.Log("Im in " + animBoolName);
    }

    public virtual void Exit()
    {
        Debug.Log("I Exit " + animBoolName);
    }
}
