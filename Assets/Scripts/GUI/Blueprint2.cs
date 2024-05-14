using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blueprint2 : MonoBehaviour
{
    public GameObject image;

    public GameObject prefab;

    void Update()
    {
        Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        position.z = image.transform.position.z;

        position.x = Mathf.FloorToInt(position.x + 0.5f);
        position.y = Mathf.FloorToInt(position.y + 0.5f);

        image.transform.position = position;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(!RoomManager.roomMap.ContainsKey(position))
            {
                GameObject instance = Instantiate(prefab, position, prefab.transform.rotation);
                
                RoomManager.roomMap.Add(position, instance.GetComponent<Room>());
            }
            
        }
    }
}
