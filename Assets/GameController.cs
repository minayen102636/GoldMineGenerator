using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject goldPrefab;

    void Start()
    {
        Question1();
        //Question2();
        //Question3();
    }


    void Update()
    {

    }

    void Question1()
    {
        for (int i = 0; i < 7; i++)
        {
            float x1;
            float y1;

            x1 = -10.5f + i * 3.5f;
            y1 = -10.5f + i * 3.5f;

            Vector3 position = new Vector3(x1, y1, 0);
            Instantiate(goldPrefab, position, Quaternion.identity);

            float x2;
            float y2;

            x2 = -10.5f + i * 3.5f;
            y2 = 10.5f - i * 3.5f;

            Vector3 position2 = new Vector3(x2, y2, 0);
            Instantiate(goldPrefab, position2, Quaternion.identity);
        }

    }


    void Question2()
    {
        for (int i = 0; i < 3; i++)
        {
            float x;

            x = -7 + i * 7;

            Vector3 position1 = new Vector3(x, 7, 0);
            Vector3 position2 = new Vector3(x, 0, 0);
            Vector3 position3 = new Vector3(x, -7, 0);
            Instantiate(goldPrefab, position1, Quaternion.identity);
            Instantiate(goldPrefab, position2, Quaternion.identity);
            Instantiate(goldPrefab, position3, Quaternion.identity);
        }
    }

    void Question3()
    {
        float x ;
        int i = 0;

        while (i < 3)
        {
            x = -7 + i * 7;
            i = i+1;

            Vector3 position1 = new Vector3(x, 7, 0);
            Vector3 position2 = new Vector3(x, 0, 0);
            Vector3 position3 = new Vector3(x, -7, 0);
            Instantiate(goldPrefab, position1, Quaternion.identity);
            Instantiate(goldPrefab, position2, Quaternion.identity);
            Instantiate(goldPrefab, position3, Quaternion.identity);

        }


    }
}
