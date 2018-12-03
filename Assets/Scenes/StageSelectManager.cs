using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelectManager : MonoBehaviour
{

    GameObject clickedGameObject;

    void Start()
    {
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            clickedGameObject = null;

            //指定の位置から発射されるRayを作成
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Rayとオブジェクトの接触を調べる
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            //接触してたらオブジェクトを小さくする
            if (hit2d)
            {
                clickedGameObject = hit2d.transform.gameObject;
                Debug.Log(clickedGameObject);
            }
        }
    }

}
