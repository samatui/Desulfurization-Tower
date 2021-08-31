using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class OnClick : MonoBehaviour
{
    public Button yourButton;
    [SerializeField] private GameObject target;
    private bool flag = false;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if (!flag)
        {
            target.SetActive(true);
        }
        else
        {
            target.SetActive(false);
        }
        flag = !flag;
        //Debug.Log("You have clicked the button!");
    }
}
