﻿/*
 * File: IVoiceWrapper.cs
 * Date: 8.2.2018,
 *
 * MIT License
 *
 * Copyright (c) 2018 AlternateVoice
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

namespace AlternateVoice.Server.Wrapper.Interfaces
{
    public interface IVoiceWrapper
    {
        void StartNativeServer(ushort port);
        void StopNativeServer();

        void RemoveClient(IVoiceClient client);

        void SetClientPositionForClient(IVoiceClient listener, IVoiceClient client);
        void MuteClientForClient(IVoiceClient listener, IVoiceClient client, bool muted);
        void SetListenerDirection(IVoiceClient listener);

        void TestCallClientTalkingChangedCallback(ushort handle, bool newStatus);
        void TestCallClientConnectedCallback(ushort handle);
        void TestCallClientDisconnectedCallback(ushort handle);

        void UnregisterClientConnectedCallback();
        void UnregisterClientDisconnectedCallback();

        void RegisterClientConnectedCallback(Delegates.ClientConnectCallback callback);
        void RegisterClientDisconnectedCallback(Delegates.ClientCallback callback);
        void RegisterClientTalkingChangedCallback(Delegates.ClientStatusCallback callback);
    }
}