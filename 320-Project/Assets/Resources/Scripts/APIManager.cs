using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using TMPro;
using UnityEngine;

public class APIManager : MonoBehaviour
{
    public GameObject Prefab;
    public string URL;
    static public List<GameObject> spawnedhazards;
    
    // Start is called before the first frame update
    private void Start()
    {
        Request();
    }

    public void Request()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string jsonResponse = reader.ReadToEnd();
        JArray encodedResponse = JArray.Parse(jsonResponse);

        float displacement = 0f;
        foreach (var item in encodedResponse)
        {
            displacement = displacement + 0.5f;
            // Excuse my horrible naming of variables. I wrote this pretty close to the tutorial as a last minute "Oh what if we do this...."
            Debug.Log(item.ToString());
            GameObject thisObject = GameObject.Instantiate(Prefab, new Vector3(-1f, displacement, 3f), Quaternion.identity);
            InstanceDetails instanceDetails = thisObject.GetComponentInChildren<InstanceDetails>();
            instanceDetails.details = item;
            instanceDetails.SetText("Name");
        }
    }
}