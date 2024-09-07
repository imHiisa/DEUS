using UnityEngine;

public class TelaCreditosGameState : GameBaseState
{
    public override void enterState(GameStateManager gameState)
    {
        Debug.Log("Entramos na tela de créditos.");
    }

    public override void updateState(GameStateManager gameState)
    {

        // Debug.Log("Atualizando a tela de créditos.");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // muda para o próximo estado.
            gameState.switchState(gameState.introState);
        }
    }
    public override void leaveState(GameStateManager gameState)
    {
        Debug.Log("Saindo da tela de créditos.");
    }
}
