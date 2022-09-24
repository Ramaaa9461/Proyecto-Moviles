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
    SceneController sceneController;

    //---------------------------------//
    private void Awake()
    {
        sceneController = GameObject.Find("Scene_Controller").GetComponent<SceneController>();
    }

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
            secondPlayerText.text = "$" + Viz.PrepararNumeros(DatosPartida.PtsPerdedor);
            WinPlayer1.SetActive(true);
        }
        else
        {
            secondPlayerText.text = "$" + Viz.PrepararNumeros(DatosPartida.PtsGanador);
            firstPlayerText.text = "$" + Viz.PrepararNumeros(DatosPartida.PtsPerdedor);
            WinPlayer2.SetActive(true);
        }




    }

    public void BackToMenu()
    {
        sceneController.goToMenu();
    }

}

