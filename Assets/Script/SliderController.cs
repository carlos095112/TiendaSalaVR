using UnityEngine;
using System.Collections;   
using System.Collections.Generic;   
public class SliderController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void publicSliderFunction(float value)
    {
        Debug.Log("Slider Value: " + value);
    }
}
