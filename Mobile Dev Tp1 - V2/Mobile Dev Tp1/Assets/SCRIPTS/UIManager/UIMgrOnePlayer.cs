using UnityEngine;
using UnityEngine.UI;

public class UIMgrOnePlayer : MonoBehaviour, IUIMgrPlayerCount
{
    [SerializeField] Text money;

    public void UpdaterMoneyPlayerOne(string _money)
    {
        money.text = _money;
    }

    public void UpdaterMoneyPlayerTwo(string _money)
    {
        throw new System.NotImplementedException();
    }
}
