using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personaje1Logica : MonoBehaviour
{
    public float velocidadMov = 5.0f;
    public float velocidadRot = 200.0f;
    private Animator anim;
    public float x, y;

    public Rigidbody rb;

    public float potenciaSalto = 7f;
    public bool piso;

    // Start is called before the first frame update
    void Start()
    {
        piso = false;
        anim = GetComponent<Animator>();
    }

    /** void FixedUpdate()
     {
         transform.Rotate(0, x * Time.deltaTime * velocidadRot, 0);
         transform.Translate(0, 0, y * Time.deltaTime * velocidadMov);
     }
     // Update is called once per frame**/
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");


        transform.Rotate(0, x * Time.deltaTime * velocidadRot, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMov);

        anim.SetFloat("velX", x);
        anim.SetFloat("velY", y);
        /**
                if (piso) {
                    if (Input.GetKeyDown(KeyCode.Space)) {
                        anim.SetBool("Salto", true);
                        rb.AddForce(new Vector3(0, potenciaSalto, 0), ForceMode.Impulse);

                    }
                    anim.SetBool("suelo", true);



                }
                else {
                    caida();
                
                }
            
            }public void caida() {
                anim.SetBool("Salto", false);
                anim.SetBool("suelo", false);



            }**/


    }

}
