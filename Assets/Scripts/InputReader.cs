using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour, Controls.IPlayerActions
{

    public Vector2 MovementValue { get; private set; }
    public event Action DodgeEvent;
    public event Action LightAttackEvent;
        public event Action ParryEvent;

    private Controls controls;

    private void Start() {
        controls = new Controls();
        controls.Player.SetCallbacks(this); 

        controls.Player.Enable();
    }

    private void OnDestroy() {
        controls.Player.Disable();
    }

    public void OnDodge(InputAction.CallbackContext context)
    {
        if (!context.performed)
            return;

        DodgeEvent?.Invoke();
    }

    public void OnHeavyAttack(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnLightAttack(InputAction.CallbackContext context)
    {
        if (!context.performed)
            return;

        LightAttackEvent.Invoke();
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        MovementValue = context.ReadValue<Vector2>();
    }

    public void OnParryBlock(InputAction.CallbackContext context)
    {
        if (context.performed){
            ParryEvent.Invoke();
        }
        // TODO: Switch to block if held.
    }

    public void OnUseItem(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }
}
