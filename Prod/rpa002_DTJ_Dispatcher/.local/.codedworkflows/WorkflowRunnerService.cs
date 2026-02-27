using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using rpa002_DTJ_Dispatcher;

[assembly: WorkflowRunnerServiceAttribute(typeof(rpa002_DTJ_Dispatcher.WorkflowRunnerService))]
namespace rpa002_DTJ_Dispatcher
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        public void Main()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Main(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/InitAllSettings.xaml
        /// </summary>
        public (System.Collections.Generic.Dictionary<string, object> out_Config, bool out_bool_existsAlreadyPeriodFolder) InitAllSettings(string in_ConfigFile, string[] in_ConfigSheets)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllSettings.xaml", new Dictionary<string, object>{{"in_ConfigFile", in_ConfigFile}, {"in_ConfigSheets", in_ConfigSheets}}, default, default, default, GetAssemblyName());
            return ((System.Collections.Generic.Dictionary<string, object>)result["out_Config"], (bool)result["out_bool_existsAlreadyPeriodFolder"]);
        }

        /// <summary>
        /// Invokes the Framework/InitAllSettings.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (System.Collections.Generic.Dictionary<string, object> out_Config, bool out_bool_existsAlreadyPeriodFolder) InitAllSettings(string in_ConfigFile, string[] in_ConfigSheets, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllSettings.xaml", new Dictionary<string, object>{{"in_ConfigFile", in_ConfigFile}, {"in_ConfigSheets", in_ConfigSheets}}, default, isolated, default, GetAssemblyName());
            return ((System.Collections.Generic.Dictionary<string, object>)result["out_Config"], (bool)result["out_bool_existsAlreadyPeriodFolder"]);
        }

        /// <summary>
        /// Invokes the Framework/KillAllProcesses.xaml
        /// </summary>
        public void KillAllProcesses()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\KillAllProcesses.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/KillAllProcesses.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void KillAllProcesses(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\KillAllProcesses.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Workflows/File Workflows/Json - Serialize Results.xaml
        /// </summary>
        public void Json___Serialize_Results(System.Collections.Generic.Dictionary<string, object> in_Config, System.Data.DataTable in_dt_results)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\File Workflows\Json - Serialize Results.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_dt_results", in_dt_results}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Workflows/File Workflows/Json - Serialize Results.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Json___Serialize_Results(System.Collections.Generic.Dictionary<string, object> in_Config, System.Data.DataTable in_dt_results, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\File Workflows\Json - Serialize Results.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_dt_results", in_dt_results}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Workflows/Main Workflows/Prepare Period Folder.xaml
        /// </summary>
        public bool Prepare_Period_Folder(System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\Main Workflows\Prepare Period Folder.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, default, default, GetAssemblyName());
            return (bool)result["out_bool_existsAlreadyPeriodFolder"];
        }

        /// <summary>
        /// Invokes the Workflows/Main Workflows/Prepare Period Folder.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public bool Prepare_Period_Folder(System.Collections.Generic.Dictionary<string, object> in_Config, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\Main Workflows\Prepare Period Folder.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, isolated, default, GetAssemblyName());
            return (bool)result["out_bool_existsAlreadyPeriodFolder"];
        }

        /// <summary>
        /// Invokes the Framework/Process.xaml
        /// </summary>
        public (int io_int_countTotal, int io_int_countFailed, int io_int_countSkipped, int io_int_countSuccess) Process(System.Collections.Generic.Dictionary<string, object> in_Config, int io_int_countTotal, int io_int_countFailed, int io_int_countSkipped, int io_int_countSuccess)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\Process.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"io_int_countTotal", io_int_countTotal}, {"io_int_countFailed", io_int_countFailed}, {"io_int_countSkipped", io_int_countSkipped}, {"io_int_countSuccess", io_int_countSuccess}}, default, default, default, GetAssemblyName());
            return ((int)result["io_int_countTotal"], (int)result["io_int_countFailed"], (int)result["io_int_countSkipped"], (int)result["io_int_countSuccess"]);
        }

        /// <summary>
        /// Invokes the Framework/Process.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (int io_int_countTotal, int io_int_countFailed, int io_int_countSkipped, int io_int_countSuccess) Process(System.Collections.Generic.Dictionary<string, object> in_Config, int io_int_countTotal, int io_int_countFailed, int io_int_countSkipped, int io_int_countSuccess, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\Process.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"io_int_countTotal", io_int_countTotal}, {"io_int_countFailed", io_int_countFailed}, {"io_int_countSkipped", io_int_countSkipped}, {"io_int_countSuccess", io_int_countSuccess}}, default, isolated, default, GetAssemblyName());
            return ((int)result["io_int_countTotal"], (int)result["io_int_countFailed"], (int)result["io_int_countSkipped"], (int)result["io_int_countSuccess"]);
        }

        /// <summary>
        /// Invokes the Workflows/Main Workflows/Upload Batch To Queue.xaml
        /// </summary>
        public (System.Data.DataTable io_dt_currentBatch, int io_int_countSuccess, int io_int_countFailed, System.Collections.Generic.Dictionary<string, object> io_dict_txns) Upload_Batch_To_Queue(System.Collections.Generic.List<string> in_list_currentBatchIds, int in_int_currentBatchIndex, int in_int_calcBatches, System.Collections.Generic.Dictionary<string, object> in_Config, System.Data.DataTable io_dt_currentBatch, int io_int_countSuccess, int io_int_countFailed, System.Collections.Generic.Dictionary<string, object> io_dict_txns)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\Main Workflows\Upload Batch To Queue.xaml", new Dictionary<string, object>{{"in_list_currentBatchIds", in_list_currentBatchIds}, {"in_int_currentBatchIndex", in_int_currentBatchIndex}, {"in_int_calcBatches", in_int_calcBatches}, {"in_Config", in_Config}, {"io_dt_currentBatch", io_dt_currentBatch}, {"io_int_countSuccess", io_int_countSuccess}, {"io_int_countFailed", io_int_countFailed}, {"io_dict_txns", io_dict_txns}}, default, default, default, GetAssemblyName());
            return ((System.Data.DataTable)result["io_dt_currentBatch"], (int)result["io_int_countSuccess"], (int)result["io_int_countFailed"], (System.Collections.Generic.Dictionary<string, object>)result["io_dict_txns"]);
        }

        /// <summary>
        /// Invokes the Workflows/Main Workflows/Upload Batch To Queue.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (System.Data.DataTable io_dt_currentBatch, int io_int_countSuccess, int io_int_countFailed, System.Collections.Generic.Dictionary<string, object> io_dict_txns) Upload_Batch_To_Queue(System.Collections.Generic.List<string> in_list_currentBatchIds, int in_int_currentBatchIndex, int in_int_calcBatches, System.Collections.Generic.Dictionary<string, object> in_Config, System.Data.DataTable io_dt_currentBatch, int io_int_countSuccess, int io_int_countFailed, System.Collections.Generic.Dictionary<string, object> io_dict_txns, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\Main Workflows\Upload Batch To Queue.xaml", new Dictionary<string, object>{{"in_list_currentBatchIds", in_list_currentBatchIds}, {"in_int_currentBatchIndex", in_int_currentBatchIndex}, {"in_int_calcBatches", in_int_calcBatches}, {"in_Config", in_Config}, {"io_dt_currentBatch", io_dt_currentBatch}, {"io_int_countSuccess", io_int_countSuccess}, {"io_int_countFailed", io_int_countFailed}, {"io_dict_txns", io_dict_txns}}, default, isolated, default, GetAssemblyName());
            return ((System.Data.DataTable)result["io_dt_currentBatch"], (int)result["io_int_countSuccess"], (int)result["io_int_countFailed"], (System.Collections.Generic.Dictionary<string, object>)result["io_dict_txns"]);
        }

        /// <summary>
        /// Invokes the Workflows/Email Workflows/Email - Send Email.xaml
        /// </summary>
        public void Email___Send_Email(System.Collections.Generic.List<string> in_list_attachments, string in_str_body, string in_str_recipient, string in_str_subject, System.Collections.Generic.Dictionary<string, object> in_Config, string in_str_senderEmail)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\Email Workflows\Email - Send Email.xaml", new Dictionary<string, object>{{"in_list_attachments", in_list_attachments}, {"in_str_body", in_str_body}, {"in_str_recipient", in_str_recipient}, {"in_str_subject", in_str_subject}, {"in_Config", in_Config}, {"in_str_senderEmail", in_str_senderEmail}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Workflows/Email Workflows/Email - Send Email.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Email___Send_Email(System.Collections.Generic.List<string> in_list_attachments, string in_str_body, string in_str_recipient, string in_str_subject, System.Collections.Generic.Dictionary<string, object> in_Config, string in_str_senderEmail, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\Email Workflows\Email - Send Email.xaml", new Dictionary<string, object>{{"in_list_attachments", in_list_attachments}, {"in_str_body", in_str_body}, {"in_str_recipient", in_str_recipient}, {"in_str_subject", in_str_subject}, {"in_Config", in_Config}, {"in_str_senderEmail", in_str_senderEmail}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Workflows/Main Workflows/Prepare And Upload Transactions To Batches.xaml
        /// </summary>
        public (int io_int_countSuccess, int io_int_countFailed, int io_int_countSkipped, int io_int_countTotal) Prepare_And_Upload_Transactions_To_Batches(System.Collections.Generic.Dictionary<string, object> in_Config, int io_int_countSuccess, int io_int_countFailed, int io_int_countSkipped, int io_int_countTotal)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\Main Workflows\Prepare And Upload Transactions To Batches.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"io_int_countSuccess", io_int_countSuccess}, {"io_int_countFailed", io_int_countFailed}, {"io_int_countSkipped", io_int_countSkipped}, {"io_int_countTotal", io_int_countTotal}}, default, default, default, GetAssemblyName());
            return ((int)result["io_int_countSuccess"], (int)result["io_int_countFailed"], (int)result["io_int_countSkipped"], (int)result["io_int_countTotal"]);
        }

        /// <summary>
        /// Invokes the Workflows/Main Workflows/Prepare And Upload Transactions To Batches.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (int io_int_countSuccess, int io_int_countFailed, int io_int_countSkipped, int io_int_countTotal) Prepare_And_Upload_Transactions_To_Batches(System.Collections.Generic.Dictionary<string, object> in_Config, int io_int_countSuccess, int io_int_countFailed, int io_int_countSkipped, int io_int_countTotal, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\Main Workflows\Prepare And Upload Transactions To Batches.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"io_int_countSuccess", io_int_countSuccess}, {"io_int_countFailed", io_int_countFailed}, {"io_int_countSkipped", io_int_countSkipped}, {"io_int_countTotal", io_int_countTotal}}, default, isolated, default, GetAssemblyName());
            return ((int)result["io_int_countSuccess"], (int)result["io_int_countFailed"], (int)result["io_int_countSkipped"], (int)result["io_int_countTotal"]);
        }

        /// <summary>
        /// Invokes the Framework/InitAllApplications.xaml
        /// </summary>
        public void InitAllApplications()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllApplications.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/InitAllApplications.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void InitAllApplications(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllApplications.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Workflows/Main Workflows/Extract Teilnehmerlisten Results.xaml
        /// </summary>
        public System.Data.DataTable Extract_Teilnehmerlisten_Results(System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\Main Workflows\Extract Teilnehmerlisten Results.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, default, default, GetAssemblyName());
            return (System.Data.DataTable)result["out_dt_results"];
        }

        /// <summary>
        /// Invokes the Workflows/Main Workflows/Extract Teilnehmerlisten Results.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Data.DataTable Extract_Teilnehmerlisten_Results(System.Collections.Generic.Dictionary<string, object> in_Config, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\Main Workflows\Extract Teilnehmerlisten Results.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, isolated, default, GetAssemblyName());
            return (System.Data.DataTable)result["out_dt_results"];
        }

        /// <summary>
        /// Invokes the Framework/CloseAllApplications.xaml
        /// </summary>
        public void CloseAllApplications()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\CloseAllApplications.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/CloseAllApplications.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void CloseAllApplications(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\CloseAllApplications.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}