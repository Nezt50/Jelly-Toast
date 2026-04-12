using UnityEngine;

public class SitckyJellyScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            CharacterController2DScript toaster = FindFirstObjectByType<CharacterController2DScript>();

            if (toaster != null)
            {
                toaster.hasJamPowerUp = true;
                Destroy(this.gameObject);
            }
        }
        if (collision.gameObject.tag == "Toast")
        {
            CharacterController2DScript toaster = FindFirstObjectByType<CharacterController2DScript>();

            if (toaster != null)
            {
                toaster.hasJamPowerUp = true;
                Destroy(this.gameObject);
            }
        }
    }
}
