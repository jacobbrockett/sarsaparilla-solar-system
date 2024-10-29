using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Must Include:
using UnityEngine.UI;
using TMPro;

public class AmmoWindow : MonoBehaviour
{
    [SerializeField] Sheriff sheriff; // always connected to what player is controlling

    [SerializeField] TextMeshProUGUI ammoText;

    [Header("Reload Bar")]
    [SerializeField] Transform barTransform;
    [SerializeField] List<GameObject> hideableBarObjects;

    void SetReloadProgress(float progress) // 0.0-1.0
    {
        barTransform.localScale = new Vector3(progress, barTransform.localScale.y, 1);
    }

    // Update is called once per frame
    void Update()
    {
        int ammoAmount = sheriff.GetProjectileLauncher().GetAmmo();
        int maxAmmo = sheriff.GetProjectileLauncher().GetMaxAmmo();

        float fraction = (float)ammoAmount / (float)maxAmmo;

        ammoText.text = ammoAmount.ToString();

        ammoText.color = Color.Lerp(Color.yellow, Color.white, fraction);

        if(ammoAmount == 0)
        {
            ammoText.color = Color.red;
        }

        float reloadProgress = sheriff.GetProjectileLauncher().GetReloadPercentage();

        // Set reload bar progress
        SetReloadProgress(reloadProgress);

        // Hide or show progress limit bars
        if(reloadProgress <=0)
        {
            foreach(GameObject g in hideableBarObjects)
            {
                g.SetActive(false);
            }
        }
        else
        {
            foreach(GameObject g in hideableBarObjects)
            {
                g.SetActive(true);
            }
        }
    }
}
