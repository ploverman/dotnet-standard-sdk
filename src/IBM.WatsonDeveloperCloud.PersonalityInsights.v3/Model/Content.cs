/**
* Copyright 2018 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using System.Collections.Generic;
using Newtonsoft.Json;

namespace IBM.WatsonDeveloperCloud.PersonalityInsights.v3.Model
{
    /// <summary>
    /// Content.
    /// </summary>
    public class Content : BaseModel
    {
        /// <summary>
        /// An array of `ContentItem` objects that provides the text that is to be analyzed.
        /// </summary>
        [JsonProperty("contentItems", NullValueHandling = NullValueHandling.Ignore)]
        public List<ContentItem> ContentItems { get; set; }
    }

}
