using UnityEngine;
public class Enemy : MonoBehaviour
{
    public Animator animator;
    void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    { 

    }
    public void ApplyStatus(StatusEffect effect)
    { 
        Debug.Log("Enemigo recibe :" + effect);
    }
    public void ApplyStatus(StatusEffect effect, float duration)
    {
        Debug.Log("Enemigo recibe :" + effect + "Time: " + duration);
    }
}
