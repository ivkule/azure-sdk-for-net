// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.Face.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for Apply operation.
    /// </summary>
    public partial class SnapshotApplyHeaders
    {
        /// <summary>
        /// Initializes a new instance of the SnapshotApplyHeaders class.
        /// </summary>
        public SnapshotApplyHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SnapshotApplyHeaders class.
        /// </summary>
        /// <param name="operationLocation">Operation location with an
        /// operation id used to track the progress of applying the snapshot by
        /// OperationStatus - Get.</param>
        public SnapshotApplyHeaders(string operationLocation = default(string))
        {
            OperationLocation = operationLocation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets operation location with an operation id used to track
        /// the progress of applying the snapshot by OperationStatus - Get.
        /// </summary>
        [JsonProperty(PropertyName = "Operation-Location")]
        public string OperationLocation { get; set; }

    }
}
