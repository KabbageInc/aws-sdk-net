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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Container for the parameters to the PutComponentPolicy operation.
    /// Applies a policy to a component.
    /// </summary>
    public partial class PutComponentPolicyRequest : AmazonImagebuilderRequest
    {
        private string _componentArn;
        private string _policy;

        /// <summary>
        /// Gets and sets the property ComponentArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the component that this policy should be applied
        /// to. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ComponentArn
        {
            get { return this._componentArn; }
            set { this._componentArn = value; }
        }

        // Check to see if ComponentArn property is set
        internal bool IsSetComponentArn()
        {
            return this._componentArn != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        ///  The policy to apply. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

    }
}