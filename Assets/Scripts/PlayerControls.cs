using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    [Header("ronald mcdonald eating taco bell")]
    public Rigidbody2D rb;
    [Header("default downward fatherless man")]
    public float downwardSpiralForHavingAnxietyDepressionAndEmotionalDamage = 20f;
    [Header("default speed for directionals movenejtwnad")]
    public float movementSpeedForBecomingA40YearOldLivingInTheirMothersBasementWithAnxietyDepressionAndEmotionalDamage = 10f;
    [Header("default direction speed for becoming a roblox player. your entire brain will be roblox, 4 + 4 will equal adopt me, closet = hide from rush. your brain is no more and you have fallen victim to anxiety, emotional damage depression, no money, no life, no father")]
    public float directionSpeedForBeingARobloxPlayerWithAnxietyDepressionEmotionalDamageNoFatherNoBrainsNoMoneyAndNoLife = 0f;
    [Header("how much time you've spent as a fatherless, brainless, broke, goofy ah no-life living in their mother's basement")]
    public Text howMuchTimeYouHaveSpentAsAFatherlessBrainlessBrokeGoofyAhNoLifeLivingInTheirMothersBasement;
    public float maxAmountOfTimeYouHaveSpentAsAFatherlessBrainlessBrokeGoofyAhNoLifeLivingInTheirMothersBasement;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // e e e e e e  e e e  e e e e  e e e e e e e  eeeeeee  ee e e e e e e e e e e ee e e e e e e e ee xncbvhubaeridocxjvhbgadsixcvhjbegrijsodfkjm bgrjdfs809ikjcvn kdfsu9ikngixcvm bnifshndmv,nb xdfjmjodfsikjxn cdfsixkjncm sdfipokmcvx, mfasd,zokj cxvlb;sdgzfxpcvcn.ds:Ocxadfb,hjxcdsibhjdhyu9 gcgfcgf cgf
        directionSpeedForBeingARobloxPlayerWithAnxietyDepressionEmotionalDamageNoFatherNoBrainsNoMoneyAndNoLife = Input.GetAxis("Horizontal") * movementSpeedForBecomingA40YearOldLivingInTheirMothersBasementWithAnxietyDepressionAndEmotionalDamage;
        // /j
        if (directionSpeedForBeingARobloxPlayerWithAnxietyDepressionEmotionalDamageNoFatherNoBrainsNoMoneyAndNoLife < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (rb.velocity.y > 0 && transform.position.y > maxAmountOfTimeYouHaveSpentAsAFatherlessBrainlessBrokeGoofyAhNoLifeLivingInTheirMothersBasement)
        {
            maxAmountOfTimeYouHaveSpentAsAFatherlessBrainlessBrokeGoofyAhNoLifeLivingInTheirMothersBasement = transform.position.y;
        }
        howMuchTimeYouHaveSpentAsAFatherlessBrainlessBrokeGoofyAhNoLifeLivingInTheirMothersBasement.text = "Score: " + Mathf.Round(maxAmountOfTimeYouHaveSpentAsAFatherlessBrainlessBrokeGoofyAhNoLifeLivingInTheirMothersBasement).ToString();
    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = directionSpeedForBeingARobloxPlayerWithAnxietyDepressionEmotionalDamageNoFatherNoBrainsNoMoneyAndNoLife;
        rb.velocity = velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.velocity = new Vector3(rb.velocity.x, downwardSpiralForHavingAnxietyDepressionAndEmotionalDamage, 0);
    }
}
