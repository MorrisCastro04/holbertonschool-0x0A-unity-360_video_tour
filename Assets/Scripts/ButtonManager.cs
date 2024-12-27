using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject OldPlace;
    public GameObject Camara;
    public Animator anim;

    public void ChangePlace(GameObject NewPlace)
    {
        StartCoroutine(ChangePlaceFade(NewPlace));
    }

    IEnumerator ChangePlaceFade(GameObject NewPlace)
    {
        anim.SetTrigger("StartFade");
        yield return new WaitForSeconds(1.5f);
        NewPlace.SetActive(true);
        OldPlace.SetActive(false);
        Camara.transform.position = NewPlace.transform.position;
        anim.SetTrigger("Fade");
    }
}
