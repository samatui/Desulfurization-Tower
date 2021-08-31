using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selction : MonoBehaviour
{
    [SerializeField] private GameObject Text;
    private bool flag = false;

    // Update is called once per frame
    /*
     void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            //Text.enable();
            //Text.SetActive(true);
        }
        else
        {   
            //Text.SetActive(false);
        }
           
    }*/

    void OnMouseDown()
    {
        if (!flag){
            Text.SetActive(true);
        }
        else{
            Text.SetActive(false);
        }
        flag = !flag;
    }
}
