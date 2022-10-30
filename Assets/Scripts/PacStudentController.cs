using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D RB2D;
    public float Speed;
    public Animator Animata;

    Vector2 LastMovement = Vector2.zero;
    Vector2 Movement = Vector2.zero;

    private static Tween tweener;
    private static float DurationPerStep = 0.25f;

    // pac status
    public enum PacStatus { Alive, Dead };
    PacStatus Status = PacStatus.Alive;

    // wall detect 
    public enum Direction { Right, Left, Top, Down }
    //private Dictionary<Direction, Vector3> _mapStep;
    Vector3 up, down, left, right;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");

        Vector2 ThisMovement = Movement;

        if (Movement != Vector2.zero)
        {
            LastMovement = Movement;
            if (Movement.x < -0.5)
                tweener.SetTween(RB2D.transform, RB2D.transform.position, RB2D.transform.position + new Vector3(-1f, 0f, 0f), DurationPerStep);
            if (Movement.x > 0.5)
                tweener.SetTween(RB2D.transform, RB2D.transform.position, RB2D.transform.position + new Vector3(1f, 0f, 0f), DurationPerStep);
            if (Movement.y < -0.5)
                tweener.SetTween(RB2D.transform, RB2D.transform.position, RB2D.transform.position + new Vector3(0f, -1f, 0f), DurationPerStep);
            if (Movement.x > 0.5)
                tweener.SetTween(RB2D.transform, RB2D.transform.position, RB2D.transform.position + new Vector3(0f, 1f, 0f), DurationPerStep);
        }
        else
        {
            ThisMovement = LastMovement;
        }
        Animata.SetFloat("Horizontal", ThisMovement.x);
        Animata.SetFloat("Vertical", ThisMovement.y);



        Debug.Log(Movement);

        //tweener.SetTween()
    }

    //private void FixedUpdate()
    //{
    //    tw
    //    RB2D.MovePosition(RB2D.position + Movement * Speed * Time.fixedDeltaTime);
    //}


    private bool WallDetect(Direction iDir)
    {
        return true;
    }
}
