using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]ScriptableObject_test ScriptableObject;

    public float speed = 5f;
    Rigidbody Rigidbody;

    Renderer nowMaterial;

    //material[0]��n��
    public Material[] material;

    enum Pole
    {
        n,s
    }

    Pole pole;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        nowMaterial = GetComponent<Renderer>();

        //material[0]��n��
        nowMaterial.material = material[0];
        pole = Pole.n;

        //�Q�[���J�n���̑��x����
        ScriptableObject.limidSpeed = 20f;

        Physics.gravity = new Vector3(0, -20, 0);
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
        {
            ChangePole();
        }
    }

    private void FixedUpdate()
    {
        if (ScriptableObject.isGameStart)
        {
            Run();
        }
    }

    void Run()
    {
        if (Rigidbody.velocity.magnitude <= ScriptableObject.limidSpeed)
            Rigidbody.AddForce(Vector3.forward * speed, ForceMode.Force);
    }

    void ChangePole()
    {
        if (pole == Pole.n)
        {
            pole = Pole.s;
            nowMaterial.material = material[1];
            Physics.gravity = -Physics.gravity;

        }
        else
        {
            pole = Pole.n;
            nowMaterial.material = material[0];
            Physics.gravity = -Physics.gravity;
        }
    }
}
