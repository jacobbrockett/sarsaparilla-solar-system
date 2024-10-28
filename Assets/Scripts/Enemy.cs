using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Martian
{
    [SerializeField] Creature sheriffCreature;
    [SerializeField] Creature enemyCreature;
    [SerializeField] float sightDistance = 10f;

    Coroutine attackRoutine;


    // Start is called before the first frame update
    void Start()
    {
    }

    bool CanSeeTarget()
    {
        return Vector3.Distance(sheriffCreature.transform.position, enemyCreature.transform.position) < sightDistance;
    }

    // Update is called once per frame
    void Update()
    {
        if (CanSeeTarget())
        {
            if (attackRoutine == null)
            {
                // Start the attack loop if the target is in sight and the coroutine hasn't started
                attackRoutine = StartCoroutine(AttackRoutine());
            }
        }
        else if (attackRoutine != null)
        {
            // Stop the attack loop if the target is out of sight
            StopCoroutine(attackRoutine);
            attackRoutine = null;
        }

        if(GetCurrentHealth() <= 0f)
        {
            Destroy(this.gameObject);
        }
    }

    IEnumerator AttackRoutine()
    {
        GetProjectileLauncher().Launch();
        yield return new WaitForSeconds(2f);
    }
    
}
