using UnityEngine;
using UnityEngine.UI;

public class UIMgrTwoPlayer : MonoBehaviour, IUIMgrPlayerCount
{
    [SerializeField] Text moneyPlayer1;
    [SerializeField] Text moneyPlayer2;

    public void UpdaterMoneyPlayerOne(string _money)
    {
        moneyPlayer1.text = _money;
    }

    public void UpdaterMoneyPlayerTwo(string _money)
    {
        moneyPlayer2.text = _money;
    }
}
