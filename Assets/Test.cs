using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Test : MonoBehaviour

{


    // Start is called before the first frame update
    void Start()
    {
        // Vecterクラス練習
        Vector2 playerPos = new Vector2(3.0f, 4.0f);
        playerPos.x += 8.0f;
        playerPos.y += 5.0f;
        Debug.Log(playerPos);


        //   if practice
        //int i = 1;
        //if ( i == 1)
        //{
        //    Debug.Log("Hello world");
        //}

        //配列の練習
        //int[] array = new int[5];

        //array[0] = 2;
        //array[1] = 10;
        //array[2] = 5;
        //array[3] = 15;
        //array[4] = 3;

        //for (int i = 0; i < 5; i++)
        //{
        //    Debug.Log(array[i]);
        //}


    }

    // Update is called once per frame
    void Update()
    {
         
    }
}
           