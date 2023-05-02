using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownHall : MonoBehaviour
{

    public GameObject TownHallComment;

    // Start is called before the first frame update
    void Start()
    {
        TownHallComment = GameObject.Find("TownHallComment");
        TownHallComment.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        TownHallComment.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        TownHallComment.SetActive(false);
    }
}
