using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheriff : Martian
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Fire weapon
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetProjectileLauncher().Launch();
        }

        // Reload weapon
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetProjectileLauncher().Reload();
        }
    }
}
