﻿using Microsoft.SharePoint.Client;
using OfficeDevPnP.Core.Framework.Provisioning.Extensibility;
using OfficeDevPnP.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDevPnP.Core.Framework.Provisioning.ObjectHandlers
{
    /// <summary>
    /// Extensibility Provider CallOut
    /// </summary>
    class ObjectExtensibilityProviders : ObjectHandlerBase
    {
        ExtensibilityManager _extManager = new ExtensibilityManager();

        public override void ProvisionObjects(Microsoft.SharePoint.Client.Web web, Model.ProvisioningTemplate template)
        {
            var _ctx = web.Context as ClientContext;
            foreach(var _provider in template.Providers)
            {
                try
                {
                    _extManager.ExecuteExtensibilityCallOut(_ctx, _provider, template);
                }
                catch(Exception ex)
                {
                    Log.Error(Constants.LOGGING_SOURCE, ex.Message);
                }
            }
        }

        public override Model.ProvisioningTemplate CreateEntities(Microsoft.SharePoint.Client.Web web, Model.ProvisioningTemplate template)
        {
            throw new NotImplementedException();
        }
    }
}
