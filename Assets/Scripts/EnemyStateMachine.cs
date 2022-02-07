using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateMachine : MonoBehaviour
{
    public BaseEnemy enemy;
    public enum TurnState
    {
        Idle,
        AddToList,
        Waiting,
        Selecting,
        Action,
        Dead
    }

    public TurnState currentState;
    float currentCooldown = 0f;
    float maxCooldown = 5f;


    void Start()
    {
        currentState = TurnState.Idle;
    }


    void Update()
    {
        switch (currentState)
        {
            case (TurnState.Idle):
                UpgradeProggressBar();
                break;
            case (TurnState.AddToList):
                break;
            case (TurnState.Waiting):
                break;
            case (TurnState.Selecting):
                break;
            case (TurnState.Action):
                break;
            case (TurnState.Dead):
                break;

        }
    }
    void UpgradeProggressBar()
    {
        currentCooldown += Time.deltaTime;
    }
}