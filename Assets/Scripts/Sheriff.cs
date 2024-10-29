using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

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

        if(GetCurrentHealth() <= 0f)
        {
            // Destroy Sheriff Object
            Destroy(this.gameObject);

            // Reload Scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        GetHealthText().text = GetCurrentHealth().ToString() + '/' + GetMaxHealth().ToString();
    }
}
