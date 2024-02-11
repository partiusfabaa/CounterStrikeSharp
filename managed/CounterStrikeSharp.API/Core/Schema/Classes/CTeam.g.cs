// <auto-generated />
#nullable enable
#pragma warning disable CS1591

using System;
using System.Diagnostics;
using System.Drawing;
using CounterStrikeSharp;
using CounterStrikeSharp.API.Modules.Events;
using CounterStrikeSharp.API.Modules.Entities;
using CounterStrikeSharp.API.Modules.Memory;
using CounterStrikeSharp.API.Modules.Utils;
using CounterStrikeSharp.API.Core.Attributes;

namespace CounterStrikeSharp.API.Core;

public partial class CTeam : CBaseEntity
{
    public CTeam (IntPtr pointer) : base(pointer) {}

	// m_aPlayerControllers
	[SchemaMember("CTeam", "m_aPlayerControllers")]
	public NetworkedVector<CHandle<CBasePlayerController>> PlayerControllers => Schema.GetDeclaredClass<NetworkedVector<CHandle<CBasePlayerController>>>(this.Handle, "CTeam", "m_aPlayerControllers");

	// m_aPlayers
	[SchemaMember("CTeam", "m_aPlayers")]
	public NetworkedVector<CHandle<CBasePlayerPawn>> Players => Schema.GetDeclaredClass<NetworkedVector<CHandle<CBasePlayerPawn>>>(this.Handle, "CTeam", "m_aPlayers");

	// m_iScore
	[SchemaMember("CTeam", "m_iScore")]
	public ref Int32 Score => ref Schema.GetRef<Int32>(this.Handle, "CTeam", "m_iScore");

	// m_szTeamname
	[SchemaMember("CTeam", "m_szTeamname")]
	public string Teamname
	{
		get { return Schema.GetString(this.Handle, "CTeam", "m_szTeamname"); }
		set { Schema.SetString(this.Handle, "CTeam", "m_szTeamname", value); }
	}

}