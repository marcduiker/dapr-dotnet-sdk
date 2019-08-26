// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Actions.Actors.Communication
{
    internal class ActorResponseMessage : IActorResponseMessage
    {
        private readonly IActorResponseMessageHeader header;
        private readonly IActorResponseMessageBody msgBody;

        public ActorResponseMessage(
            IActorResponseMessageHeader header,
            IActorResponseMessageBody msgBody)
        {
            this.header = header;
            this.msgBody = msgBody;
        }

        public IActorResponseMessageHeader GetHeader()
        {
            return this.header;
        }

        public IActorResponseMessageBody GetBody()
        {
            return this.msgBody;
        }
    }
}
