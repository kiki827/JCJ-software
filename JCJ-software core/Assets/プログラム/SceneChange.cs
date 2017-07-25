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
		if (Input.GetButtonDown ("Submit")) {
			Application.LoadLevel ("3Dball");
		} if (Input.GetKeyDown (KeyCode.K))
			
		{
			Application.LoadLevel("kisojikkenD");
		}
		if (Input.GetKeyDown (KeyCode.G))

		{
			Application.LoadLevel("game1");
		}
		if (Input.GetKeyDown (KeyCode.Z))

		{
			Application.LoadLevel("01");
		}
    }
}