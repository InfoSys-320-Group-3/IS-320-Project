using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAnchor : MonoBehaviour
{
    // Variables
    Camera mainCamera;
    public GameObject hazard;
    static public List<GameObject> spawnedhazards;

    void Start()
    {
        mainCamera = Camera.main;
        spawnedhazards = new List<GameObject>();        
    }

    public void CreateHazard()
    {
        Vector3 pos = new Vector3(mainCamera.transform.position.x, 1f, mainCamera.transform.position.z);
        GameObject newHazard = Instantiate(hazard, pos, Quaternion.identity);
        spawnedhazards.Add(newHazard);
    }

    public void RemoveHazard()
    {
        GameObject toRemove = spawnedhazards[0];
        spawnedhazards.Remove(toRemove);
        Destroy(toRemove);
    }

}
