using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling_bam : MonoBehaviour
{
    public GameObject pf_wall;
    public float interval;
    public float timer = 0;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            // 벽을 생성 할때 y 축을 랜덤하게 지정하여 생성
            Instantiate(pf_wall, transform.position = new Vector3(Random.Range(-5.0f, 5.0f), 10, Random.Range(4.0f, 10.0f)), transform.rotation);
            // 간격을 랜덤하게 한다
            interval = 0.1f;
            yield return new WaitForSeconds(interval);
        }
    }


    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if(timer >= 5)
        {
            interval = 0.0f;
            Debug.Log("SanE");
        }

    }
    void OnGUI()
    {
        // 시간과 점프력 표시
        GUI.Label(new Rect(81, Screen.height - 60, 128, 32), timer.ToString());

    }
}
