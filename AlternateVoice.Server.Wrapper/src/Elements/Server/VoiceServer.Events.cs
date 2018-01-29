﻿using AlternateVoice.Server.Wrapper.Interfaces;

namespace AlternateVoice.Server.Wrapper.Elements.Server
{
    internal partial class VoiceServer
    {
        public event Delegates.EmptyEvent OnServerStarted;
        public event Delegates.EmptyEvent OnServerStopping;
        
        public event Delegates.ClientEvent OnClientConnected;
        public event Delegates.ClientDisconnected OnClientDisconnected;

        public event Delegates.ClientEvent OnClientStartsTalking;
        public event Delegates.ClientEvent OnClientStopsTalking;

        public event Delegates.ClientGroupEvent OnClientJoinedGroup;
        public event Delegates.ClientGroupEvent OnClientLeftGroup;

        private void DisposeEvents()
        {
            OnServerStarted = null;
            OnServerStopping = null;
            
            OnClientConnected = null;
            OnClientConnected = null;
            
            OnClientJoinedGroup = null;
            OnClientLeftGroup = null;
        }

        internal void FireClientJoinedGroup(IVoiceClient client, IVoiceGroup group)
        {
            OnClientJoinedGroup?.Invoke(client, group);
        }

        internal void FireClientLeftGroup(IVoiceClient client, IVoiceGroup group)
        {
            OnClientLeftGroup?.Invoke(client, group);
        }

        public void TestLipSyncActiveForClient(IVoiceClient client)
        {
            OnClientStartsTalking?.Invoke(client);
        }

        public void TestLipSyncInactiveForClient(IVoiceClient client)
        {
            OnClientStopsTalking?.Invoke(client);
        }
        
        public void TriggerClientConnectedEvent(ushort handle)
        {
            OnClientConnectedFromVoice(handle);
        }

        public void TriggerClientDisconnectedEvent(ushort handle)
        {
            OnClientDisconnectedFromVoice(handle);
        }
        
    }
}