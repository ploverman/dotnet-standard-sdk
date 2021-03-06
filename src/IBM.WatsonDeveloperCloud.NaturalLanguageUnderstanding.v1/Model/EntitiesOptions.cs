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

using Newtonsoft.Json;

namespace IBM.WatsonDeveloperCloud.NaturalLanguageUnderstanding.v1.Model
{
    /// <summary>
    /// Identifies people, cities, organizations, and other entities in the content. See [Entity types and
    /// subtypes](https://cloud.ibm.com/docs/services/natural-language-understanding/entity-types.html).
    ///
    /// Supported languages: English, French, German, Italian, Japanese, Korean, Portuguese, Russian, Spanish, Swedish.
    /// Arabic, Chinese, and Dutch custom models are also supported.
    /// </summary>
    public class EntitiesOptions : BaseModel
    {
        /// <summary>
        /// Maximum number of entities to return.
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public long? Limit { get; set; }
        /// <summary>
        /// Set this to `true` to return locations of entity mentions.
        /// </summary>
        [JsonProperty("mentions", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mentions { get; set; }
        /// <summary>
        /// Enter a [custom
        /// model](https://www.bluemix.net/docs/services/natural-language-understanding/customizing.html) ID to override
        /// the standard entity detection model.
        /// </summary>
        [JsonProperty("model", NullValueHandling = NullValueHandling.Ignore)]
        public string Model { get; set; }
        /// <summary>
        /// Set this to `true` to return sentiment information for detected entities.
        /// </summary>
        [JsonProperty("sentiment", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sentiment { get; set; }
        /// <summary>
        /// Set this to `true` to analyze emotion for detected keywords.
        /// </summary>
        [JsonProperty("emotion", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Emotion { get; set; }
    }

}
