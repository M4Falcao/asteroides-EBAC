using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movijogador : MonoBehaviour
{
    public Rigidbody2D meuRigidBody;
    public float aceleracao;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate() //quando todo frame modifica uma propriedade
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            Vector3 direcao = transform.up * aceleracao;
            meuRigidBody.AddForce(direcao, ForceMode2D.Force);
        }
    }
}
