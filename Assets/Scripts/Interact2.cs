using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact2 : MonoBehaviour
{
    public GameObject Coins;
    public GameObject PressE, FisherGreeting, FisherBroke, FisherPaid;
    public GameObject FishBucket;

    public bool InArea, BuyFisher, NoFish;

    // Start is called before the first frame update
    void Start()
    {
        FisherGreeting.SetActive(false);
        FisherBroke.SetActive(false);
        FisherPaid.SetActive(false);
        FishBucket.SetActive(false);

        InArea = false;
        BuyFisher = false;
        NoFish = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey("e") && InArea && NoFish)
        {
            PressE.SetActive(false);
            FisherGreeting.SetActive(true);
            BuyFisher = true;
        }

        if(Input.GetKey("q") && InArea && BuyFisher)
        {
            FisherGreeting.SetActive(false);
            FisherBroke.SetActive(true);
            BuyFisher = false;
        }
        
        if (Input.GetKey("q") && InArea && Coins.activeSelf)
        {
            FisherBroke.SetActive(false);
            FisherPaid.SetActive(true);
            FishBucket.SetActive(true);
            BuyFisher = false;
            NoFish = false;
        }

        if(FishBucket.activeSelf && InArea)
        {
            PressE.SetActive(false);
            FisherPaid.SetActive(true);
            BuyFisher = false;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        PressE.SetActive(true);
        InArea = true;
    }

    private void OnTriggerExit(Collider other)
    {
        PressE.SetActive(false);
        FisherBroke.SetActive(false);
        FisherGreeting.SetActive(false);
        FisherPaid.SetActive(false);
        InArea = false;
    }
}
