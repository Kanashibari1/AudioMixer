public class ButtonsVolume : VolumeHandler<ButtonsVolume>
{
    public void ChangeVolume(float volume)
    {
        ChangeVolume(volume, "VolumeButtons");
    }
}
