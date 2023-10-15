using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public GameObject currentMenu;
    public GameObject nextMenu;
    public float timeForTransition;
    public bool playScene = false;

    
    public void SwitchMenu()
    {
        StartCoroutine(SwitchToNextMenu());
    }

    IEnumerator SwitchToNextMenu()
    {
        yield return new WaitForSeconds(timeForTransition);
        currentMenu.SetActive(false);
        nextMenu.SetActive(true);
    }
}
