using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class MixLevels : MonoBehaviour {

	public AudioMixer masterMixer;

	public void SetSfxLvl(float sfxLvl)
	{
		masterMixer.SetFloat("FxVolume", sfxLvl);
	}

	public void SetMusicLvl (float musicLvl)
	{
		masterMixer.SetFloat ("MusicVolume", musicLvl);
	}
}
