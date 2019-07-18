using Remak.Tablet.UI.Helpers;
using Lenze.Library.Opc.Ua;
using Lenze.Library.Opc.Ua.Common;
using System;
using Remak.Tablet.UI.Model;

namespace Remak.Tablet.UI.Services
{
    public class Client
    {
        #region OPC UA Connection

        protected static UaClient _client;
        public static string RootTag { get; private set; }
        protected static string IoTRoot { get; private set; }
        public static bool ConnectionStatus { get; private set; }

        public static void UaConnection()
        {
            if (ConnectionStatus) return;

            var ipAddress = string.IsNullOrEmpty(Global.PlcConfiguration.IpAddress) ? "192.168.5.99" : Global.PlcConfiguration.IpAddress;
            var port = string.IsNullOrEmpty(Global.PlcConfiguration.Port) ? "4840" : Global.PlcConfiguration.Port;

            UaConnection(ipAddress, port);
        }

        public static void UaConnection(string ipAddress, string port = null)
        {
            if (ConnectionStatus) return;

            _client = new UaClient(ipAddress, port);
            _client.Connect();

            try
            {
                RootTag = _client.RootTagGlobal;
                IoTRoot = $"{_client.RootTagGlobal}.GVL.IoT";

                ConnectionStatus = _client.Status == OpcStatus.Connected;
            }
            catch (Exception)
            {
                ConnectionStatus = false;
            }
        }

        public static void Disconnect()
        {
            _client.Dispose();

            try
            {
                ConnectionStatus = _client.Status == OpcStatus.Connected;
            }
            catch (Exception)
            {
                ConnectionStatus = false;
            }
        }
        #endregion

        #region Actuel Data
        public static bool GetActValButton(string id)
        {
            var result = false;
            if (!ConnectionStatus) return result;

            try
            {
                result = _client.Read<bool>($"{IoTRoot}.xButtonActValues.xButtonActValues[{id}]").Value;
            }
            catch (Exception ex)
            {
                Tools.log.Error("function GetActVal: ", ex);

                Global.ErrorToDatabase(
                    new ErrorList { Module = "GetActValButton", Name = "Error", Message = ex.Message, Exception = ex.ToString() }
                );
            }

            return result;
        }

        public static bool[] GetActValButtonsArray()
        {
            bool[] result = null;
            if (!ConnectionStatus) return null;

            try
            {
                result = _client.Read<bool[]>($"{IoTRoot}.xButtonActValues").Value;
            }
            catch (Exception ex)
            {
                Global.ErrorToDatabase(
                    new ErrorList { Module = "GetActValButtonsArray", Name = "Error", Message = ex.Message, Exception = ex.ToString() }
                );
            }

            return result;
        }

        public static double[] GetActValLREALArray()
        {
            double[] result = null;
            if (!ConnectionStatus) return null;

            try
            {
                result = _client.Read<double[]>($"{IoTRoot}.iActLrealValues").Value;
            }
            catch (Exception ex)
            {
                Global.ErrorToDatabase(
                    new ErrorList { Module = "GetActValLREALArray", Name = "Error", Message = ex.Message, Exception = ex.ToString() }
                );
            }

            return result;
        }
        #endregion

        #region Status Data
        public static bool GetStatusVal(string id)
        {
            var result = false;
            if (!ConnectionStatus) return false;

            try
            {
                result = _client.Read<bool>($"{IoTRoot}.xStatusValues.xStatusValues[{id}]").Value;
            }
            catch (Exception ex)
            {
                Tools.log.Error("function GetStatusVal: ", ex);

                Global.ErrorToDatabase(
                    new ErrorList { Module = "GetStatusVal", Name = "Error", Message = ex.Message, Exception = ex.ToString() }
                );
            }

            return result;
        }

        public static bool[] GetStatusValArray()
        {
            bool[] result = null;
            if (!ConnectionStatus) return null;

            try
            {
                result = _client.Read<bool[]>($"{IoTRoot}.xStatusValues").Value;
            }
            catch (Exception ex)
            {
                Tools.log.Error("function GetStatusVal: ", ex);

                Global.ErrorToDatabase(
                    new ErrorList { Module = "GetStatusValArray", Name = "Error", Message = ex.Message, Exception = ex.ToString() }
                );
            }

            return result;
        }
        #endregion

        #region Set Values
        public static string GetSetVal(string id)
        {
            var result = "";
            if (!ConnectionStatus) return result;

            try
            {
                result = _client.Read($"{IoTRoot}.iSetValues.iSetValues[{id}]");
            }
            catch (Exception ex)
            {
                Tools.log.Error("function GetSetVal: ", ex);

                Global.ErrorToDatabase(
                    new ErrorList { Module = "GetSetVal", Name = "Error", Message = ex.Message, Exception = ex.ToString() }
                );
            }

            return result;
        }

        public static short[] GetSetValArray()
        {
            short[] result = null;
            if (!ConnectionStatus) return null;

            try
            {
                result = _client.Read<short[]>($"{IoTRoot}.iSetValues").Value;
            }
            catch (Exception ex)
            {
                Tools.log.Error("function GetSetVal: ", ex);

                Global.ErrorToDatabase(
                    new ErrorList { Module = "GetSetValArray", Name = "Error", Message = ex.Message, Exception = ex.ToString() }
                );
            }

            return result;
        }

        public static bool SetButtonsValue(string id, bool val)
        {
            var result = false;
            if (!ConnectionStatus) return result;
            if (string.IsNullOrEmpty(id)) return result;

            try
            {
                _client.Write($"{IoTRoot}.xButtonSetValues.xButtonSetValues[{id}]", val);
                result = true;
            }
            catch (Exception ex)
            {
                Tools.log.Error("function GetSetVal: ", ex);

                Global.ErrorToDatabase(
                    new ErrorList { Module = "SetButtonsValue", Name = "Error", Message = ex.Message, Exception = ex.ToString() }
                );
            }

            return result;
        }
        #endregion

        #region Control Values
        public static bool GetControlVal(int id)
        {
            var result = false;
            if (!ConnectionStatus) return false;

            try
            {
                result = _client.Read<bool>($"{IoTRoot}.xControlValues.xControlValues[{id}]").Value;
            }
            catch (Exception ex)
            {
                Tools.log.Error("function GetStatusVal: ", ex);

                Global.ErrorToDatabase(
                    new ErrorList { Module = "GetControlVal", Name = "Error", Message = ex.Message, Exception = ex.ToString() }
                );
            }

            return result;
        }

        public static bool SetControlVal(int id, bool val)
        {
            var result = false;
            if (!ConnectionStatus) return false;

            try
            {
                _client.Write($"{IoTRoot}.xControlValues.xControlValues[{id}]", val);
                result = true;
            }
            catch (Exception ex)
            {
                Tools.log.Error("function GetStatusVal: ", ex);

                Global.ErrorToDatabase(
                    new ErrorList { Module = "SetControlVal", Name = "Error", Message = ex.Message, Exception = ex.ToString() }
                );
            }

            return result;
        }
        #endregion
    }
}
