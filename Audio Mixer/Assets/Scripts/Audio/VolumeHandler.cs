using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public abstract class VolumeHandler : MonoBehaviour
{
    private const float Coefficient = 20f;

    [SerializeField] private AudioMixerGroup _audioMixerGroup;

    private Slider _slider;

    protected abstract string ParameterName { get; }

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(ChangeVolume);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(ChangeVolume);
    }

    public void ChangeVolume(float volume)
    {
        _audioMixerGroup.audioMixer.SetFloat(ParameterName, Mathf.Log10(volume) * Coefficient);
    }
}
