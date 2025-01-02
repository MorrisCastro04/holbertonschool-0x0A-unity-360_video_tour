using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBotton : MonoBehaviour
{
    public GameObject Text;
    bool isTextActive = false;
    public void OnClick()
    {
        if (isTextActive)
        {
            Text.SetActive(false);
            isTextActive = false;
        }
        else
        {
            Text.SetActive(true);
            isTextActive = true;
        }
    }
}
