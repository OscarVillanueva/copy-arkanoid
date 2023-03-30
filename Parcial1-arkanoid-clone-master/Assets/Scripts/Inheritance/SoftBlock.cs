using UnityEngine;
using System;

public class SoftBlock : Block
{
    public SoftBlock(): base(Guid.NewGuid().ToString(), 1, false,0, Color.gray) { 
    }

    public override void HandleDestroy()
    {
        base.HandleDestroy();
        //Debug.Log("Bloque suave destruido");
        // TODO: Al acumular cierta cantidad de bloques activar que ciertos bloques desaparezcan o se muevan
    }
}
