/*
 * MIT License
 *
 * Copyright (c) Microsoft Corporation.
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
 *
 *
 * ------------------------------------------------------------------------------ 
 * <auto-generated> 
 * This code was generated by a tool at:
 * /utils/doclint/generateDotnetApi.js
 * 
 * Changes to this file may cause incorrect behavior and will be lost if 
 * the code is regenerated. 
 * </auto-generated> 
 * ------------------------------------------------------------------------------
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Playwright
{
    /// <summary><para>The <see cref="IWebSocket"/> class represents websocket connections in the page.</para></summary>
    public partial interface IWebSocket
    {
        /// <summary><para>Fired when the websocket closes.</para></summary>
        event EventHandler<IWebSocket> Close;

        /// <summary><para>Fired when the websocket receives a frame.</para></summary>
        event EventHandler<IWebSocketFrame> FrameReceived;

        /// <summary><para>Fired when the websocket sends a frame.</para></summary>
        event EventHandler<IWebSocketFrame> FrameSent;

        /// <summary><para>Fired when the websocket has an error.</para></summary>
        event EventHandler<String> SocketError;

        /// <summary><para>Indicates that the web socket has been closed.</para></summary>
        bool IsClosed { get; }

        /// <summary><para>Contains the URL of the WebSocket.</para></summary>
        string Url { get; }

        /// <summary>
        /// <para>
        /// Waits for event to fire and passes its value into the predicate function. Returns
        /// when the predicate returns truthy value. Will throw an error if the webSocket is
        /// closed before the event is fired. Returns the event data value.
        /// </para>
        /// </summary>
        /// <param name="event">Event name, same one would pass into <c>webSocket.on(event)</c>.</param>
        /// <param name="timeout">
        /// Maximum time to wait for in milliseconds. Defaults to <c>30000</c> (30 seconds).
        /// Pass <c>0</c> to disable timeout. The default value can be changed by using the
        /// <see cref="IBrowserContext.SetDefaultTimeout"/>.
        /// </param>
        Task<object> WaitForEventAsync(string @event, float? timeout = default);

        /// <summary>
        /// <para>
        /// Performs action and waits for a frame to be sent. If predicate is provided, it passes
        /// <see cref="IWebSocketFrame"/> value into the <c>predicate</c> function and waits
        /// for <c>predicate(webSocketFrame)</c> to return a truthy value. Will throw an error
        /// if the WebSocket or Page is closed before the frame is received.
        /// </para>
        /// </summary>
        /// <param name="predicate">
        /// Receives the <see cref="IWebSocketFrame"/> object and resolves to truthy value when
        /// the waiting should resolve.
        /// </param>
        /// <param name="timeout">
        /// Maximum time to wait for in milliseconds. Defaults to <c>30000</c> (30 seconds).
        /// Pass <c>0</c> to disable timeout. The default value can be changed by using the
        /// <see cref="IBrowserContext.SetDefaultTimeout"/>.
        /// </param>
        Task<IWebSocketFrame> WaitForFrameReceivedAsync(Func<IWebSocketFrame, bool> predicate = default, float? timeout = default);

        /// <summary>
        /// <para>
        /// Performs action and waits for a frame to be sent. If predicate is provided, it passes
        /// <see cref="IWebSocketFrame"/> value into the <c>predicate</c> function and waits
        /// for <c>predicate(webSocketFrame)</c> to return a truthy value. Will throw an error
        /// if the WebSocket or Page is closed before the frame is sent.
        /// </para>
        /// </summary>
        /// <param name="predicate">
        /// Receives the <see cref="IWebSocketFrame"/> object and resolves to truthy value when
        /// the waiting should resolve.
        /// </param>
        /// <param name="timeout">
        /// Maximum time to wait for in milliseconds. Defaults to <c>30000</c> (30 seconds).
        /// Pass <c>0</c> to disable timeout. The default value can be changed by using the
        /// <see cref="IBrowserContext.SetDefaultTimeout"/>.
        /// </param>
        Task<IWebSocketFrame> WaitForFrameSentAsync(Func<IWebSocketFrame, bool> predicate = default, float? timeout = default);
    }
}