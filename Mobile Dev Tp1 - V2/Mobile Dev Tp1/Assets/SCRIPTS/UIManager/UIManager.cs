using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] IUIMgrPlayerCount IuiMgr;

    [SerializeField] UIMgrOnePlayer onePlayer;
    [SerializeField] UIMgrTwoPlayer twoPlayer;

    void SetStrategyUiMgr(IUIMgrPlayerCount mgrPlayerCount)
    {
        IuiMgr = mgrPlayerCount;
    }

    private void Start()
    {
        if (GameManager.Instancia.twoPlayers)
        {
            SetStrategyUiMgr(twoPlayer);
        }
        else
        {
            SetStrategyUiMgr(onePlayer);
        }
    }
}
