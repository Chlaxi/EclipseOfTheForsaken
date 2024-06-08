using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDodgeState : PlayerBaseState
{
    public PlayerDodgeState(PlayerStateMachine player) : base(player) { }

    public override void Enter()
    {
        Debug.Log("Entered dodge state");
    }

    public override void Tick(float deltaTime)
    {
        Debug.Log("Dodge Tick");
    }

    public override void Exit()
    {
        Debug.Log("Exit dodge state");
    }
}
