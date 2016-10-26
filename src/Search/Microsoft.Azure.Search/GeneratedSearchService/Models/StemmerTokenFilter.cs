// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Language specific stemming filter. This token filter is implemented
    /// using Apache Lucene.
    /// <see href="https://msdn.microsoft.com/library/azure/mt605304.aspx#TokenFilters" />
    /// </summary>
    [JsonObject("#Microsoft.Azure.Search.StemmerTokenFilter")]
    public partial class StemmerTokenFilter : TokenFilter
    {
        /// <summary>
        /// Initializes a new instance of the StemmerTokenFilter class.
        /// </summary>
        public StemmerTokenFilter() { }

        /// <summary>
        /// Initializes a new instance of the StemmerTokenFilter class.
        /// </summary>
        public StemmerTokenFilter(string name, StemmerTokenFilterLanguage language)
            : base(name)
        {
            Language = language;
        }

        /// <summary>
        /// Gets or sets the language to use. Possible values include:
        /// 'arabic', 'armenian', 'basque', 'brazilian', 'bulgarian',
        /// 'catalan', 'czech', 'danish', 'dutch', 'dutchKp', 'english',
        /// 'lightEnglish', 'minimalEnglish', 'possessiveEnglish', 'porter2',
        /// 'lovins', 'finnish', 'lightFinnish', 'french', 'lightFrench',
        /// 'minimalFrench', 'galician', 'minimalGalician', 'german',
        /// 'german2', 'lightGerman', 'minimalGerman', 'greek', 'hindi',
        /// 'hungarian', 'lightHungarian', 'indonesian', 'irish', 'italian',
        /// 'lightItalian', 'sorani', 'latvian', 'norwegian',
        /// 'lightNorwegian', 'minimalNorwegian', 'lightNynorsk',
        /// 'minimalNynorsk', 'portuguese', 'lightPortuguese',
        /// 'minimalPortuguese', 'portugueseRslp', 'romanian', 'russian',
        /// 'lightRussian', 'spanish', 'lightSpanish', 'swedish',
        /// 'lightSwedish', 'turkish'
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public StemmerTokenFilterLanguage Language { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}