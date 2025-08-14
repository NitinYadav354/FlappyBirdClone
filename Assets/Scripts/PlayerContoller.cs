using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float gS = 0.5f;
    public float jumpforce = 10f;
    public Sprite wingsUpSprite;
    public Sprite wingsDownSprite;
    public float yMin = -20;
    public float yMax = 20;
    private GameOverManager gameovermanager;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private AudioSource audioSource;
    public AudioClip jump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        gameovermanager = FindObjectOfType<GameOverManager>();
        audioSource = GetComponent<AudioSource>();
        rb.gravityScale = gS;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameovermanager.GameOver();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)||Input.GetKeyDown(KeyCode.Space)&&rb.position.y>-5){
            rb.velocity = Vector2.up*jumpforce;
            spriteRenderer.sprite = wingsDownSprite;
            audioSource.PlayOneShot(jump);
        }
        else if(rb.velocity.y>0){
            spriteRenderer.sprite = wingsDownSprite;
        }
        else if(rb.velocity.y<0){
            spriteRenderer.sprite = wingsUpSprite;
        }

        Vector3 ClampedPosition = transform.position;
        ClampedPosition.y = Mathf.Clamp(ClampedPosition.y, yMin, yMax);
        transform.position = ClampedPosition;
    }


}
