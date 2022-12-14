using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
        //回転速度
        float rotSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {

        void Start()
        {
            //フレームレートを60に固定する
            Application.targetFrameRate = 60;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //マウスが押されたら回転速度を設定する
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }

        //回転速度分、ルーレットを回転させる
        transform.Rotate(0, 0, this.rotSpeed);

        // ルーレットを減速させる
        this.rotSpeed *= 0.98f;
    }
}
