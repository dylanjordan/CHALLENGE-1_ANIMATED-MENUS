using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public GameObject currentMenu;
    public GameObject nextMenu;
    public Animator animator;
    public float timeForTransition;

    public bool first = false;




    public void Selected()
    {
        animator.SetBool("pressed", true);
    }
    public void SwitchMenu()
    {
        StartCoroutine(SwitchToNextMenu());
    }

    IEnumerator SwitchToNextMenu()
    {
        yield return new WaitForSeconds(timeForTransition);
        animator.SetBool("pressed", false);
        currentMenu.SetActive(false);
        nextMenu.SetActive(true);
    }
    private void Start()
    {
        StartCoroutine(Trans());
    }
    private void Update()
    {
        if (gameObject.activeInHierarchy && first)
        {
            StartCoroutine(Trans());
        }
    }

    IEnumerator Trans()
    {
        animator.SetBool("Transition", true);
        yield return new WaitForSeconds(1);
        animator.SetBool("Transition", false);
        first = false;
    }

    public void MakeFirstTrue()
    {
        first = true;
    }
}
