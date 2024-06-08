using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerFreeformState : PlayerBaseState
{

    public PlayerFreeformState(PlayerStateMachine player) : base(player) {}

    public override void Enter()
    {
        Debug.Log("Entered Freeform state");
    }

    public override void Tick(float deltaTime)
    {
        Vector3 movement = new Vector3();
        movement.x = player.InputReader.MovementValue.x;
        movement.z = player.InputReader.MovementValue.y;
        player.CharacterController.Move(movement * player.FreeLookMovementSpeed * deltaTime);

        if (player.InputReader.MovementValue.Equals(Vector2.zero))
            return;

        var intendedLookDirection = quaternion.LookRotation(movement, Vector3.up);
        //TODO: Do some maths to interpolate the rotation
        player.transform.rotation = intendedLookDirection;
    }

    public override void Exit()
    {
        Debug.Log("Exit Freeform state");
    }
}
