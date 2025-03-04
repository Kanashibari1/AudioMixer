using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class VolumeToggle : MonoBehaviour
{
    private const float MinVolume = -80f;
    private const string Name = "Master";

    [SerializeField] private AudioMixerGroup _audioMixerGroup;

    private bool _isMuted = false;
    private float _lastVolume = 0f;
    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(Toggle);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(Toggle);
    }

    private void Toggle()
    {
        ToggleMuteState();
        AdjustVolume();
    }

    private void AdjustVolume()
    {
        if (_isMuted)
        {
            _audioMixerGroup.audioMixer.GetFloat(Name, out _lastVolume);
            _audioMixerGroup.audioMixer.SetFloat(Name, MinVolume);
        }
        else
        {
            _audioMixerGroup.audioMixer.SetFloat(Name, _lastVolume);
        }
    }

    private void ToggleMuteState()
    {
        _isMuted = _isMuted != true;
    }
}
