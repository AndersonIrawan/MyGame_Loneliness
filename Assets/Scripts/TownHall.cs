using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownHall : MonoBehaviour
{

    public GameObject TownHallComment, MayorThank, PressE, Sheriff;

    public GameObject BakerHappy, WifeHappy, ChildHappy, MayorAsk;

    public GameObject BlackScreen, GameFinished, Terrain;

    public bool InArea, Mayor;

    // Start is called before the first frame update
    void Start()
    {
        TownHallComment.SetActive(false);

        MayorThank.SetActive(false);
        MayorAsk.SetActive(false);
        BlackScreen.SetActive(false);
        GameFinished.SetActive(false);
        Sheriff.SetActive(false);

        InArea = false;
        Mayor = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(BakerHappy.activeSelf && WifeHappy.activeSelf && ChildHappy.activeSelf)
        {
            MayorThank.SetActive(true);
            Sheriff.SetActive(true);
        }

        if(InArea && MayorThank.activeSelf && Mayor)
        {
            PressE.SetActive(true);

            Mayor = false;        
        }

        if(Input.GetKey("e") && InArea && MayorThank.activeSelf)
        {
            PressE.SetActive(false);
            MayorAsk.SetActive(true);
        }

        if(Input.GetKey("q") && InArea && MayorAsk)
        {
            BlackScreen.SetActive(true);
            GameFinished.SetActive(true);
            Terrain.SetActive(false);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        InArea = true;
        if(MayorThank.activeSelf)
        {
            PressE.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        InArea = false;
        PressE.SetActive(false);
        MayorAsk.SetActive(false);

    }
}
