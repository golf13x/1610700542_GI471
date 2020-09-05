using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class spawnerMa : MonoBehaviour
{
    public List<spawner> spawnerList = new List<spawner>();
    public static spawnerMa instance;
    public void Start()
    {
        instance = this;
        Init();
    }
    private void Init()
    {
        spawner[] spawnerArr = FindObjectsOfType<spawner>();
       // for (int i = 0; i < spawnerArr.Length; i++)
        //{
           // spawnerList.Add(spawnerArr[i]);
       // }
        spawnerList = spawnerArr.ToList<spawner>();
    }
    public void spawn()
    {
        foreach(spawner spawner in spawnerList)
        {
            spawner.Spawn();
        }
    }
    
}
