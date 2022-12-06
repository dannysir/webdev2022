using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_ctrl : MonoBehaviour
{
    public int itemCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
/*        if (Input.GetKey(KeyCode.UpArrow))
            this.transform.Translate(Vector3.forward * 5.0f * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            this.transform.Translate(Vector3.back * 5.0f * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            this.transform.Translate(Vector3.left * 5.0f * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            this.transform.Translate(Vector3.right * 5.0f * Time.deltaTime);*/
        if (Input.GetButtonDown("Jump"))
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
        }

    }

    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        this.GetComponent<Rigidbody>().AddForce(new Vector3(h * 5.0f * Time.deltaTime, 0, v * 5.0f * Time.deltaTime), ForceMode.Impulse);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Item")
        {

            itemCount++;
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.name == "BigItem")
        {

            itemCount += 10;
            other.gameObject.SetActive(false);
        }
    }
    void OnGUI()
    {
        // 시간과 점프력 표시
        GUI.Label(new Rect(81, Screen.height - 60, 128, 32),"score : ");
        GUI.Label(new Rect(130, Screen.height - 60, 128, 32), itemCount.ToString());

    }
}
