using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InstanceDetails : MonoBehaviour
{
    // Putting this here so you have some basic outline code you can use to do other stuff with the data you get. Naming convention is vague because I'm not sure what you'll use it for.
    public TextMeshPro tmp;

    public JToken details;

    public void SetText(string jsonKey)
    {
        tmp.text = details[jsonKey].ToString();
        /*
        Note that the following would work as well

    details["Name"]

         */
    }

    public void ShowAllDetails()
    {
        tmp.text = details.ToString();
    }
}