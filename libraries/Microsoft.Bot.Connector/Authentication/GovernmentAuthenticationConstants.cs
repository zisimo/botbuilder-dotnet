﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Microsoft.Bot.Connector.Authentication
{
    /// <summary>
    /// Values and Constants used for Authentication and Authrization by the Bot Framework Protocol to US Government DataCenters
    /// </summary>
    public static class GovernmentAuthenticationConstants
    {
        /// <summary>
        /// Government Channel Service property value
        /// </summary>
        public const string ChannelService = "https://botframework.us";

        /// <summary>
        /// TO GOVERNMENT CHANNEL FROM BOT: Login URL
        /// </summary>
        public const string ToChannelFromBotLoginUrl = "https://login.microsoftonline.us/botframework.com/oauth2/v2.0/token";

        /// <summary>
        /// TO GOVERNMENT CHANNEL FROM BOT: OAuth scope to request
        /// </summary>
        public const string ToChannelFromBotOAuthScope = "https://api.botframework.us/.default";

        /// <summary>
        /// TO BOT FROM GOVERNMENT CHANNEL: Token issuer
        /// </summary>
        public const string ToBotFromChannelTokenIssuer = "https://api.botframework.us";

        /// <summary>
        /// OAuth Url used to get a token from OAuthApiClient
        /// </summary>
        public const string OAuthUrlGov = "https://api.botframework.us";

        /// <summary>
        /// TO BOT FROM GOVERNMANT CHANNEL: OpenID metadata document for tokens coming from MSA
        /// </summary>
        public const string ToBotFromChannelOpenIdMetadataUrl = "https://login.botframework.us/v1/.well-known/openidconfiguration";
    }
}