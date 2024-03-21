using UnityEngine;
[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(Animator))]
public class PlaySound : MonoBehaviour
{
    
    // Reference to the AudioSource component
    private AudioSource _audioSource;
    private Animator _animator;
    private bool _isPlaying = false;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _animator = GetComponent<Animator>();
    }
    private void Play()
    {
        // Check if AudioSource is assigned
        if (_audioSource != null)
        {
            // Play the sound
            _audioSource.Play();
            _isPlaying = true;
        }
        else
        {
            Debug.LogWarning("No AudioSource assigned.");
        }
    }
    private void Pause()
    {
        // Check if AudioSource is assigned
        if (_audioSource != null)
        {
            // Play the sound
            _audioSource.Pause();
            _isPlaying = false;
        }
        else
        {
            Debug.LogWarning("No AudioSource assigned.");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hand"))
        {
            _animator.Play("btnPress");

            if (_isPlaying)
            {
                Pause();
            }
            else
            {
                Play();
            }
        }
    }
}
