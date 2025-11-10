using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mudarCamera : MonoBehaviour
{
    public Camera Menu;
    public Camera cameraJogo;

    public void TrocarParaCameraJogo()
    {
        Menu.gameObject.SetActive(false);
        cameraJogo.gameObject.SetActive(true);
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
