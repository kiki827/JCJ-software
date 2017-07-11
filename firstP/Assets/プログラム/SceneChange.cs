using UnityEngine;
using System.Collections;

public class SceneChange : MonoBehaviour
{

    //ここは何も書かない
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Submit、つまりEnterキーでシーンを変更
        if (Input.GetButtonDown("Submit"))
        {
            Application.LoadLevel("3Dball");
        }
    }
}