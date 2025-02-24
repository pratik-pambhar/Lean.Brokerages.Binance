/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

using NodaTime;
using QuantConnect.Brokerages;
using QuantConnect.Configuration;
using QuantConnect.Data;
using QuantConnect.Data.Market;
using QuantConnect.Securities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuantConnect.BinanceBrokerage.ToolBox
{
    /// <summary>
    /// BinanceUS Downloader class
    /// </summary>
    public class BinanceUSDataDownloader : BaseDataDownloader
    {
        protected override string MarketName => Market.BinanceUS;

        /// <summary>
        /// Initializes a new instance of the <see cref="BinanceDataDownloader"/> class
        /// </summary>
        public BinanceUSDataDownloader()
        {
            var apiUrl = Config.Get("binanceus-api-url", "https://api.binance.us");
            var websocketUrl = Config.Get("binanceus-websocket-url", "wss://stream.binance.us:9443/ws");
            Brokerage = new BinanceUSBrokerage(null, null, apiUrl, websocketUrl, null, null, null);

            SymbolMapper = new(Market.BinanceUS);
        }
    }
}
