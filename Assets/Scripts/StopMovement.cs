using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMovement : MonoBehaviour
{

    public GameObject BlackScreen;

    public Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StopPlayer()
    {
        if (BlackScreen.activeSelf)
        {
            playerRb.isKinematic = true;
        }
    }
}
