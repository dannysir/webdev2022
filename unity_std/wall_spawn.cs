using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_spawn : MonoBehaviour
{
    public GameObject pf_wall;
    public float interval;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            // ���� ���� �Ҷ� y ���� �����ϰ� �����Ͽ� ����
            Instantiate(pf_wall, transform.position += new Vector3(Random.Range(-2.0f, 2.0f), 0.0f, 0), transform.rotation);
            // ������ �����ϰ� �Ѵ�
            interval = Random.Range(2.0f, 2.5f);
            yield return new WaitForSeconds(interval);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
