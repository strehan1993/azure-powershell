namespace Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.PowerShell;

    /// <summary>Response for Disk Pool request.</summary>
    [System.ComponentModel.TypeConverter(typeof(DiskPoolTypeConverter))]
    public partial class DiskPool
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.DiskPool"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPool" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPool DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DiskPool(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.DiskPool"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPool" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPool DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DiskPool(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.DiskPool"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DiskPool(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.SkuTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.DiskPoolPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadata) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.SystemMetadataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.TrackedResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SkuName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SkuTier = (string) content.GetValueForProperty("SkuTier",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SkuTier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.ProvisioningStates) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.ProvisioningStates.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).AvailabilityZone = (string[]) content.GetValueForProperty("AvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).AvailabilityZone, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.OperationalStatus) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.OperationalStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).Disk = (Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDisk[]) content.GetValueForProperty("Disk",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).Disk, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDisk>(__y, Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.DiskTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SubnetId = (string) content.GetValueForProperty("SubnetId",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SubnetId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).AdditionalCapability = (string[]) content.GetValueForProperty("AdditionalCapability",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).AdditionalCapability, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.DiskPool"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DiskPool(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.SkuTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.DiskPoolPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ISystemMetadata) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.SystemMetadataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.TrackedResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SkuName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SkuTier = (string) content.GetValueForProperty("SkuTier",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SkuTier, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.ProvisioningStates) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.ProvisioningStates.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).AvailabilityZone = (string[]) content.GetValueForProperty("AvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).AvailabilityZone, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.OperationalStatus) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.OperationalStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).Disk = (Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDisk[]) content.GetValueForProperty("Disk",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).Disk, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDisk>(__y, Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.DiskTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SubnetId = (string) content.GetValueForProperty("SubnetId",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SubnetId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).AdditionalCapability = (string[]) content.GetValueForProperty("AdditionalCapability",((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPoolInternal)this).AdditionalCapability, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DiskPool" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210401Preview.IDiskPool FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Response for Disk Pool request.
    [System.ComponentModel.TypeConverter(typeof(DiskPoolTypeConverter))]
    public partial interface IDiskPool

    {

    }
}