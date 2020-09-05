using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawner : MonoBehaviour
{
    public GameObject monster;

    private void OnEnable()
    {
        EventMa.instance.StartListening("spawn", Spawn);
    }
    private void OnDisable()
    {
        EventMa.instance.StartListening("spawn", Spawn);
    }


    private void Start()
    {
        EventMa.instance.StartListening("Spawn", Spawn);
    }

    public void Spawn()
    {
        Instantiate(monster, this.transform.position,
                             this.transform.rotation);
    }
}