using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreePoster : MonoBehaviour
{
    public GameObject FstPoster, ScdPoster, BakeryPost;
    public GameObject PastePoster, FstMarker, ScdMarker;
    public GameObject FstBroch;

    public bool InArea, PosterReady;

    // Start is called before the first frame update
    void Start()
    {
        PastePoster.SetActive(false);
        FstBroch.SetActive(false);
        ScdMarker.SetActive(false);

        InArea = false;
        PosterReady = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (FstPoster.activeSelf)
        {
            PosterReady = true;
        }

        if(Input.GetKey("e") && InArea && PosterReady)
        {
            FstPoster.SetActive(false);
            ScdPoster.SetActive(true);

            FstBroch.SetActive(true);

            FstMarker.SetActive(false);
            ScdMarker.SetActive(true);

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
