using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MngPts : MonoBehaviour
{
    Rect R = new Rect();

    [SerializeField] Image secondPlayerImage;
    [SerializeField] TextMeshProUGUI secondPlayerText;
    [SerializeField] TextMeshProUGUI firstPlayerText;

    [SerializeField] GameObject WinPlayer1;
    [SerializeField] GameObject WinPlayer2;
   

    Visualizacion Viz = new Visualizacion();

    //---------------------------------//
    void Start()
    {

        if (!GameManager.Instancia.twoPlayers)
        {
            secondPlayerImage.enabled = false;
            secondPlayerText.enabled = false;
        }


        SetDinero();
    }


    void SetDinero()
    {
        if (DatosPartida.LadoGanadaor == DatosPartida.Lados.Izq)//izquierda
        {
            firstPlayerText.text = "$" + Viz.PrepararNumeros(DatosPartida.PtsGanador);
            WinPlayer1.SetActive(true);
        }
        else
        {
            secondPlayerText.text = "$" + Viz.PrepararNumeros(DatosPartida.PtsPerdedor);
            WinPlayer2.SetActive(true);
        }

    }

}

