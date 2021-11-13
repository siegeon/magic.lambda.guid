﻿/*
 * Magic Cloud, copyright Aista, Ltd. See the attached LICENSE file for details.
 */

using System;
using magic.node;
using magic.signals.contracts;

namespace magic.lambda.guid
{
    /// <summary>
    /// [guid.new] slot for generating a new guid.
    /// </summary>
    [Slot(Name = "guid.new")]
    public class GuidNew : ISlot
    {
        /// <summary>
        /// Slot implementation.
        /// </summary>
        /// <param name="signaler">Signaler that raised the signal.</param>
        /// <param name="input">Arguments to slot.</param>
        public void Signal(ISignaler signaler, Node input)
        {
            input.Value = Guid.NewGuid();
        }
    }
}
