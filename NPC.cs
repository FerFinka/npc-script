using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //Здоровье NPC
    public int health = 5;

    //Уровень NPC
    public int level = 1;

    //Скорость NPC
    public float speed = 1.2f;
    
    // Start is called before the first frame update
    void Start()
    {
    //Добавляем к здоровью уровень NPC
    health += level;               
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z = newPosition.z + speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
