using UnityEngine;

public class HeroHitController : MonoBehaviour
{
    [SerializeField] private AudioClip _attackSound;
    
    private Animator _animator;
    private string _attackTrigger = "Attack";
    private AudioSource _audioSource;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        _animator.SetTrigger(_attackTrigger);
        _audioSource.clip = _attackSound;
        _audioSource.Play();
    }
}
