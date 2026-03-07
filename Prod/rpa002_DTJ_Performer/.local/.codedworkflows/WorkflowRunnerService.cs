using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using rpa002_DTJ_Performer;

[assembly: WorkflowRunnerServiceAttribute(typeof(rpa002_DTJ_Performer.WorkflowRunnerService))]
namespace rpa002_DTJ_Performer
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the Workflows/Util Workflows/Normalize Name.xaml
        /// </summary>
        public System.Collections.Generic.List<string> Normalize_Name(string in_str_originalName, System.Collections.Generic.List<string> io_list_normalizedNames)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\Util Workflows\Normalize Name.xaml", new Dictionary<string, object>{{"in_str_originalName", in_str_originalName}, {"io_list_normalizedNames", io_list_normalizedNames}}, default, default, default, GetAssemblyName());
            return (System.Collections.Generic.List<string>)result["io_list_normalizedNames"];
        }

        /// <summary>
        /// Invokes the Workflows/Util Workflows/Normalize Name.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Collections.Generic.List<string> Normalize_Name(string in_str_originalName, System.Collections.Generic.List<string> io_list_normalizedNames, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\Util Workflows\Normalize Name.xaml", new Dictionary<string, object>{{"in_str_originalName", in_str_originalName}, {"io_list_normalizedNames", io_list_normalizedNames}}, default, isolated, default, GetAssemblyName());
            return (System.Collections.Generic.List<string>)result["io_list_normalizedNames"];
        }

        /// <summary>
        /// Invokes the Workflows/SAP Workflows/SAP - Navigate Destination Menu.xaml
        /// </summary>
        public UiPath.Core.UiElement SAP___Navigate_Destination_Menu(string in_str_destMenuDetails, string in_str_mainMenuDetails, UiPath.Core.UiElement io_uie_sapWnd)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\SAP Workflows\SAP - Navigate Destination Menu.xaml", new Dictionary<string, object>{{"in_str_destMenuDetails", in_str_destMenuDetails}, {"in_str_mainMenuDetails", in_str_mainMenuDetails}, {"io_uie_sapWnd", io_uie_sapWnd}}, default, default, default, GetAssemblyName());
            return (UiPath.Core.UiElement)result["io_uie_sapWnd"];
        }

        /// <summary>
        /// Invokes the Workflows/SAP Workflows/SAP - Navigate Destination Menu.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public UiPath.Core.UiElement SAP___Navigate_Destination_Menu(string in_str_destMenuDetails, string in_str_mainMenuDetails, UiPath.Core.UiElement io_uie_sapWnd, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\SAP Workflows\SAP - Navigate Destination Menu.xaml", new Dictionary<string, object>{{"in_str_destMenuDetails", in_str_destMenuDetails}, {"in_str_mainMenuDetails", in_str_mainMenuDetails}, {"io_uie_sapWnd", io_uie_sapWnd}}, default, isolated, default, GetAssemblyName());
            return (UiPath.Core.UiElement)result["io_uie_sapWnd"];
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
        /// Invokes the Workflows/Util Workflows/Normalize Date.xaml
        /// </summary>
        public string Normalize_Date(string io_str_date)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\Util Workflows\Normalize Date.xaml", new Dictionary<string, object>{{"io_str_date", io_str_date}}, default, default, default, GetAssemblyName());
            return (string)result["io_str_date"];
        }

        /// <summary>
        /// Invokes the Workflows/Util Workflows/Normalize Date.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public string Normalize_Date(string io_str_date, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\Util Workflows\Normalize Date.xaml", new Dictionary<string, object>{{"io_str_date", io_str_date}}, default, isolated, default, GetAssemblyName());
            return (string)result["io_str_date"];
        }

        /// <summary>
        /// Invokes the Workflows/SAP Workflows/SAP - Login.xaml
        /// </summary>
        public UiPath.Core.UiElement SAP___Login(System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.UiElement io_uie_sapWnd)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\SAP Workflows\SAP - Login.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"io_uie_sapWnd", io_uie_sapWnd}}, default, default, default, GetAssemblyName());
            return (UiPath.Core.UiElement)result["io_uie_sapWnd"];
        }

        /// <summary>
        /// Invokes the Workflows/SAP Workflows/SAP - Login.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public UiPath.Core.UiElement SAP___Login(System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.UiElement io_uie_sapWnd, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\SAP Workflows\SAP - Login.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"io_uie_sapWnd", io_uie_sapWnd}}, default, isolated, default, GetAssemblyName());
            return (UiPath.Core.UiElement)result["io_uie_sapWnd"];
        }

        /// <summary>
        /// Invokes the Framework/RetryCurrentTransaction.xaml
        /// </summary>
        public (int io_RetryNumber, int io_TransactionNumber) RetryCurrentTransaction(System.Collections.Generic.Dictionary<string, object> in_Config, System.Exception in_SystemException, bool in_QueueRetry, int io_RetryNumber, int io_TransactionNumber)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\RetryCurrentTransaction.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_SystemException", in_SystemException}, {"in_QueueRetry", in_QueueRetry}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}}, default, default, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"]);
        }

        /// <summary>
        /// Invokes the Framework/RetryCurrentTransaction.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (int io_RetryNumber, int io_TransactionNumber) RetryCurrentTransaction(System.Collections.Generic.Dictionary<string, object> in_Config, System.Exception in_SystemException, bool in_QueueRetry, int io_RetryNumber, int io_TransactionNumber, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\RetryCurrentTransaction.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_SystemException", in_SystemException}, {"in_QueueRetry", in_QueueRetry}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}}, default, isolated, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"]);
        }

        /// <summary>
        /// Invokes the Workflows/SAP Workflows/SAP - Search Advanced Search.xaml
        /// </summary>
        public (System.Data.DataTable out_dt_searchResults, UiPath.Core.UiElement io_uie_sapWnd) SAP___Search_Advanced_Search(System.Collections.Generic.List<string> in_list_normalizedLastnames, System.Collections.Generic.List<string> in_list_normalizedFirstnames, string in_str_birthdate, UiPath.Core.UiElement io_uie_sapWnd)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\SAP Workflows\SAP - Search Advanced Search.xaml", new Dictionary<string, object>{{"in_list_normalizedLastnames", in_list_normalizedLastnames}, {"in_list_normalizedFirstnames", in_list_normalizedFirstnames}, {"in_str_birthdate", in_str_birthdate}, {"io_uie_sapWnd", io_uie_sapWnd}}, default, default, default, GetAssemblyName());
            return ((System.Data.DataTable)result["out_dt_searchResults"], (UiPath.Core.UiElement)result["io_uie_sapWnd"]);
        }

        /// <summary>
        /// Invokes the Workflows/SAP Workflows/SAP - Search Advanced Search.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (System.Data.DataTable out_dt_searchResults, UiPath.Core.UiElement io_uie_sapWnd) SAP___Search_Advanced_Search(System.Collections.Generic.List<string> in_list_normalizedLastnames, System.Collections.Generic.List<string> in_list_normalizedFirstnames, string in_str_birthdate, UiPath.Core.UiElement io_uie_sapWnd, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\SAP Workflows\SAP - Search Advanced Search.xaml", new Dictionary<string, object>{{"in_list_normalizedLastnames", in_list_normalizedLastnames}, {"in_list_normalizedFirstnames", in_list_normalizedFirstnames}, {"in_str_birthdate", in_str_birthdate}, {"io_uie_sapWnd", io_uie_sapWnd}}, default, isolated, default, GetAssemblyName());
            return ((System.Data.DataTable)result["out_dt_searchResults"], (UiPath.Core.UiElement)result["io_uie_sapWnd"]);
        }

        /// <summary>
        /// Invokes the Workflows/SAP Workflows/SAP - Multiple Selection.xaml
        /// </summary>
        public void SAP___Multiple_Selection(System.Collections.Generic.List<string> in_list_inputs)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\SAP Workflows\SAP - Multiple Selection.xaml", new Dictionary<string, object>{{"in_list_inputs", in_list_inputs}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Workflows/SAP Workflows/SAP - Multiple Selection.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void SAP___Multiple_Selection(System.Collections.Generic.List<string> in_list_inputs, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\SAP Workflows\SAP - Multiple Selection.xaml", new Dictionary<string, object>{{"in_list_inputs", in_list_inputs}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Workflows/Main Workflows/6.6 - Check Multiple Active Personalnumbers.xaml
        /// </summary>
        public (string out_str_personalnumber, UiPath.Core.UiElement io_uie_sapWnd) _6_6___Check_Multiple_Active_Personalnumbers(string in_str_birthdate, string in_str_firstname, string in_str_lastname, System.Collections.Generic.Dictionary<string, object> in_Config, System.Collections.Generic.List<string> in_list_normalizedLastnames, UiPath.Core.UiElement io_uie_sapWnd)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\Main Workflows\6.6 - Check Multiple Active Personalnumbers.xaml", new Dictionary<string, object>{{"in_str_birthdate", in_str_birthdate}, {"in_str_firstname", in_str_firstname}, {"in_str_lastname", in_str_lastname}, {"in_Config", in_Config}, {"in_list_normalizedLastnames", in_list_normalizedLastnames}, {"io_uie_sapWnd", io_uie_sapWnd}}, default, default, default, GetAssemblyName());
            return ((string)result["out_str_personalnumber"], (UiPath.Core.UiElement)result["io_uie_sapWnd"]);
        }

        /// <summary>
        /// Invokes the Workflows/Main Workflows/6.6 - Check Multiple Active Personalnumbers.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (string out_str_personalnumber, UiPath.Core.UiElement io_uie_sapWnd) _6_6___Check_Multiple_Active_Personalnumbers(string in_str_birthdate, string in_str_firstname, string in_str_lastname, System.Collections.Generic.Dictionary<string, object> in_Config, System.Collections.Generic.List<string> in_list_normalizedLastnames, UiPath.Core.UiElement io_uie_sapWnd, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\Main Workflows\6.6 - Check Multiple Active Personalnumbers.xaml", new Dictionary<string, object>{{"in_str_birthdate", in_str_birthdate}, {"in_str_firstname", in_str_firstname}, {"in_str_lastname", in_str_lastname}, {"in_Config", in_Config}, {"in_list_normalizedLastnames", in_list_normalizedLastnames}, {"io_uie_sapWnd", io_uie_sapWnd}}, default, isolated, default, GetAssemblyName());
            return ((string)result["out_str_personalnumber"], (UiPath.Core.UiElement)result["io_uie_sapWnd"]);
        }

        /// <summary>
        /// Invokes the Framework/InitAllSettings.xaml
        /// </summary>
        public (System.Collections.Generic.Dictionary<string, object> out_Config, System.Collections.Generic.Dictionary<string, object> out_dict_txns, System.Collections.Generic.Dictionary<string, object> out_dict_statistics) InitAllSettings(string in_ConfigFile, string[] in_ConfigSheets)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllSettings.xaml", new Dictionary<string, object>{{"in_ConfigFile", in_ConfigFile}, {"in_ConfigSheets", in_ConfigSheets}}, default, default, default, GetAssemblyName());
            return ((System.Collections.Generic.Dictionary<string, object>)result["out_Config"], (System.Collections.Generic.Dictionary<string, object>)result["out_dict_txns"], (System.Collections.Generic.Dictionary<string, object>)result["out_dict_statistics"]);
        }

        /// <summary>
        /// Invokes the Framework/InitAllSettings.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (System.Collections.Generic.Dictionary<string, object> out_Config, System.Collections.Generic.Dictionary<string, object> out_dict_txns, System.Collections.Generic.Dictionary<string, object> out_dict_statistics) InitAllSettings(string in_ConfigFile, string[] in_ConfigSheets, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllSettings.xaml", new Dictionary<string, object>{{"in_ConfigFile", in_ConfigFile}, {"in_ConfigSheets", in_ConfigSheets}}, default, isolated, default, GetAssemblyName());
            return ((System.Collections.Generic.Dictionary<string, object>)result["out_Config"], (System.Collections.Generic.Dictionary<string, object>)result["out_dict_txns"], (System.Collections.Generic.Dictionary<string, object>)result["out_dict_statistics"]);
        }

        /// <summary>
        /// Invokes the Workflows/SAP Workflows/SAP - Create Leihgabe.xaml
        /// </summary>
        public (UiPath.Core.UiElement io_uie_sapWnd, string io_str_finalBemerkung) SAP___Create_Leihgabe(string in_str_startdate, string in_str_enddate, string in_str_abonumber, string in_str_personalnumber, UiPath.Core.UiElement io_uie_sapWnd, string io_str_finalBemerkung)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\SAP Workflows\SAP - Create Leihgabe.xaml", new Dictionary<string, object>{{"in_str_startdate", in_str_startdate}, {"in_str_enddate", in_str_enddate}, {"in_str_abonumber", in_str_abonumber}, {"in_str_personalnumber", in_str_personalnumber}, {"io_uie_sapWnd", io_uie_sapWnd}, {"io_str_finalBemerkung", io_str_finalBemerkung}}, default, default, default, GetAssemblyName());
            return ((UiPath.Core.UiElement)result["io_uie_sapWnd"], (string)result["io_str_finalBemerkung"]);
        }

        /// <summary>
        /// Invokes the Workflows/SAP Workflows/SAP - Create Leihgabe.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (UiPath.Core.UiElement io_uie_sapWnd, string io_str_finalBemerkung) SAP___Create_Leihgabe(string in_str_startdate, string in_str_enddate, string in_str_abonumber, string in_str_personalnumber, UiPath.Core.UiElement io_uie_sapWnd, string io_str_finalBemerkung, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\SAP Workflows\SAP - Create Leihgabe.xaml", new Dictionary<string, object>{{"in_str_startdate", in_str_startdate}, {"in_str_enddate", in_str_enddate}, {"in_str_abonumber", in_str_abonumber}, {"in_str_personalnumber", in_str_personalnumber}, {"io_uie_sapWnd", io_uie_sapWnd}, {"io_str_finalBemerkung", io_str_finalBemerkung}}, default, isolated, default, GetAssemblyName());
            return ((UiPath.Core.UiElement)result["io_uie_sapWnd"], (string)result["io_str_finalBemerkung"]);
        }

        /// <summary>
        /// Invokes the Workflows/Main Workflows/6.4 - Matching Data With Personalnumber + Lastname Or Birthdate.xaml
        /// </summary>
        public (UiPath.Core.UiElement io_uie_sapWnd, bool io_bool_matchFound, string io_str_personalnumber, string io_str_birthdate, string io_str_firstname, string io_str_lastname, string io_str_finalBemerkung) _6_4___Matching_Data_With_Personalnumber___Lastname_Or_Birthdate(System.Collections.Generic.List<string> in_list_normalizedLastnames, System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.UiElement io_uie_sapWnd, bool io_bool_matchFound, string io_str_personalnumber, string io_str_birthdate, string io_str_firstname, string io_str_lastname, string io_str_finalBemerkung)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\Main Workflows\6.4 - Matching Data With Personalnumber + Lastname Or Birthdate.xaml", new Dictionary<string, object>{{"in_list_normalizedLastnames", in_list_normalizedLastnames}, {"in_Config", in_Config}, {"io_uie_sapWnd", io_uie_sapWnd}, {"io_bool_matchFound", io_bool_matchFound}, {"io_str_personalnumber", io_str_personalnumber}, {"io_str_birthdate", io_str_birthdate}, {"io_str_firstname", io_str_firstname}, {"io_str_lastname", io_str_lastname}, {"io_str_finalBemerkung", io_str_finalBemerkung}}, default, default, default, GetAssemblyName());
            return ((UiPath.Core.UiElement)result["io_uie_sapWnd"], (bool)result["io_bool_matchFound"], (string)result["io_str_personalnumber"], (string)result["io_str_birthdate"], (string)result["io_str_firstname"], (string)result["io_str_lastname"], (string)result["io_str_finalBemerkung"]);
        }

        /// <summary>
        /// Invokes the Workflows/Main Workflows/6.4 - Matching Data With Personalnumber + Lastname Or Birthdate.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (UiPath.Core.UiElement io_uie_sapWnd, bool io_bool_matchFound, string io_str_personalnumber, string io_str_birthdate, string io_str_firstname, string io_str_lastname, string io_str_finalBemerkung) _6_4___Matching_Data_With_Personalnumber___Lastname_Or_Birthdate(System.Collections.Generic.List<string> in_list_normalizedLastnames, System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.UiElement io_uie_sapWnd, bool io_bool_matchFound, string io_str_personalnumber, string io_str_birthdate, string io_str_firstname, string io_str_lastname, string io_str_finalBemerkung, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\Main Workflows\6.4 - Matching Data With Personalnumber + Lastname Or Birthdate.xaml", new Dictionary<string, object>{{"in_list_normalizedLastnames", in_list_normalizedLastnames}, {"in_Config", in_Config}, {"io_uie_sapWnd", io_uie_sapWnd}, {"io_bool_matchFound", io_bool_matchFound}, {"io_str_personalnumber", io_str_personalnumber}, {"io_str_birthdate", io_str_birthdate}, {"io_str_firstname", io_str_firstname}, {"io_str_lastname", io_str_lastname}, {"io_str_finalBemerkung", io_str_finalBemerkung}}, default, isolated, default, GetAssemblyName());
            return ((UiPath.Core.UiElement)result["io_uie_sapWnd"], (bool)result["io_bool_matchFound"], (string)result["io_str_personalnumber"], (string)result["io_str_birthdate"], (string)result["io_str_firstname"], (string)result["io_str_lastname"], (string)result["io_str_finalBemerkung"]);
        }

        /// <summary>
        /// Invokes the Framework/Process.xaml
        /// </summary>
        public (System.Collections.Generic.Dictionary<string, object> io_dict_txnsItem, UiPath.Core.UiElement io_uie_sapWnd, System.Diagnostics.Stopwatch io_sw_txnWatch) Process(System.Collections.Generic.Dictionary<string, object> in_Config, string in_TransactionID, System.Collections.Generic.Dictionary<string, object> io_dict_txns, System.Collections.Generic.Dictionary<string, object> io_dict_txnsItem, UiPath.Core.UiElement io_uie_sapWnd, System.Diagnostics.Stopwatch io_sw_txnWatch)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\Process.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_TransactionID", in_TransactionID}, {"io_dict_txns", io_dict_txns}, {"io_dict_txnsItem", io_dict_txnsItem}, {"io_uie_sapWnd", io_uie_sapWnd}, {"io_sw_txnWatch", io_sw_txnWatch}}, default, default, default, GetAssemblyName());
            return ((System.Collections.Generic.Dictionary<string, object>)result["io_dict_txnsItem"], (UiPath.Core.UiElement)result["io_uie_sapWnd"], (System.Diagnostics.Stopwatch)result["io_sw_txnWatch"]);
        }

        /// <summary>
        /// Invokes the Framework/Process.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (System.Collections.Generic.Dictionary<string, object> io_dict_txnsItem, UiPath.Core.UiElement io_uie_sapWnd, System.Diagnostics.Stopwatch io_sw_txnWatch) Process(System.Collections.Generic.Dictionary<string, object> in_Config, string in_TransactionID, System.Collections.Generic.Dictionary<string, object> io_dict_txns, System.Collections.Generic.Dictionary<string, object> io_dict_txnsItem, UiPath.Core.UiElement io_uie_sapWnd, System.Diagnostics.Stopwatch io_sw_txnWatch, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\Process.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_TransactionID", in_TransactionID}, {"io_dict_txns", io_dict_txns}, {"io_dict_txnsItem", io_dict_txnsItem}, {"io_uie_sapWnd", io_uie_sapWnd}, {"io_sw_txnWatch", io_sw_txnWatch}}, default, isolated, default, GetAssemblyName());
            return ((System.Collections.Generic.Dictionary<string, object>)result["io_dict_txnsItem"], (UiPath.Core.UiElement)result["io_uie_sapWnd"], (System.Diagnostics.Stopwatch)result["io_sw_txnWatch"]);
        }

        /// <summary>
        /// Invokes the Workflows/SAP Workflows/SAP - Search With Personal Data.xaml
        /// </summary>
        public (string out_str_sapStatusMessage, bool out_bool_searchFound, UiPath.Core.UiElement io_uie_sapWnd) SAP___Search_With_Personal_Data(string in_str_personalnumber, string in_str_infotype, string in_str_subtype, UiPath.Core.UiElement io_uie_sapWnd)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\SAP Workflows\SAP - Search With Personal Data.xaml", new Dictionary<string, object>{{"in_str_personalnumber", in_str_personalnumber}, {"in_str_infotype", in_str_infotype}, {"in_str_subtype", in_str_subtype}, {"io_uie_sapWnd", io_uie_sapWnd}}, default, default, default, GetAssemblyName());
            return ((string)result["out_str_sapStatusMessage"], (bool)result["out_bool_searchFound"], (UiPath.Core.UiElement)result["io_uie_sapWnd"]);
        }

        /// <summary>
        /// Invokes the Workflows/SAP Workflows/SAP - Search With Personal Data.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (string out_str_sapStatusMessage, bool out_bool_searchFound, UiPath.Core.UiElement io_uie_sapWnd) SAP___Search_With_Personal_Data(string in_str_personalnumber, string in_str_infotype, string in_str_subtype, UiPath.Core.UiElement io_uie_sapWnd, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\SAP Workflows\SAP - Search With Personal Data.xaml", new Dictionary<string, object>{{"in_str_personalnumber", in_str_personalnumber}, {"in_str_infotype", in_str_infotype}, {"in_str_subtype", in_str_subtype}, {"io_uie_sapWnd", io_uie_sapWnd}}, default, isolated, default, GetAssemblyName());
            return ((string)result["out_str_sapStatusMessage"], (bool)result["out_bool_searchFound"], (UiPath.Core.UiElement)result["io_uie_sapWnd"]);
        }

        /// <summary>
        /// Invokes the Workflows/SAP Workflows/SAP - Copy Data From Personal Details.xaml
        /// </summary>
        public (string out_str_personalnumberSAP, string out_str_lastnameSAP, string out_str_firstnameSAP, string out_str_birthdateSAP, UiPath.Core.UiElement io_uie_sapWnd) SAP___Copy_Data_From_Personal_Details(UiPath.Core.UiElement io_uie_sapWnd)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\SAP Workflows\SAP - Copy Data From Personal Details.xaml", new Dictionary<string, object>{{"io_uie_sapWnd", io_uie_sapWnd}}, default, default, default, GetAssemblyName());
            return ((string)result["out_str_personalnumberSAP"], (string)result["out_str_lastnameSAP"], (string)result["out_str_firstnameSAP"], (string)result["out_str_birthdateSAP"], (UiPath.Core.UiElement)result["io_uie_sapWnd"]);
        }

        /// <summary>
        /// Invokes the Workflows/SAP Workflows/SAP - Copy Data From Personal Details.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (string out_str_personalnumberSAP, string out_str_lastnameSAP, string out_str_firstnameSAP, string out_str_birthdateSAP, UiPath.Core.UiElement io_uie_sapWnd) SAP___Copy_Data_From_Personal_Details(UiPath.Core.UiElement io_uie_sapWnd, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\SAP Workflows\SAP - Copy Data From Personal Details.xaml", new Dictionary<string, object>{{"io_uie_sapWnd", io_uie_sapWnd}}, default, isolated, default, GetAssemblyName());
            return ((string)result["out_str_personalnumberSAP"], (string)result["out_str_lastnameSAP"], (string)result["out_str_firstnameSAP"], (string)result["out_str_birthdateSAP"], (UiPath.Core.UiElement)result["io_uie_sapWnd"]);
        }

        /// <summary>
        /// Invokes the Workflows/Main Workflows/6.5 - Matching Data With Firstname + Lastname + Birthdate.xaml
        /// </summary>
        public (UiPath.Core.UiElement io_uie_sapWnd, string io_str_finalBemerkung, string io_str_birthdate, string io_str_personalnumber, string io_str_firstname, string io_str_lastname, bool io_bool_matchFound) _6_5___Matching_Data_With_Firstname___Lastname___Birthdate(System.Collections.Generic.List<string> in_list_normalizedFirstnames, System.Collections.Generic.List<string> in_list_normalizedLastnames, System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.UiElement io_uie_sapWnd, string io_str_finalBemerkung, string io_str_birthdate, string io_str_personalnumber, string io_str_firstname, string io_str_lastname, bool io_bool_matchFound)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\Main Workflows\6.5 - Matching Data With Firstname + Lastname + Birthdate.xaml", new Dictionary<string, object>{{"in_list_normalizedFirstnames", in_list_normalizedFirstnames}, {"in_list_normalizedLastnames", in_list_normalizedLastnames}, {"in_Config", in_Config}, {"io_uie_sapWnd", io_uie_sapWnd}, {"io_str_finalBemerkung", io_str_finalBemerkung}, {"io_str_birthdate", io_str_birthdate}, {"io_str_personalnumber", io_str_personalnumber}, {"io_str_firstname", io_str_firstname}, {"io_str_lastname", io_str_lastname}, {"io_bool_matchFound", io_bool_matchFound}}, default, default, default, GetAssemblyName());
            return ((UiPath.Core.UiElement)result["io_uie_sapWnd"], (string)result["io_str_finalBemerkung"], (string)result["io_str_birthdate"], (string)result["io_str_personalnumber"], (string)result["io_str_firstname"], (string)result["io_str_lastname"], (bool)result["io_bool_matchFound"]);
        }

        /// <summary>
        /// Invokes the Workflows/Main Workflows/6.5 - Matching Data With Firstname + Lastname + Birthdate.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (UiPath.Core.UiElement io_uie_sapWnd, string io_str_finalBemerkung, string io_str_birthdate, string io_str_personalnumber, string io_str_firstname, string io_str_lastname, bool io_bool_matchFound) _6_5___Matching_Data_With_Firstname___Lastname___Birthdate(System.Collections.Generic.List<string> in_list_normalizedFirstnames, System.Collections.Generic.List<string> in_list_normalizedLastnames, System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.UiElement io_uie_sapWnd, string io_str_finalBemerkung, string io_str_birthdate, string io_str_personalnumber, string io_str_firstname, string io_str_lastname, bool io_bool_matchFound, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\Main Workflows\6.5 - Matching Data With Firstname + Lastname + Birthdate.xaml", new Dictionary<string, object>{{"in_list_normalizedFirstnames", in_list_normalizedFirstnames}, {"in_list_normalizedLastnames", in_list_normalizedLastnames}, {"in_Config", in_Config}, {"io_uie_sapWnd", io_uie_sapWnd}, {"io_str_finalBemerkung", io_str_finalBemerkung}, {"io_str_birthdate", io_str_birthdate}, {"io_str_personalnumber", io_str_personalnumber}, {"io_str_firstname", io_str_firstname}, {"io_str_lastname", io_str_lastname}, {"io_bool_matchFound", io_bool_matchFound}}, default, isolated, default, GetAssemblyName());
            return ((UiPath.Core.UiElement)result["io_uie_sapWnd"], (string)result["io_str_finalBemerkung"], (string)result["io_str_birthdate"], (string)result["io_str_personalnumber"], (string)result["io_str_firstname"], (string)result["io_str_lastname"], (bool)result["io_bool_matchFound"]);
        }

        /// <summary>
        /// Invokes the Workflows/File Workflows/Json - Update Transactions Statistics.xaml
        /// </summary>
        public System.Collections.Generic.Dictionary<string, object> Json___Update_Transactions_Statistics(System.Collections.Generic.Dictionary<string, object> in_dict_txns, bool in_bool_shouldSumDuration, System.Collections.Generic.Dictionary<string, object> io_dict_statistics)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\File Workflows\Json - Update Transactions Statistics.xaml", new Dictionary<string, object>{{"in_dict_txns", in_dict_txns}, {"in_bool_shouldSumDuration", in_bool_shouldSumDuration}, {"io_dict_statistics", io_dict_statistics}}, default, default, default, GetAssemblyName());
            return (System.Collections.Generic.Dictionary<string, object>)result["io_dict_statistics"];
        }

        /// <summary>
        /// Invokes the Workflows/File Workflows/Json - Update Transactions Statistics.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Collections.Generic.Dictionary<string, object> Json___Update_Transactions_Statistics(System.Collections.Generic.Dictionary<string, object> in_dict_txns, bool in_bool_shouldSumDuration, System.Collections.Generic.Dictionary<string, object> io_dict_statistics, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\File Workflows\Json - Update Transactions Statistics.xaml", new Dictionary<string, object>{{"in_dict_txns", in_dict_txns}, {"in_bool_shouldSumDuration", in_bool_shouldSumDuration}, {"io_dict_statistics", io_dict_statistics}}, default, isolated, default, GetAssemblyName());
            return (System.Collections.Generic.Dictionary<string, object>)result["io_dict_statistics"];
        }

        /// <summary>
        /// Invokes the Workflows/File Workflows/Json - Persist Transaction In Txns And In-Memory.xaml
        /// </summary>
        public System.Collections.Generic.Dictionary<string, object> Json___Persist_Transaction_In_Txns_And_In_Memory(System.Collections.Generic.Dictionary<string, object> in_Config, System.Collections.Generic.Dictionary<string, object> in_dict_txnsItem, string in_str_txnsItemKey, System.Collections.Generic.Dictionary<string, object> io_dict_txns)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\File Workflows\Json - Persist Transaction In Txns And In-Memory.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_dict_txnsItem", in_dict_txnsItem}, {"in_str_txnsItemKey", in_str_txnsItemKey}, {"io_dict_txns", io_dict_txns}}, default, default, default, GetAssemblyName());
            return (System.Collections.Generic.Dictionary<string, object>)result["io_dict_txns"];
        }

        /// <summary>
        /// Invokes the Workflows/File Workflows/Json - Persist Transaction In Txns And In-Memory.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Collections.Generic.Dictionary<string, object> Json___Persist_Transaction_In_Txns_And_In_Memory(System.Collections.Generic.Dictionary<string, object> in_Config, System.Collections.Generic.Dictionary<string, object> in_dict_txnsItem, string in_str_txnsItemKey, System.Collections.Generic.Dictionary<string, object> io_dict_txns, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\File Workflows\Json - Persist Transaction In Txns And In-Memory.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_dict_txnsItem", in_dict_txnsItem}, {"in_str_txnsItemKey", in_str_txnsItemKey}, {"io_dict_txns", io_dict_txns}}, default, isolated, default, GetAssemblyName());
            return (System.Collections.Generic.Dictionary<string, object>)result["io_dict_txns"];
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
        /// Invokes the Workflows/SAP Workflows/SAP - Update Leihgabe.xaml
        /// </summary>
        public (UiPath.Core.UiElement io_uie_sapWnd, string io_str_finalBemerkung) SAP___Update_Leihgabe(int in_int_rowIndex, string in_str_startdate, string in_str_enddate, string in_str_abonumber, string in_str_personalnumber, UiPath.Core.UiElement io_uie_sapWnd, string io_str_finalBemerkung)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\SAP Workflows\SAP - Update Leihgabe.xaml", new Dictionary<string, object>{{"in_int_rowIndex", in_int_rowIndex}, {"in_str_startdate", in_str_startdate}, {"in_str_enddate", in_str_enddate}, {"in_str_abonumber", in_str_abonumber}, {"in_str_personalnumber", in_str_personalnumber}, {"io_uie_sapWnd", io_uie_sapWnd}, {"io_str_finalBemerkung", io_str_finalBemerkung}}, default, default, default, GetAssemblyName());
            return ((UiPath.Core.UiElement)result["io_uie_sapWnd"], (string)result["io_str_finalBemerkung"]);
        }

        /// <summary>
        /// Invokes the Workflows/SAP Workflows/SAP - Update Leihgabe.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (UiPath.Core.UiElement io_uie_sapWnd, string io_str_finalBemerkung) SAP___Update_Leihgabe(int in_int_rowIndex, string in_str_startdate, string in_str_enddate, string in_str_abonumber, string in_str_personalnumber, UiPath.Core.UiElement io_uie_sapWnd, string io_str_finalBemerkung, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\SAP Workflows\SAP - Update Leihgabe.xaml", new Dictionary<string, object>{{"in_int_rowIndex", in_int_rowIndex}, {"in_str_startdate", in_str_startdate}, {"in_str_enddate", in_str_enddate}, {"in_str_abonumber", in_str_abonumber}, {"in_str_personalnumber", in_str_personalnumber}, {"io_uie_sapWnd", io_uie_sapWnd}, {"io_str_finalBemerkung", io_str_finalBemerkung}}, default, isolated, default, GetAssemblyName());
            return ((UiPath.Core.UiElement)result["io_uie_sapWnd"], (string)result["io_str_finalBemerkung"]);
        }

        /// <summary>
        /// Invokes the Workflows/Main Workflows/6.3 - Matching Data With Abonumber.xaml
        /// </summary>
        public (UiPath.Core.UiElement io_uie_sapWnd, string io_str_lastname, string io_str_firstname, string io_str_personalnumber, string io_str_birthdate, bool io_bool_matchFound, string io_str_finalBemerkung) _6_3___Matching_Data_With_Abonumber(string in_str_abonumber, System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.UiElement io_uie_sapWnd, string io_str_lastname, string io_str_firstname, string io_str_personalnumber, string io_str_birthdate, bool io_bool_matchFound, string io_str_finalBemerkung)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\Main Workflows\6.3 - Matching Data With Abonumber.xaml", new Dictionary<string, object>{{"in_str_abonumber", in_str_abonumber}, {"in_Config", in_Config}, {"io_uie_sapWnd", io_uie_sapWnd}, {"io_str_lastname", io_str_lastname}, {"io_str_firstname", io_str_firstname}, {"io_str_personalnumber", io_str_personalnumber}, {"io_str_birthdate", io_str_birthdate}, {"io_bool_matchFound", io_bool_matchFound}, {"io_str_finalBemerkung", io_str_finalBemerkung}}, default, default, default, GetAssemblyName());
            return ((UiPath.Core.UiElement)result["io_uie_sapWnd"], (string)result["io_str_lastname"], (string)result["io_str_firstname"], (string)result["io_str_personalnumber"], (string)result["io_str_birthdate"], (bool)result["io_bool_matchFound"], (string)result["io_str_finalBemerkung"]);
        }

        /// <summary>
        /// Invokes the Workflows/Main Workflows/6.3 - Matching Data With Abonumber.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (UiPath.Core.UiElement io_uie_sapWnd, string io_str_lastname, string io_str_firstname, string io_str_personalnumber, string io_str_birthdate, bool io_bool_matchFound, string io_str_finalBemerkung) _6_3___Matching_Data_With_Abonumber(string in_str_abonumber, System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.UiElement io_uie_sapWnd, string io_str_lastname, string io_str_firstname, string io_str_personalnumber, string io_str_birthdate, bool io_bool_matchFound, string io_str_finalBemerkung, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\Main Workflows\6.3 - Matching Data With Abonumber.xaml", new Dictionary<string, object>{{"in_str_abonumber", in_str_abonumber}, {"in_Config", in_Config}, {"io_uie_sapWnd", io_uie_sapWnd}, {"io_str_lastname", io_str_lastname}, {"io_str_firstname", io_str_firstname}, {"io_str_personalnumber", io_str_personalnumber}, {"io_str_birthdate", io_str_birthdate}, {"io_bool_matchFound", io_bool_matchFound}, {"io_str_finalBemerkung", io_str_finalBemerkung}}, default, isolated, default, GetAssemblyName());
            return ((UiPath.Core.UiElement)result["io_uie_sapWnd"], (string)result["io_str_lastname"], (string)result["io_str_firstname"], (string)result["io_str_personalnumber"], (string)result["io_str_birthdate"], (bool)result["io_bool_matchFound"], (string)result["io_str_finalBemerkung"]);
        }

        /// <summary>
        /// Invokes the Workflows/File Workflows/Excel - Write Transactions To Report.xaml
        /// </summary>
        public void Excel___Write_Transactions_To_Report(System.Collections.Generic.Dictionary<string, object> in_Config, System.Collections.Generic.Dictionary<string, object> in_dict_txns)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\File Workflows\Excel - Write Transactions To Report.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_dict_txns", in_dict_txns}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Workflows/File Workflows/Excel - Write Transactions To Report.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Excel___Write_Transactions_To_Report(System.Collections.Generic.Dictionary<string, object> in_Config, System.Collections.Generic.Dictionary<string, object> in_dict_txns, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\File Workflows\Excel - Write Transactions To Report.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_dict_txns", in_dict_txns}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Framework/GetTransactionData.xaml
        /// </summary>
        public (UiPath.Core.QueueItem out_TransactionItem, string out_TransactionID, System.Collections.Generic.Dictionary<string, object> out_dict_txnsItem) GetTransactionData(System.Collections.Generic.Dictionary<string, object> in_Config, System.Collections.Generic.Dictionary<string, object> in_dict_txns)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\GetTransactionData.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_dict_txns", in_dict_txns}}, default, default, default, GetAssemblyName());
            return ((UiPath.Core.QueueItem)result["out_TransactionItem"], (string)result["out_TransactionID"], (System.Collections.Generic.Dictionary<string, object>)result["out_dict_txnsItem"]);
        }

        /// <summary>
        /// Invokes the Framework/GetTransactionData.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (UiPath.Core.QueueItem out_TransactionItem, string out_TransactionID, System.Collections.Generic.Dictionary<string, object> out_dict_txnsItem) GetTransactionData(System.Collections.Generic.Dictionary<string, object> in_Config, System.Collections.Generic.Dictionary<string, object> in_dict_txns, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\GetTransactionData.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_dict_txns", in_dict_txns}}, default, isolated, default, GetAssemblyName());
            return ((UiPath.Core.QueueItem)result["out_TransactionItem"], (string)result["out_TransactionID"], (System.Collections.Generic.Dictionary<string, object>)result["out_dict_txnsItem"]);
        }

        /// <summary>
        /// Invokes the Workflows/Main Workflows/6.7 - Maintain Person In IT40.xaml
        /// </summary>
        public (UiPath.Core.UiElement io_uie_sapWnd, string io_str_finalBemerkung) _6_7___Maintain_Person_In_IT40(string in_str_personalnumber, string in_str_startdate, string in_str_enddate, string in_str_abonumber, System.Collections.Generic.Dictionary<string, object> in_Config, string in_str_productCode, UiPath.Core.UiElement io_uie_sapWnd, string io_str_finalBemerkung)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\Main Workflows\6.7 - Maintain Person In IT40.xaml", new Dictionary<string, object>{{"in_str_personalnumber", in_str_personalnumber}, {"in_str_startdate", in_str_startdate}, {"in_str_enddate", in_str_enddate}, {"in_str_abonumber", in_str_abonumber}, {"in_Config", in_Config}, {"in_str_productCode", in_str_productCode}, {"io_uie_sapWnd", io_uie_sapWnd}, {"io_str_finalBemerkung", io_str_finalBemerkung}}, default, default, default, GetAssemblyName());
            return ((UiPath.Core.UiElement)result["io_uie_sapWnd"], (string)result["io_str_finalBemerkung"]);
        }

        /// <summary>
        /// Invokes the Workflows/Main Workflows/6.7 - Maintain Person In IT40.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (UiPath.Core.UiElement io_uie_sapWnd, string io_str_finalBemerkung) _6_7___Maintain_Person_In_IT40(string in_str_personalnumber, string in_str_startdate, string in_str_enddate, string in_str_abonumber, System.Collections.Generic.Dictionary<string, object> in_Config, string in_str_productCode, UiPath.Core.UiElement io_uie_sapWnd, string io_str_finalBemerkung, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\Main Workflows\6.7 - Maintain Person In IT40.xaml", new Dictionary<string, object>{{"in_str_personalnumber", in_str_personalnumber}, {"in_str_startdate", in_str_startdate}, {"in_str_enddate", in_str_enddate}, {"in_str_abonumber", in_str_abonumber}, {"in_Config", in_Config}, {"in_str_productCode", in_str_productCode}, {"io_uie_sapWnd", io_uie_sapWnd}, {"io_str_finalBemerkung", io_str_finalBemerkung}}, default, isolated, default, GetAssemblyName());
            return ((UiPath.Core.UiElement)result["io_uie_sapWnd"], (string)result["io_str_finalBemerkung"]);
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
        /// Invokes the Framework/InitAllApplications.xaml
        /// </summary>
        public UiPath.Core.UiElement InitAllApplications(System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.UiElement io_uie_sapWnd)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllApplications.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"io_uie_sapWnd", io_uie_sapWnd}}, default, default, default, GetAssemblyName());
            return (UiPath.Core.UiElement)result["io_uie_sapWnd"];
        }

        /// <summary>
        /// Invokes the Framework/InitAllApplications.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public UiPath.Core.UiElement InitAllApplications(System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.UiElement io_uie_sapWnd, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\InitAllApplications.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"io_uie_sapWnd", io_uie_sapWnd}}, default, isolated, default, GetAssemblyName());
            return (UiPath.Core.UiElement)result["io_uie_sapWnd"];
        }

        /// <summary>
        /// Invokes the Workflows/Util Workflows/Normalize Personalnumber.xaml
        /// </summary>
        public string Normalize_Personalnumber(string io_str_personalnumber)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\Util Workflows\Normalize Personalnumber.xaml", new Dictionary<string, object>{{"io_str_personalnumber", io_str_personalnumber}}, default, default, default, GetAssemblyName());
            return (string)result["io_str_personalnumber"];
        }

        /// <summary>
        /// Invokes the Workflows/Util Workflows/Normalize Personalnumber.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public string Normalize_Personalnumber(string io_str_personalnumber, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\Util Workflows\Normalize Personalnumber.xaml", new Dictionary<string, object>{{"io_str_personalnumber", io_str_personalnumber}}, default, isolated, default, GetAssemblyName());
            return (string)result["io_str_personalnumber"];
        }

        /// <summary>
        /// Invokes the Workflows/SAP Workflows/SAP - Close.xaml
        /// </summary>
        public UiPath.Core.UiElement SAP___Close(System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.UiElement io_uie_sapWnd)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\SAP Workflows\SAP - Close.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"io_uie_sapWnd", io_uie_sapWnd}}, default, default, default, GetAssemblyName());
            return (UiPath.Core.UiElement)result["io_uie_sapWnd"];
        }

        /// <summary>
        /// Invokes the Workflows/SAP Workflows/SAP - Close.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public UiPath.Core.UiElement SAP___Close(System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.UiElement io_uie_sapWnd, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflows\SAP Workflows\SAP - Close.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"io_uie_sapWnd", io_uie_sapWnd}}, default, isolated, default, GetAssemblyName());
            return (UiPath.Core.UiElement)result["io_uie_sapWnd"];
        }

        /// <summary>
        /// Invokes the Framework/SetTransactionStatus.xaml
        /// </summary>
        public (int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions) SetTransactionStatus(UiPath.Core.BusinessRuleException in_BusinessException, string in_TransactionID, System.Exception in_SystemException, System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.QueueItem in_TransactionItem, int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\SetTransactionStatus.xaml", new Dictionary<string, object>{{"in_BusinessException", in_BusinessException}, {"in_TransactionID", in_TransactionID}, {"in_SystemException", in_SystemException}, {"in_Config", in_Config}, {"in_TransactionItem", in_TransactionItem}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}, {"io_ConsecutiveSystemExceptions", io_ConsecutiveSystemExceptions}}, default, default, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"], (int)result["io_ConsecutiveSystemExceptions"]);
        }

        /// <summary>
        /// Invokes the Framework/SetTransactionStatus.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions) SetTransactionStatus(UiPath.Core.BusinessRuleException in_BusinessException, string in_TransactionID, System.Exception in_SystemException, System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.QueueItem in_TransactionItem, int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\SetTransactionStatus.xaml", new Dictionary<string, object>{{"in_BusinessException", in_BusinessException}, {"in_TransactionID", in_TransactionID}, {"in_SystemException", in_SystemException}, {"in_Config", in_Config}, {"in_TransactionItem", in_TransactionItem}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}, {"io_ConsecutiveSystemExceptions", io_ConsecutiveSystemExceptions}}, default, isolated, default, GetAssemblyName());
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"], (int)result["io_ConsecutiveSystemExceptions"]);
        }

        /// <summary>
        /// Invokes the Framework/CloseAllApplications.xaml
        /// </summary>
        public UiPath.Core.UiElement CloseAllApplications(System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.UiElement io_uie_sapWnd)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\CloseAllApplications.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"io_uie_sapWnd", io_uie_sapWnd}}, default, default, default, GetAssemblyName());
            return (UiPath.Core.UiElement)result["io_uie_sapWnd"];
        }

        /// <summary>
        /// Invokes the Framework/CloseAllApplications.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public UiPath.Core.UiElement CloseAllApplications(System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.UiElement io_uie_sapWnd, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Framework\CloseAllApplications.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"io_uie_sapWnd", io_uie_sapWnd}}, default, isolated, default, GetAssemblyName());
            return (UiPath.Core.UiElement)result["io_uie_sapWnd"];
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}