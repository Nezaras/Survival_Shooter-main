using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    private float shots;
    public float startshots;

    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        shots = startshots;
    }

    // Update is called once per frame
    void Update()
    {
        if (shots <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            shots = startshots;
        }
        else
        {
            shots -= Time.deltaTime;
        }
    }
}
