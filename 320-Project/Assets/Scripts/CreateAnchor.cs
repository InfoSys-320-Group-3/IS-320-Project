using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAnchor : MonoBehaviour
{
    // Variables
    Camera mainCamera;
    public GameObject hazard;

    void Start()
    {
        mainCamera = Camera.main;        
    }

    public void CreateHazard()
    {
        Vector3 pos = new Vector3(mainCamera.transform.position.x, 1f, mainCamera.transform.position.z);
        GameObject.Instantiate(hazard, pos, Quaternion.identity);
    }

}
