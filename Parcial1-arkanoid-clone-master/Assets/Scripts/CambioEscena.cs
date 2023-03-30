using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{

    [SerializeField] private int escena;
    [SerializeField] private int tiempo;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("WaitTime",tiempo);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
           int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
           if (SceneManager.sceneCountInBuildSettings > nextSceneIndex)
           {
            SceneManager.LoadScene(escena);
           }
        }
    }

    public void WaitTime()
    {
           int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
           if (SceneManager.sceneCountInBuildSettings > nextSceneIndex)
           {
            SceneManager.LoadScene(escena);
           }
    }
}