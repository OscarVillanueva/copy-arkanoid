using UnityEngine;
using System;

public class HardBlock : Block
{
    public HardBlock() : base(Guid.NewGuid().ToString(), 4, false, 2,Color.green)
    {
    }

    public override void HandleDestroy()
    {
        base.HandleDestroy();
        // TODO: cuando un bloque duro la bola aumenta de velocidad en 1%
        //Debug.Log("Se destruyo un bloque duro");
    }
}