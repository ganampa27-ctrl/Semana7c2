using System;
using UnityEngine;
using UnityEngine.InputSystem;
public class Player : MonoBehaviour
{
    public BaseAbility[] abilities;
    private InputSystem_Actions inputs;
    private BaseAbility current;
    public Animator animator;
    float speed = 5f;
    private Vector2 vector2;
    private void Awake()
    {
        inputs = new();
    }
    private void OnEnable()
    {
        inputs.Enable();
        inputs.Player.Ability.performed += SelecAbility1;
        inputs.Player.Ability2.performed += SelecAbility2;
        inputs.Player.Ability3.performed += SelecAbility3;
        inputs.Player.Ability4.performed += SelecAbility4;
        inputs.Player.Ability5.performed += SelecAbility5;
        inputs.Player.Attack.performed += OnCast;
    }
    private void OnCast(InputAction.CallbackContext context)
    {
        if (current == null) return;
        current.Execute();
        current = null;
    }
    #region Ability Selector
    private void SelecAbility5(InputAction.CallbackContext context)
    {
        Select(4);
    }
    private void SelecAbility4(InputAction.CallbackContext context)
    {
        Select(3);
    }
    private void SelecAbility3(InputAction.CallbackContext context)
    {
        Select(2);
    }
    private void SelecAbility2(InputAction.CallbackContext context)
    {
        Select(1);
    }
    private void SelecAbility1(InputAction.CallbackContext context)
    {
        Select(0);
    }
#endregion

    private void OnDisable()
    {

    }
    public void Select(int index)
    {
        current = abilities[index];
    }
    private void Updte()
    {
            vector2 = inputs.Player.Move.ReadValue<Vector2>();
            transform.position += new Vector3(vector2.x, 0f, 0f) * Time.deltaTime * speed;
            animator.SetFloat("Movement", Mathf.Abs(vector2.x));

            if (vector2.x != 0f)
            {
                Vector3 s = transform.localScale;
                s.x = Mathf.Abs(s.x) * Mathf.Sign(vector2.x);
                transform.localScale = s;
            }
    }
    public void MoveMechanic() 
    {
        vector2 = inputs.Player.Move.ReadValue<Vector2>();
        transform.position += new Vector3(vector2.x, 0f, 0f) * Time.deltaTime * speed;
        
        if(vector2 != Vector2.zero)
        {
            animator.SetBool("OnMove", true);
        }
        else
        {
            animator.SetBool("OnMove", false);
        }

        if (vector2.x != 0f)
        {
            Vector3 s = transform.localScale;
            s.x = Mathf.Abs(s.x) * Mathf.Sign(vector2.x);
            transform.localScale = s;
        }
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
    }   
}