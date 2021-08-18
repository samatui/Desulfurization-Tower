using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HeightControl : MonoBehaviour
{
    private Material material;
    private Color previousColor;
    public Slider _slider;


    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<MeshRenderer>().sharedMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(typeof(_slider.value));
        material.SetFloat("_Fill", _slider.value);
        Debug.Log(_slider.value);
    }
}
