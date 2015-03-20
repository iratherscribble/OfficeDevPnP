﻿using Microsoft.SharePoint.Client;
using OfficeDevPnP.Core.Framework.Provisioning.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDevPnP.Core.Framework.Provisioning.ObjectHandlers
{
    public class SiteToTemplateConversion
    {
        /// <summary>
        /// Actual implementation of extracting configuration from existing site.
        /// </summary>
        /// <param name="web"></param>
        /// <param name="hiddenObjects"></param>
        /// <returns></returns>
        public ProvisioningTemplate GetRemoteTemplate(Web web)
        {
            // Create empty object
            ProvisioningTemplate template = new ProvisioningTemplate();

            // Get Lists 
            template = new ObjectListInstance().CreateEntities(web, template);
            // Get custom actions
            template = new ObjectCustomActions().CreateEntities(web, template);
            // Get features
            template = new ObjectFeatures().CreateEntities(web, template);
            // Handle composite look
            template = new ObjectComposedLook().CreateEntities(web, template);
            // Handle files
            template = new ObjectFiles().CreateEntities(web, template);

            // In future we could just instantiate all objects which are inherited from object handler base dynamically 

            return template;
        }

        /// <summary>
        /// Actual implementation of the apply templates
        /// </summary>
        /// <param name="web"></param>
        /// <param name="template"></param>
        public void ApplyRemoteTemplate(Web web, ProvisioningTemplate template)
        {
            // Lists
            new ObjectListInstance().ProvisionObjects(web, template);

            // Custom actions
            new ObjectCustomActions().ProvisionObjects(web, template);

            // Features
            new ObjectCustomActions().ProvisionObjects(web, template);

            // Composite look 
            new ObjectComposedLook().ProvisionObjects(web, template);

            // Files
            new ObjectFiles().ProvisionObjects(web, template);
        }
    }
}
