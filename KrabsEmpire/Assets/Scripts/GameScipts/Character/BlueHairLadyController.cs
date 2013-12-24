using UnityEngine;
using System.Collections;

public class BlueHairLadyController : MonoBehaviour
{
    private string AxisX = "Horizontal";
    private string AxisY = "Vertical";
    private Animator anim;
	BlueLadyStats stats;


    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
		stats = gameObject.GetComponent<BlueLadyStats>();
	}
    
    void Update()
    {


        anim.SetFloat("SpeedX", Input.GetAxis(AxisX));
        anim.SetFloat("SpeedY", Input.GetAxis(AxisY));


        MoveX();
        MoveY();
    }


    void MoveX()
    {
        if (Mathf.Abs(Input.GetAxis(AxisX)) > 0)
        {
            if(Input.GetAxis(AxisX)>0)
            {
                anim.SetFloat("Direction", 4);
            }
            if(Input.GetAxis(AxisX)<0)
            {
                anim.SetFloat("Direction", 3);
            }
            
            transform.position += transform.right * Input.GetAxis(AxisX) * stats.GetSpeed() * Time.deltaTime;
        }
    }

    void MoveY()
    {
        if (Mathf.Abs(Input.GetAxis(AxisY)) > 0)
        {
            if(Input.GetAxis(AxisY)>0)
            {
                anim.SetFloat("Direction", 2);
            }
            if(Input.GetAxis(AxisY)<0)
            {
                anim.SetFloat("Direction", 1);
            }
            
            transform.position += transform.up * Input.GetAxis(AxisY) * stats.GetSpeed() * Time.deltaTime;
        }
    }
}
