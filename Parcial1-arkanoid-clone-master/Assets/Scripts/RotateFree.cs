using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateFree : MonoBehaviour
{

    [SerializeField] public int xrot;
    [SerializeField] public int yrot;
    [SerializeField] public int zrot;


    public float speed = 100;
    
    public GameObject objeto;
    
    void Update()
    {
          objeto.transform.Rotate((speed * Time.deltaTime)*xrot, (speed * Time.deltaTime)*yrot, (speed * Time.deltaTime)*zrot);
    }
}
