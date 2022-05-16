using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    [SerializeField] ScriptableObject_test scriptableObject;  
    public GameObject[] obj;
    // Start is called before the first frame update
    void Start()
    {
        scriptableObject.createFloorCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(scriptableObject.createNewFloor)
        {
            CreateNewFloor();
        }
    }

    void CreateNewFloor()
    {
        scriptableObject.createFloorCount++;
        scriptableObject.limidSpeed += 5f;

        int randomNum = Random.RandomRange(0, obj.Length);


        // プレハブを元にオブジェクトを生成する
        GameObject instance = (GameObject)Instantiate(obj[randomNum],new Vector3(0.0f, 0.0f, 250.0f * scriptableObject.createFloorCount),Quaternion.identity);
        scriptableObject.createNewFloor = false;
    }
}
