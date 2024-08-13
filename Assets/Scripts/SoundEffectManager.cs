using UnityEngine;

public class SoundEffectManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip destroyNormalCandySound;

    public void DestroyNormalCandySound() {
        audioSource.PlayOneShot(destroyNormalCandySound);
    }
}
