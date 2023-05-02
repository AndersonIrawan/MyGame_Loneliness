using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoPoster : MonoBehaviour
{
    public GameObject ScdPoster, TrdPoster, BakeryPost;
    public GameObject PastePoster, ScdMarker, TrdMarker;
    public GameObject ScdBroch;

    public bool InArea, PosterReady;

    // Start is called before the first frame update
    void Start()
    {
        TrdMarker.SetActive(false);
        ScdBroch.SetActive(false);

        InArea = false;
        PosterReady = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ScdPoster.activeSelf)
        {
            PosterReady = true;
        }


        if (Input.GetKey("e") && InArea && PosterReady)
        {
            ScdPoster.SetActive(false);
            TrdPoster.SetActive(true);

            ScdBroch.SetActive(true);

            ScdMarker.SetActive(false);
            TrdMarker.SetActive(true);

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
