using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact1 : MonoBehaviour
{
    public GameObject PressE, BakeryGreeting, BakeryPost;
    public GameObject FstPoster, ScdPoster, TrdPoster, FstMarker;
    public GameObject BakerDone, BakerReward, Coins, BakeryWork;

    public GameObject BakerHappy;

    public bool GameStart;

    public bool InArea, QuestBakery, BakeryQuestActive;

    
    // Start is called before the first frame update
    void Start()
    {
        PressE.SetActive(false); //First Interaction with baker
        BakeryGreeting.SetActive(false); //Talking with baker
        BakeryPost.SetActive(false); //Accepting quest from baker

        FstPoster.SetActive(false);
        ScdPoster.SetActive(false);
        TrdPoster.SetActive(false);

        FstMarker.SetActive(false);

        BakeryWork.SetActive(false);

        BakerDone.SetActive(false);
        BakerReward.SetActive(false);
        Coins.SetActive(false);

        BakerHappy.SetActive(false);

        InArea = false;
        QuestBakery = false;

        GameStart = true;

        BakeryQuestActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("e") && InArea && GameStart)
        {
            PressE.SetActive(false);
            BakeryGreeting.SetActive(true);
            QuestBakery = true;
        };

        if (Input.GetKey("q") && InArea && QuestBakery)
        {
            BakeryGreeting.SetActive(false);
            BakeryPost.SetActive(true);
            FstPoster.SetActive(true);
            FstMarker.SetActive(true);
            QuestBakery = false;
            GameStart = false;

            BakeryQuestActive = true;
        };

        if (InArea && BakeryQuestActive)
        {
            PressE.SetActive(false);
            BakeryGreeting.SetActive(false);
        }

        if (InArea && BakerDone.activeSelf)
        {
            BakerReward.SetActive(true);
            PressE.SetActive(false);

            BakeryQuestActive = false;
            QuestBakery = false;

        }

        if (Input.GetKey("q") && InArea && BakerReward.activeSelf)
        {
            BakerReward.SetActive(false);
            BakerDone.SetActive(false);
            PressE.SetActive(false);
            Coins.SetActive(true);
        }

        if (Coins.activeSelf && InArea)
        {
            PressE.SetActive(false);
            BakeryWork.SetActive(true);
            BakerHappy.SetActive(true);
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
        BakeryGreeting.SetActive(false);
        BakerReward.SetActive(false);
        BakeryWork.SetActive(false);
        InArea = false;
    }
}
