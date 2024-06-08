public abstract class PlayerBaseState : State 
{
    protected PlayerStateMachine player;

    public PlayerBaseState(PlayerStateMachine player)
    {
        this.player = player;
    }
}
