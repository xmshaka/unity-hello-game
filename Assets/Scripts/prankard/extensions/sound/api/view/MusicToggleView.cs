//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;

using robotlegs.bender.platforms.unity.extensions.mediatorMap.impl;
using prankard.extensions.sound.impl.view;
using prankard.extensions.sound.api.events;


namespace prankard.extensions.sound.api.view
{
	public class MusicToggleView : SoundToggleView, ISoundSetView
	{
		public void UpdateSoundEffectsVolume (float volume)
		{
		}

		public void UpdateMusicVolume (float volume)
		{
			Toggle(volume > 0);
		}

		public void UserClicksToggle()
		{
			base.Toggle();
			dispatcher.Dispatch(new SoundVolumeEvent(SoundVolumeEvent.Type.SET_MUSIC_VOLUME, On ? 1 : 0));
		}
	}
}
