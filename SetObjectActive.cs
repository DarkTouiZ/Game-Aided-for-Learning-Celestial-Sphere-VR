using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObjectActive : MonoBehaviour
{
    public GameObject targetObject;
    public GameObject targetPanel;

    public void ActiveObject()
    {
        targetObject.SetActive(true);
    }

    public void DeactiveObject()
    {
        targetObject.SetActive(false);
    }

    public void ActivePanel()
    {
        targetPanel.SetActive(true);
    }
    public void DeactivePanel()
    {
        targetPanel.SetActive(false);
    }
}
