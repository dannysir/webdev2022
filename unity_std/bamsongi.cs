using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bamsongi : MonoBehaviour
{
    float time = 0.0f;
    bool is_collided = false;
    float record = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        record = 0.0f;
        Time.timeScale = 1;
        is_collided = false;
        Destroy(gameObject, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(is_collided == true)
        {
            Time.timeScale = 0;
        }
        if (Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);

        }
        if (Input.GetMouseButtonDown(1))
        {
            SceneManager.LoadScene("scene2", LoadSceneMode.Single);

        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "ThirdPersonController")
        {
            this.is_collided = true;
            other.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            record = time;
        }
    }
    private void OnGUI()
    {

        // is_collided 가 true 이면 Success 메시지 출력
        if (is_collided)
            GUI.Label(new Rect(Screen.width / 2 - 30, 80, 100, 20), "Hit!!!");



    }
}
