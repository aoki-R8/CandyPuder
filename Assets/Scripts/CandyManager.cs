using System.Security.Cryptography;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class CandyManager : MonoBehaviour
{
    //移動量
    private float movespeed = 1f;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = this.transform.position + new Vector3(movespeed, 0, 0) * Time.deltaTime;
        //1秒間に右方向へ1f動かしたい（x+方向へ加算する）
        //代入先（vector3:x,y,z）

        if (this.transform.position.x > 5)
        {
            movespeed = -1 * movespeed;
        }
        if (this.transform.position.x < -5)
        {
            movespeed = -1 * movespeed;
        }

    }
}
