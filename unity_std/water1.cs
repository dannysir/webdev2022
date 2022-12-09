using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class water1 : MonoBehaviour
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
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);

    }
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);

    }
}
