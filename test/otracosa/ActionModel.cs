using Clonator.Helpers;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Clonator.Models
{
    public class ActionModel
    {        
        public virtual string? Action { get; set; }
        public string? OrigEnvironment { get; set; }
        public string? DestEnvironment { get; set; }
        

        private string _destTenant;
        public string DestTenant
        {
            get
            {
                return this._destTenant;
            }
            set
            {
                this._destTenant = value?.Replace("_", ".")?.ToLower();
            }
        }

        private string _origTenant;
        public string OrigTenant
        {
            get
            {
                return this._origTenant;
            }
            set
            {
                this._origTenant = value?.Replace("_", ".")?.ToLower();
            }
        }

        public virtual async Task Run(
            Stopwatch sw,
            ConnectionModel origConnection,
            ConnectionModel destConnection)
        {            
            Logger.Log($"No valid action found.");

            // This method should stay empty
            // Following statement will prevent a compiler warning:
            await Task.FromResult(0);
        }

        public virtual async Task Run(
            Stopwatch sw,
            ConnectionModel destConnection)
        {
            Logger.Log($"No valid action found.");

            // This method should stay empty
            // Following statement will prevent a compiler warning:
            await Task.FromResult(0);
        }

        public virtual bool IsJustDestinationAction()
        {           
            return false;
        }

    }
}
