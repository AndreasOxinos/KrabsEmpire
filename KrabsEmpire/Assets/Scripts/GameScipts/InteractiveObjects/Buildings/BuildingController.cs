using UnityEngine;
using System.Collections;

public class BuildingController : MonoBehaviour
{

    public string NextLevel = "";

    void Start()
    {

    }


    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        Application.LoadLevel(NextLevel);
    }
}
