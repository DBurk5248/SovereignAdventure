using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerStateMachine StateMachine { get; private set; }

    public PlayerIdle idleState { get; private set; }
    public PlayerMove moveState { get; private set; }

    private void Awake()
    {
        StateMachine = new PlayerStateMachine();

        idleState = new PlayerIdle(this, StateMachine, "Idle");
        moveState = new PlayerMove(this, StateMachine, "Move");
    }

    private void Start()
    {
        StateMachine.Initialize(idleState);
    }

    private void Update()
    {
        StateMachine.currentState.Update();
    }
}
