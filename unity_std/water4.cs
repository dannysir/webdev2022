using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class water4 : MonoBehaviour
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
        if (collision.gameObject.name == "wall1")
        {
            SceneManager.LoadScene("scene4", LoadSceneMode.Single);
        }
        if (collision.gameObject.name == "goal")
        {
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);

        }
    }
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("scene4", LoadSceneMode.Single);

    }
}
