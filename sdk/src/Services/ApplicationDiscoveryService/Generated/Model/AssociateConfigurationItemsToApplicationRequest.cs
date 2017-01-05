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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateConfigurationItemsToApplication operation.
    /// Associates one or more configuration items with an application.
    /// </summary>
    public partial class AssociateConfigurationItemsToApplicationRequest : AmazonApplicationDiscoveryServiceRequest
    {
        private string _applicationConfigurationId;
        private List<string> _configurationIds = new List<string>();

        /// <summary>
        /// Gets and sets the property ApplicationConfigurationId. 
        /// <para>
        /// The configuration ID of an application with which items are to be associated.
        /// </para>
        /// </summary>
        public string ApplicationConfigurationId
        {
            get { return this._applicationConfigurationId; }
            set { this._applicationConfigurationId = value; }
        }

        // Check to see if ApplicationConfigurationId property is set
        internal bool IsSetApplicationConfigurationId()
        {
            return this._applicationConfigurationId != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationIds. 
        /// <para>
        /// The ID of each configuration item to be associated with an application.
        /// </para>
        /// </summary>
        public List<string> ConfigurationIds
        {
            get { return this._configurationIds; }
            set { this._configurationIds = value; }
        }

        // Check to see if ConfigurationIds property is set
        internal bool IsSetConfigurationIds()
        {
            return this._configurationIds != null && this._configurationIds.Count > 0; 
        }

    }
}