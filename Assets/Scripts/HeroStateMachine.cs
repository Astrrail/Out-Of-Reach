using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroStateMachine : MonoBehaviour
{
    public BaseHero hero;

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
    float maxCooldown = 5.45f;
    public Image progressBar;

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
        float calcCooldown = currentCooldown / maxCooldown;
        progressBar.transform.localScale = new Vector3(MaxProgress(calcCooldown), progressBar.transform.localScale.y, progressBar.transform.localScale.z);
        if (currentCooldown >= maxCooldown)
        {
            currentState = TurnState.AddToList;
        }
    }

    private static float MaxProgress(float calcCooldown)
    {
        return Mathf.Clamp(calcCooldown, 0, 5.45f);
    }
}
