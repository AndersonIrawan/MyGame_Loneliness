using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnePoster : MonoBehaviour
{
    public GameObject TrdPoster, TrdMarker;
    public GameObject PastePoster, BakeryPost;
    public GameObject BakerDone;
    public GameObject TrdBroch;

    public bool InArea, PosterReady;


    // Start is called before the first frame update
    void Start()
    {
        TrdBroch.SetActive(false);

        InArea = false;
        PosterReady = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (BakeryPost.activeSelf)
        {
            PosterReady = true;
        }

        if (Input.GetKey("e") && InArea)
        {
            TrdPoster.SetActive(false);
            TrdMarker.SetActive(false);

            TrdBroch.SetActive(true);

            BakeryPost.SetActive(false);
            BakerDone.SetActive(true);

            PosterReady = false;
            PastePoster.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (PosterReady)
        {
            PastePoster.SetActive(true);
        }

        InArea = true;
    }

    private void OnTriggerExit(Collider other)
    {
        PastePoster.SetActive(false);
        InArea = false;
    }
}
