using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{

    void Start()
    {
        GameObject _char = (GameObject)Instantiate(Resources.Load("character"));
        _char.transform.position = new Vector2(transform.position.x, transform.position.y);
    }

}
