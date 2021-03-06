﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// </summary>
    public static class ReceiptExtensions
    {
        /// <summary>
        /// </summary>
        /// <returns></returns>
        public static USReceipt AsUSReceipt(this RecognizedReceipt receipt)
        {
            return new USReceipt(receipt);
        }
    }
}
