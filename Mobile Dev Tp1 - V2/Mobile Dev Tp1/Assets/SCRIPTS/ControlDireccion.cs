using UnityEngine;

public class ControlDireccion : MonoBehaviour
{
    public enum TipoInput { AWSD, Arrows }
    public TipoInput InputAct = TipoInput.AWSD;

    float Giro = 0;

    public bool Habilitado = true;
    CarController carController;
    int playerID = -1;
    string inputName = "Horizontal";


    void Start()
    {
        carController = GetComponent<CarController>();
        playerID = GetComponent<Player>().IdPlayer;

        inputName += playerID;
    }

    void Update()
    {
        Giro = InputManager.Instance.GetAxis(inputName);

        carController.SetGiro(Giro);
    }

    public float GetGiro()
    {
        return Giro;
    }

}
