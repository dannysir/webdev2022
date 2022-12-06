using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class water : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("scene3", LoadSceneMode.Single);

    }
    void OnTriggerEnter(Collider other)
    {
        if(other.name == "FPSController")
        {
            SceneManager.LoadScene("scene3", LoadSceneMode.Single);

        }
    }
}
