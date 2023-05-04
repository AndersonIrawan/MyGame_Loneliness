using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisherman : MonoBehaviour
{
    public GameObject PressE, Fisherman1, Fisherman2, FishBucket, WifeHappy;

    public bool InArea, Talking, Chat;

    // Start is called before the first frame update
    void Start()
    {
        Fisherman1.SetActive(false);
        Fisherman2.SetActive(false);

        InArea = false;
        Talking = false;
        Chat = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("e") && InArea && Chat && FishBucket.activeSelf)
        {
            PressE.SetActive(false);
            Fisherman1.SetActive(true);
            Talking = true;
        }

        if(Input.GetKey("q") && InArea && Talking && FishBucket.activeSelf)
        {
            Fisherman2.SetActive(true);
            Fisherman1.SetActive(false);
            WifeHappy.SetActive(true);
            Talking = false;
            Chat = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (FishBucket.activeSelf && Chat)
        {
            PressE.SetActive(true);
            InArea = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        PressE.SetActive(false);
        Fisherman1.SetActive(false);
        Fisherman2.SetActive(false);
        InArea = false;
    }
}
