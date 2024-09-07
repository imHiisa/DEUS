using UnityEngine;

public class IntroGameState : GameBaseState
{
    public override void enterState(GameStateManager gameState)
    {
        Debug.Log("Entramos no modo intro.");
    }

    public override void updateState(GameStateManager gameState)
    {

        // Debug.Log("Atualizando a tela inicial.");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // muda para o próximo estado.
            gameState.switchState(gameState.telaInicialState);
        }
    }

    public override void leaveState(GameStateManager gameState)
    {
        Debug.Log("Saindo do modo intro.");
    }
}
