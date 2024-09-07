using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    GameBaseState currentState;
    // instancias de cada um dos estados do jogo
    public TelaInicialGameState telaInicialState = new TelaInicialGameState();
    public TelaCreditosGameState telaCreditosState = new TelaCreditosGameState();
    public IntroGameState introState = new IntroGameState();


    void Start()
    {
        // Debug.Log("GameStateManager iniciou.");
        // seta o estado inicial
        currentState = telaInicialState;
        // inicia o estado.
        currentState.enterState(this);
    }
    void Update()
    {
        //Debug.Log("GameStateManager update.");
        currentState.updateState(this);
    }

    public void switchState(GameBaseState state)
    {
        // sai do estado anterior
        currentState.leaveState(this);

        // muda o estado atual
        currentState = state;

        // entra no novo estado
        currentState.enterState(this);
    }

}
