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
using robotlegs.bender.extensions.eventDispatcher.impl;


namespace prankard.extensions.sound.api.events
{
	public class SoundVolumeEvent : Event
	{
		public enum Type
		{
			SET_SOUND_EFFECTS_VOLUME,
			SET_MUSIC_VOLUME
		}

		public float volume;

		public SoundVolumeEvent (Type type, float volume) : base(type)
		{
			this.volume = volume;
		}
	}
}
