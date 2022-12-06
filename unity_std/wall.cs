using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wall : MonoBehaviour
{
    public float speed = -5;
    // Start is called before the first frame update
    void Start()
    {
        //스피드를 랜덤하게 지정
        speed = Random.Range(-6.0f, -4.0f);
        Destroy(gameObject, 5.0f);
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);

    }

}
