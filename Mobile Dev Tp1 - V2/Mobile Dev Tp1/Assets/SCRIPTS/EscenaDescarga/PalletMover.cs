using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalletMover : ManejoPallets 
{
    public string playerID = "-1";

    public ManejoPallets Desde, Hasta;
    bool segundoCompleto = false;

    private void Update()
    {
        if (!Tenencia() && Desde.Tenencia() && Left())
        {
            PrimerPaso();
        }
        if (Tenencia() && Down())
        {
            SegundoPaso();
        }
        if (segundoCompleto && Tenencia() && Right())
        {
            TercerPaso();
        }
    }

    bool Down()
    {
        return InputManager.Instance.GetAxis("Vertical" + playerID) > 0.5f;
    }
    bool Up()
    {
        return InputManager.Instance.GetAxis("Vertical" + playerID) < -0.5f;
    }
    bool Left()
    {
        return InputManager.Instance.GetAxis("Horizontal" + playerID) < -0.5f;
    }
    bool Right()
    {
        return InputManager.Instance.GetAxis("Horizontal" + playerID) > 0.5f;
    }

    void PrimerPaso()
    {
        Desde.Dar(this);
        segundoCompleto = false;
    }
    void SegundoPaso()
    {
        base.Pallets[0].transform.position = transform.position;
        segundoCompleto = true;
    }
    void TercerPaso()
    {
        Dar(Hasta);
        segundoCompleto = false;
    }

    public override void Dar(ManejoPallets receptor)
    {
        if (Tenencia())
        {
            if (receptor.Recibir(Pallets[0]))
            {
                Pallets.RemoveAt(0);
            }
        }
    }
    public override bool Recibir(Pallet pallet)
    {
        if (!Tenencia())
        {
            pallet.Portador = this.gameObject;
            base.Recibir(pallet);
            return true;
        }
        else
            return false;
    }
}
