using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimController : MonoBehaviour
{

    public Animator robotAnim;
    public float timer;


    // Start is called before the first frame update
    void Start()
    {
        robotAnim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Jump"))
        {
            robotAnim.SetTrigger("Jump");
            timer = 0;
        }
        if (Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0) {
            robotAnim.SetTrigger("Moving");
            timer = 0;
        }
        if (Input.GetAxis("Vertical") > 0 || Input.GetAxis("Vertical") < 0)
        {
            robotAnim.SetTrigger("Moving");
            timer = 0;
        }
        if (Input.GetButton("Fire1")) {
            robotAnim.SetTrigger("Attack");
            timer = 0;
        }

        timer += Time.deltaTime;

        if (timer >= 0.15f) {
            timer = 0.2f;
            robotAnim.SetTrigger("Idle");
        }
    }
}
