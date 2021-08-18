using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HeightLevel : MonoBehaviour
{
    private Material material;
    private Color previousColor;
    public Slider _slider;
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        
        material = GetComponent<MeshRenderer>().sharedMaterial;
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //material.SetFloat("_Fill", _slider.value);
        //Debug.Log(_slider.value);
        pos.y = -2.7f + _slider.value;
        transform.position = pos;
    }
}