using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        transform.position += Vector3.right * horizontal * 5 * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {   
        Debug.Log("miabuela");
        PicableItem picable = other.gameObject.GetComponent<PicableItem>();
        if(picable != null)
        {
            InventarioManager.instance.AddWeapon(picable.weapon);

            Destroy(other.gameObject);
        }
    }
}
