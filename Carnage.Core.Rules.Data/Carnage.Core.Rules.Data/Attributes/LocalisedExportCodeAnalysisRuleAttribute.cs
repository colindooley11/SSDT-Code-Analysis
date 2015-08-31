namespace Carnage.Core.Rules.Data.Attributes
{
    using System;
    using System.Globalization;
    using System.Reflection;
    using System.Resources;
    using Microsoft.SqlServer.Dac.CodeAnalysis;

    internal sealed class LocalizedExportCodeAnalysisRuleAttribute : ExportCodeAnalysisRuleAttribute
    {
        private readonly string resourceBaseName;
        private readonly string displayNameResourceId;
        private readonly string descriptionResourceId;

        private ResourceManager resourceManager;
        private string displayName;
        private string descriptionValue;

        /// <summary>
        /// Creates the attribute, with the specified rule ID, the fully qualified
        /// name of the resource file that will be used for looking up display name
        /// and description, and the Ids of those resources inside the resource file.
        /// </summary>
        public LocalizedExportCodeAnalysisRuleAttribute(
            string ruleId,
            string resourceBaseName,
            string displayNameResourceId,
            string descriptionResourceId)
            : base(ruleId, null)
        {
            this.resourceBaseName = resourceBaseName;
            this.displayNameResourceId = displayNameResourceId;
            this.descriptionResourceId = descriptionResourceId;
        }

        /// <summary>
        /// Overrides the standard DisplayName and looks up its value inside a resources file
        /// </summary>
        public override string DisplayName
        {
            get
            {
                if (this.displayName == null)
                {
                    this.displayName = this.GetResourceString(this.displayNameResourceId);
                }

                return this.displayName;
            }
        }

        /// <summary>
        /// Overrides the standard Description and looks up its value inside a resources file
        /// </summary>
        public override string Description
        {
            get
            {
                if (this.descriptionValue == null)
                {
                    this.descriptionValue = this.GetResourceString(this.descriptionResourceId);
                }
                
                return this.descriptionValue;
            }
        }

        /// <summary>
        /// Rules in a different assembly would need to overwrite this
        /// </summary>
        /// <returns></returns>
        private Assembly GetAssembly()
        {
            return this.GetType().Assembly;
        }

        private void EnsureResourceManagerInitialized()
        {
            var resourceAssembly = this.GetAssembly();

            try
            {
                this.resourceManager = new ResourceManager(this.resourceBaseName, resourceAssembly);
            }
            catch (Exception ex)
            {
                var msg = string.Format(CultureInfo.CurrentCulture, RuleResources.CannotCreateResourceManager, this.resourceBaseName, resourceAssembly);
                throw new RuleException(msg, ex);
            }
        }

        private string GetResourceString(string resourceId)
        {
            this.EnsureResourceManagerInitialized();
            return this.resourceManager.GetString(resourceId, CultureInfo.CurrentUICulture);
        }
    }
}
