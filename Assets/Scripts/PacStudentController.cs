using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D RB2D;
    public float Speed;
    public Animator Animata;

    Vector2 Movement = Vector2.zero;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");

        Animata.SetFloat("Horizontal", Movement.x);
        Animata.SetFloat("Vertical", Movement.y);
    }

    private void FixedUpdate()
    {
        RB2D.MovePosition(RB2D.position + Movement * Speed * Time.fixedDeltaTime);
    }
}
