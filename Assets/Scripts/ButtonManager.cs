using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject OldPlace;
    public GameObject Camara;

    public void ChangePlace(GameObject NewPlace)
    {
        NewPlace.SetActive(true);
        OldPlace.SetActive(false);
        Camara.transform.position = NewPlace.transform.position;
    }
}
