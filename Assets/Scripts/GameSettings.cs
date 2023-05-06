using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSettings : MonoBehaviour
{
    public GameObject BlackScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("r") && BlackScreen.activeSelf)
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
