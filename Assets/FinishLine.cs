using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Must Include:
using UnityEngine.UI;
using TMPro;

public class FinishLine : MonoBehaviour
{
    [SerializeField] HorseMovementHandler horseMovement;
    [SerializeField] TextMeshProUGUI finishText;
    [SerializeField] String openScene;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {  
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            if(horseMovement != null)
            {
                horseMovement.Finished();
            }

            finishText.text = "You made it to the finish. Congrats!";

            StartCoroutine(LoadNextSceneRoutine());
        }
    }

    IEnumerator LoadNextSceneRoutine()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(openScene);
    }
}
