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
            // ���� ���� �Ҷ� y ���� �����ϰ� �����Ͽ� ����
            Instantiate(pf_wall, transform.position = new Vector3(Random.Range(-5.0f, 5.0f), 10, Random.Range(4.0f, 10.0f)), transform.rotation);
            // ������ �����ϰ� �Ѵ�
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
        // �ð��� ������ ǥ��
        GUI.Label(new Rect(81, Screen.height - 60, 128, 32), timer.ToString());

    }
}
