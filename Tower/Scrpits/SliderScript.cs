using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class SliderScript : MonoBehaviour
{
    private Material material;
    public float Fill_value;

    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI _sliderText;
    

    // Start is called before the first frame update
    void Start()
    {
        /*
        _slider.onValueChanged.AddListener((v) => {
            _sliderText.text = v.ToString("0.00");
        });
        */

    }

    // Update is called once per frame
    void Update()
    {
        if (_slider.value <=1 && _slider.value >= -1)
        {
            Fill_value = _slider.value;
        }
        
    }

}
