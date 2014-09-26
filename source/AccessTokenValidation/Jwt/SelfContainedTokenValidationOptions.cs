﻿/*
 * Copyright 2014 Dominick Baier, Brock Allen
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using Microsoft.Owin.Security;
using System.Security.Cryptography.X509Certificates;

namespace Thinktecture.IdentityServer.v3.AccessTokenValidation
{
    public class JwtTokenValidationOptions : AuthenticationOptions
    {
        public JwtTokenValidationOptions()
            : base("IdentityServerJwt")
        { }

        // either provide base url for discovery
        public string Authority { get; set; }

        // or set issuer and cert manually
        public string IssuerName { get; set; }
        public X509Certificate2 SigningCertificate { get; set; }
    }
}