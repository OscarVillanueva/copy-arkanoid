using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWheel : MonoBehaviour
{
    public float speed = 100;
    
    public GameObject objeto;
    
    void Update()
    {
          objeto.transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
