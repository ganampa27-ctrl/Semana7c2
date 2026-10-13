using UnityEngine;
public class Enemy : MonoBehaviour
{
    public Transform Target; 
    public float speed = 3f;
    public float detectionRadius = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;

    
    public Animator animator;
    void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }
    // Update is called once per frame
    void Update()
    { 
        float distanceToTarget = Vector2.Distance(transform.position, Target.position);
        if (distanceToTarget <= detectionRadius)
        {
            Vector2 direction = (Target.position - transform.position).normalized;
            movement = direction;
            movement = new Vector2(direction.x,0);
        }
        else
        {
            movement = Vector2.zero;
        }
        rb.MovePosition((Vector2)rb.position + movement * speed * Time.deltaTime);
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
