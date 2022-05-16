using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ScriptableObject_test : ScriptableObject
{
    //ゲームが始まっているかどうか   
    public bool isGameStart;
    //速度上限
    public float limidSpeed;
    //フロアを追加するかどうかのフラグ
    public bool createNewFloor;
    //フロアを追加した回数
    public int createFloorCount;

}
