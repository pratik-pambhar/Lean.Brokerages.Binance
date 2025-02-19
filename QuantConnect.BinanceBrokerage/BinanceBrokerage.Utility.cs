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

using QuantConnect.Orders;

namespace QuantConnect.BinanceBrokerage
{
    /// <summary>
    /// Binance utility methods
    /// </summary>
    public partial class BinanceBrokerage
    {
        private static OrderStatus ConvertOrderStatus(string raw)
        {
            switch (raw.LazyToUpper())
            {
                case "NEW":
                    return OrderStatus.Submitted;

                case "PARTIALLY_FILLED":
                    return OrderStatus.PartiallyFilled;

                case "FILLED":
                    return OrderStatus.Filled;

                case "PENDING_CANCEL":
                    return OrderStatus.CancelPending;

                case "CANCELED":
                    return OrderStatus.Canceled;

                case "REJECTED":
                case "EXPIRED":
                    return OrderStatus.Invalid;

                default:
                    return OrderStatus.None;
            }
        }
    }
}
