// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// The parameters supplied to the list runbook version by runbook id and
    /// slot operation.
    /// </summary>
    public partial class RunbookVersionListLatestByRunbookIdSlotParameters
    {
        private bool _isDraft;
        
        /// <summary>
        /// Required. True or false, to indicate whether the runbook version is
        /// draft or not.
        /// </summary>
        public bool IsDraft
        {
            get { return this._isDraft; }
            set { this._isDraft = value; }
        }
        
        private string _runbookId;
        
        /// <summary>
        /// Required. The runbook id.
        /// </summary>
        public string RunbookId
        {
            get { return this._runbookId; }
            set { this._runbookId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// RunbookVersionListLatestByRunbookIdSlotParameters class.
        /// </summary>
        public RunbookVersionListLatestByRunbookIdSlotParameters()
        {
        }
    }
}
