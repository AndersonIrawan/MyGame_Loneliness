using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Child : MonoBehaviour
{
    public GameObject PressE, ChildTalk1, ChildTalk2, ChildThank, Cat;
    public GameObject ChildDone;

    public bool InArea, HelpChild, NoCat, CatDone;


    // Start is called before the first frame update
    void Start()
    {
        ChildTalk1.SetActive(false);
        ChildTalk2.SetActive(false);
        ChildThank.SetActive(false);
        ChildDone.SetActive(false);
        Cat.SetActive(false);

        InArea = false;
        HelpChild = false;
        NoCat = true;
        CatDone = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("e") && InArea && NoCat)
        {
            ChildTalk1.SetActive(true);
            PressE.SetActive(false);
            HelpChild = true;
        }
        if(Input.GetKey("q") && InArea && HelpChild)
        {
            ChildTalk1.SetActive(false);
            ChildTalk2.SetActive(true);
            HelpChild = false;
            NoCat = false;
        }

        if(Input.GetKey("q") && InArea && ChildDone.activeSelf)
        {
            ChildTalk2.SetActive(false);
            ChildThank.SetActive(true);
            ChildDone.SetActive(false);
            Cat.SetActive(false);
            HelpChild = false;
            NoCat = false;
            CatDone = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(CatDone)
        {
            PressE.SetActive(false);
            HelpChild = false;
            NoCat = false;
        }
        else
        {
            PressE.SetActive(true);
        }

        InArea = true;
    }
    private void OnTriggerExit(Collider other)
    {
        PressE.SetActive(false);
        ChildTalk1.SetActive(false);
        ChildTalk2.SetActive(false);
        ChildThank.SetActive(false);
        InArea = false;

        if (Cat.activeSelf)
        {
            NoCat = false;
        }
        else
        {
            NoCat = true;
        }
    }
}
