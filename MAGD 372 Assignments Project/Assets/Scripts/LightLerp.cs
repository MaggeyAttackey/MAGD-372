using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightLerp : MonoBehaviour
{

    public float smooth = 2;
    private Color newColor;
    // Start is called before the first frame update
    void Start()
    {
        newColor = GetComponent<Light>().color;
    }

    void colorChanging()
    {
        Color colorA = Color.red;
        Color colorB = Color.green;
        if(Input.GetKeyDown(KeyCode.Z))
        {
            newColor = colorA;
        }
        if(Input.GetKeyDown(KeyCode.X))
        {
            newColor = colorB;
        }

        GetComponent<Light>().color = Color.Lerp(GetComponent<Light>().color, newColor, Time.deltaTime * smooth);
    }

    // Update is called once per frame
    void Update()
    {
        colorChanging();
    }


}
