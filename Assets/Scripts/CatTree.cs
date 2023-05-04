using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatTree : MonoBehaviour
{
    public GameObject Cat, CatRustle, CatBait, FishBucket, ChildDone;

    public bool InArea;
    
    // Start is called before the first frame update
    void Start()
    {
        CatRustle.SetActive(false);
        CatBait.SetActive(false);
        Cat.SetActive(false);

        InArea = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("q") && InArea && CatBait.activeSelf)
        {
            Cat.SetActive(true);
            CatBait.SetActive(false);
            ChildDone.SetActive(true);
        }

        if(InArea && Cat.activeSelf)
        {
            CatRustle.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (FishBucket.activeSelf)
        {
            CatRustle.SetActive(false);
            CatBait.SetActive(true);
        }
        else
        {
            CatRustle.SetActive(true);
        }
        InArea = true;

    }

    private void OnTriggerExit(Collider other)
    {
        CatRustle.SetActive(false);
        CatBait.SetActive(false);
        InArea = false;
    }
}
