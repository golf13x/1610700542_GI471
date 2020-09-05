using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gametest : MonoBehaviour
{
    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))

        {
            spawnerMa.instance.spawn();
        }
    }
}
