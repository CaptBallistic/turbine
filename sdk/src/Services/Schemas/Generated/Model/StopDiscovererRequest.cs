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
 * Do not modify this file. This file is generated from the schemas-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Schemas.Model
{
    /// <summary>
    /// Container for the parameters to the StopDiscoverer operation.
    /// Stops the discoverer
    /// </summary>
    public partial class StopDiscovererRequest : AmazonSchemasRequest
    {
        private string _discovererId;

        /// <summary>
        /// Gets and sets the property DiscovererId. 
        /// <para>
        /// The ID of the discoverer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DiscovererId
        {
            get { return this._discovererId; }
            set { this._discovererId = value; }
        }

        // Check to see if DiscovererId property is set
        internal bool IsSetDiscovererId()
        {
            return this._discovererId != null;
        }

    }
}