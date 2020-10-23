using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindAnchor : MonoBehaviour
{
    public GameObject flesh;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        flesh.transform.position = Camera.main.ScreenToWorldPoint(new Vector3( Screen.width/2, Screen.height/2,1));
    }

    // Update is called once per frame
    void Update()
    {
        var dir = Camera.main.WorldToScreenPoint(target.transform.position) - 
        Camera.main.WorldToScreenPoint(flesh.transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        flesh.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

}