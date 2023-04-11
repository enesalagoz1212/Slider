using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SliderController : MonoBehaviour
{
    
    public Slider slider;
    void Start()
    {
        slider.value = 0;
        slider.maxValue = 13;
    }
    public void Arttir()
    {
        slider.value++;
    }
    public void Azalt()
    {
        slider.value--;
    }

}
