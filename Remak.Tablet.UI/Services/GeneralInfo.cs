using System;
using Remak.Tablet.UI.Helpers;
using Remak.Tablet.UI.Model;

namespace Remak.Tablet.UI.Services
{
    public class GeneralInfo : Client
    {
        public static bool xTabletMaintenance
        {
            get
            {
                var result = false;
                if (!ConnectionStatus) return result;

                try
                {
                    result = _client.Read<bool>($"{IoTRoot}.xTabletMaintenance").Value;
                }
                catch (Exception ex)
                {
                    Global.ErrorToDatabase(
                        new ErrorList { Module = "xTabletMaintenance", Name = "Error", Message = ex.Message, Exception = ex.ToString() }
                    );
                }

                return result;
            }
        }

        public static int xActiveButton
        {
            get
            {
                var result = 0;
                try
                {
                    var xButtonActValues = _client.Read<bool[]>($"{IoTRoot}.xButtonActValues").Value;
                    if (xButtonActValues[30] == true)
                    {
                        result = 1;
                    }
                    else if (xButtonActValues[31] == true)
                    {
                        result = 2;
                    }
                    else  if (xButtonActValues[32] == true)
                    {
                        result = 3;
                    }
                    else if (xButtonActValues[33] == true)
                    {
                        result = 4;
                    }
                    else if (xButtonActValues[34] == true)
                    {
                        result = 5;
                    }
                    else if (xButtonActValues[35] == true)
                    {
                        result = 6;
                    }
                    else if (xButtonActValues[36] == true)
                    {
                        result = 7;
                    }
                    else if (xButtonActValues[37] == true)
                    {
                        result = 8;
                    }

                    return result;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }


        #region Machine Info

        //Makine Kapasite
        public static int iMachineCapacity
        {
            get
            {
                var result = 0;
                if (!ConnectionStatus) return result;

                var iMachine_Capacity = 0;
                try
                {
                    iMachine_Capacity = _client.Read<short>($"{IoTRoot}.iMachineCapacity").Value;
                }
                catch (Exception ex)
                {
                    Tools.log.Error("function iMachineCapacity: ", ex);
                }

                if (iMachine_Capacity > 0)
                {
                    result = iMachine_Capacity;
                }
                else
                {
                    var iRam_Driyer_Selection = iMachineType;
                    switch (iRam_Driyer_Selection)
                    {
                        case 1:
                            result = 100;
                            break;
                        case 2:
                            result = 80;
                            break;
                        default:
                            result = 80;
                            break;
                    }
                }

                return result;
            }
        }

        //Ürün Açıklaması
        public static string sProductDescription
        {
            get
            {
                var result = string.Empty;
                if (!ConnectionStatus) return result;

                try
                {
                    result = _client.Read<string>($"{IoTRoot}.sProductDescription").Value;
                }
                catch (Exception)
                {
                    //
                }

                return result;
            }
        }

        //Firma Adı
        public static string sCompanyName
        {
            get
            {
                var result = string.Empty;
                if (!ConnectionStatus) return result;

                try
                {
                    result = _client.Read<string>($"{IoTRoot}.sCompanyName").Value;
                }
                catch (Exception)
                {
                    //
                }

                return result;
            }
        }

        //Operator Adı
        public static string sOperatorName
        {
            get
            {
                var result = string.Empty;
                if (!ConnectionStatus) return result;

                try
                {
                    result = _client.Read<string>($"{IoTRoot}.sOperatorName").Value;
                }
                catch (Exception)
                {
                    //
                }

                return result;
            }
        }

        //Makine Durumu
        public static string MachineStatus
        {
            get
            {
                var result = string.Empty;
                if (!ConnectionStatus) return result;

                try
                {
                    var state = _client.Read<Int16>($"{RootTag}.GVL.IoT.iMachineState").Value;
                    switch (state)
                    {
                        case 1:
                        case 3:
                            result = @"Normal Duruş";
                            break;
                        case 2:
                            result = @"Makina Hazır";
                            break;
                        case 4:
                            result = @"Makina Alarm";
                            break;
                        case 8:
                            result = @"Makina Çalışıyor";
                            break;
                        default:
                            result = @"Bilgi Bekleniyor...";
                            break;
                    }
                }
                catch (Lenze.Library.Opc.Ua.Common.OpcException opcException)
                {
                    Console.WriteLine(opcException);
                    throw;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

                return result;
            }
        }

        public static int xMachineStatus
        {
            get
            {
                var result = 0;
                if (!ConnectionStatus) return result;

                try
                {
                    result = _client.Read<short>($"{RootTag}.GVL.IoT.iMachineState").Value;
                }
                catch (Lenze.Library.Opc.Ua.Common.OpcException opcException)
                {
                    Console.WriteLine(opcException);
                    throw;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

                return result;
            }
        }

        //Error Kodu no
        public static int iErrorCodeNo
        {
            get
            {
                var result = 0;
                if (!ConnectionStatus) return result;

                try
                {
                    result = _client.Read<short>($"{RootTag}.GVL.iErrorCodeNo").Value;
                }
                catch (Exception)
                {
                    //
                }

                return result;
            }
        }

        //Error Machine Part
        public static int iErrorCodePart
        {
            get
            {
                var result = 0;
                if (!ConnectionStatus) return result;

                try
                {
                    result = _client.Read<short>($"{IoTRoot}.iErrorCodePart").Value;
                }
                catch (Exception)
                {
                    //
                }

                return result;
            }
        }

        #endregion

        #region Machine Speed

        //Makine Hız ACT
        public static float iMachineSpeed
        {
            get
            {
                float result = 0;
                if (!ConnectionStatus) return result;

                try
                {
                    float speed = _client.Read<float>($"{IoTRoot}.rActMachineSpeed").Value;
                    result = speed > 0 ? speed : 0; //speed /10
                }
                catch (Exception)
                {
                    //
                }

                return result;
            }
        }

        //Makine Hız SET
        public static float iMachineSpeedSet
        {
            get
            {
                float result = 0;
                if (!ConnectionStatus) return result;

                try
                {
                    float speed = _client.Read<float>($"{IoTRoot}.rSetMachineSpeed").Value;
                    result = speed > 0 ? speed : 0;
                }
                catch (Exception)
                {
                    //
                }

                return result;
            }
        }

        #endregion

        #region Size Info

        //Kabin Sayısı
        public static int iCabinetSize
        {
            get
            {
                var result = 0;
                if (!ConnectionStatus) return result;

                try
                {
                    var size = _client.Read<Int16>($"{IoTRoot}.iNumberOfCabinet").Value;
                    result = size > 0 ? size : 1;
                }
                catch (Exception ex)
                {
                    //
                    Console.WriteLine(ex);
                }

                return result;
            }
        }

        //Encoder Sayısı
        public static int iEncoderSize
        {
            get
            {
                var result = 0;
                if (!ConnectionStatus) return result;

                try
                {
                    var size = _client.Read<Int16>($"{IoTRoot}.iNumberOfEncoder").Value;
                    result = size > 0 ? size : 1;
                }
                catch (Exception)
                {
                    //
                }

                return result;
            }
        }

        //Fular Sayısı
        public static int iFoulardSize
        {
            get
            {
                var result = 0;
                if (!ConnectionStatus) return result;

                try
                {
                    var size = _client.Read<Int16>($"{IoTRoot}.iNumberOfFoulard").Value;
                    result = size > 0 ? size : 1;
                }
                catch (Exception)
                {
                    throw;
                }

                return result;
            }
        }

        //Baca Sayısı
        public static int iChimneySize
        {
            get
            {
                var result = 0;
                if (!ConnectionStatus) return result;

                try
                {
                    var size = _client.Read<Int16>($"{IoTRoot}.iNumberOfChimney").Value;
                    result = size > 0 ? size : 1;
                }
                catch (Exception)
                {
                    //
                }

                return result;
            }
        }

        //Ram_Kurutma
        public static int iMachineType
        {
            get
            {
                var result = 0;
                if (!ConnectionStatus) return result;

                try
                {
                    var type = _client.Read<Int16>($"{IoTRoot}.iRamDriyerSelection").Value;

                    result = type == 1 || type == 2 ? type : 0;
                }
                catch (Exception ex)
                {
                    //Tools.log.Error("function iMachineType: ", ex);
                }

                return result;
            }
        }

        #endregion

        #region Counter Info

        //Metre Sayac
        public static float rMachineCounterMeter
        {
            get
            {
                float result = 0;
                if (!ConnectionStatus) return result;

                try
                {
                    result = _client.Read<float>($"{IoTRoot}.rActMachineCounterMeter").Value;
                }
                catch (Exception)
                {
                    //
                }

                return result;
            }
        }

        //Elektric Sayas
        public static short rConsumedElecticTotal
        {
            get
            {
                short result = 0;
                if (!ConnectionStatus) return result;

                try
                {
                    result = _client.Read<short>($"{IoTRoot}.rConsumedElecticTotal").Value;
                }
                catch (Exception)
                {
                    //
                }

                return result;
            }
        }

        //Gaz Sayac
        public static short rConsumedGasTotal
        {
            get
            {
                short result = 0;
                if (!ConnectionStatus) return result;

                try
                {
                    result = _client.Read<short>($"{IoTRoot}.rConsumedGasTotal").Value;
                }
                catch (Exception)
                {
                    //
                }

                return result;
            }
        }

        //Hava Sayac
        public static short rConsumedAirTotal
        {
            get
            {
                short result = 0;
                if (!ConnectionStatus) return result;

                try
                {
                    result = _client.Read<short>($"{IoTRoot}.rConsumedAirTotal").Value;
                }
                catch (Exception)
                {
                    //
                }

                return result;
            }
        }

        //Calısma Saati
        public static short rMachineRunnigTimeTotal
        {
            get
            {
                short result = 0;
                if (!ConnectionStatus) return result;

                try
                {
                    result = _client.Read<short>($"{IoTRoot}.rMachineRunnigTimeTotal").Value;
                }
                catch (Exception)
                {
                    //
                }

                return result;
            }
        }

        //Kumaslı Calısma Saati
        public static short rMachineRunnigGoodTimeTotal
        {
            get
            {
                short result = 0;
                if (!ConnectionStatus) return result;

                try
                {
                    result = _client.Read<short>($"{IoTRoot}.rMachineRunnigGoodTimeTotal").Value;
                }
                catch (Exception)
                {
                    //
                }

                return result;
            }
        }

        //Kumassız Calısma Saati
        public static short rMachineRunnigBadTimeTotal
        {
            get
            {
                short result = 0;
                if (!ConnectionStatus) return result;

                try
                {
                    result = _client.Read<short>($"{IoTRoot}.rMachineRunnigBadTimeTotal").Value;
                }
                catch (Exception)
                {
                    //
                }

                return result;
            }
        }

        #endregion
    }
}
