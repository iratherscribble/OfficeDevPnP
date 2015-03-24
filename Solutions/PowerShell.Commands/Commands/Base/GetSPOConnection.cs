using System.Management.Automation;
using OfficeDevPnP.PowerShell.CmdletHelpAttributes;

namespace OfficeDevPnP.PowerShell.Commands.Base
{
    [Cmdlet(VerbsCommon.Get, "SPOConnection")]
    [CmdletHelp("Returns the current in-memory connection", Category = "Base Cmdlets")]
    public class GetSPOConnection : PSCmdlet
    {
        protected override void ProcessRecord()
        {
            WriteObject(SPOnlineConnection.CurrentConnection);
        }
    }
}
