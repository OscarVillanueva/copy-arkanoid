using System;
using UnityEngine;

public class PowerBlock : Block
{
    public PowerBlock() : base(Guid.NewGuid().ToString(), 3, true, 1, Color.yellow)
    {
    }

    // TODO: Definir una funcion para pedir un gameobject la funcion de game object
    // Esta funcion debe ser llamada antes del handleDestroy

    public override void HandleDestroy()
    {
        base.HandleDestroy();
        //Debug.Log("Bloque power destruido");
        // TODO: decirle al manejador de power ups que debe instanciar un power up
    }
}
