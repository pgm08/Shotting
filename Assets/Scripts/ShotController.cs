using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    public GameObject tiroPrefab;
    public float forceSpeedFire;
    public bool isPlayer;
    public float currentTime;
    public float shotInterval;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= shotInterval)
        {
            currentTime = 0;
            Atirar();
        }
    
     //Update is called once per frame
    //void Update()
    //{
    //  if(Input.GetButtonDown("Fire1") && isPlayer)
    // {
    //    Atirar();
    }

    public void Atirar()
    {
        GameObject tempTiro = Instantiate(tiroPrefab) as GameObject;
        tempTiro.transform.position = transform.position;

        tempTiro.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, forceSpeedFire));
    }
}
