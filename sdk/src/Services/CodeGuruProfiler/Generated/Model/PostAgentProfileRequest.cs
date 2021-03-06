/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// Container for the parameters to the PostAgentProfile operation.
    /// Submit profile collected by an agent belonging to a profiling group for aggregation.
    /// </summary>
    public partial class PostAgentProfileRequest : AmazonCodeGuruProfilerRequest
    {
        private MemoryStream _agentProfile;
        private string _contentType;
        private string _profileToken;
        private string _profilingGroupName;

        /// <summary>
        /// Gets and sets the property AgentProfile.
        /// </summary>
        [AWSProperty(Required=true)]
        public MemoryStream AgentProfile
        {
            get { return this._agentProfile; }
            set { this._agentProfile = value; }
        }

        // Check to see if AgentProfile property is set
        internal bool IsSetAgentProfile()
        {
            return this._agentProfile != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type of the agent profile in the payload. Recommended to send the profile
        /// gzipped with content-type application/octet-stream. Other accepted values are application/x-amzn-ion
        /// and application/json for unzipped Ion and JSON respectively.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileToken. 
        /// <para>
        /// Client generated token to deduplicate the agent profile during aggregation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ProfileToken
        {
            get { return this._profileToken; }
            set { this._profileToken = value; }
        }

        // Check to see if ProfileToken property is set
        internal bool IsSetProfileToken()
        {
            return this._profileToken != null;
        }

        /// <summary>
        /// Gets and sets the property ProfilingGroupName.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ProfilingGroupName
        {
            get { return this._profilingGroupName; }
            set { this._profilingGroupName = value; }
        }

        // Check to see if ProfilingGroupName property is set
        internal bool IsSetProfilingGroupName()
        {
            return this._profilingGroupName != null;
        }

    }
}